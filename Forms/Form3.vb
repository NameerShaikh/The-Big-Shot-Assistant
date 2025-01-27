Imports System.IO
Imports OfficeOpenXml

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set EPPlus LicenseContext for non-commercial use
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial


        ' Generate Member ID and automatically insert it into the textbox
        TxtMemberId.Text = GenerateMemberId()
    End Sub


    Private Function GenerateMemberId() As String
        Dim filePath As String = "C:\The Big Shot Assistant\Database\Memberships.xlsx"
        Dim lastId As Integer = 0

        ' Check if the Excel file exists and load it
        If File.Exists(filePath) Then
            Using package As New ExcelPackage(New FileInfo(filePath))
                Dim worksheet = package.Workbook.Worksheets(0)
                Dim rowCount = worksheet.Dimension.Rows

                ' Find the last Member ID from the Excel sheet
                For i As Integer = 2 To rowCount ' Skip header row
                    Dim memberId = worksheet.Cells(i, 1).Text

                    If memberId.StartsWith("M") Then
                        Dim numericId As Integer
                        If Integer.TryParse(memberId.Substring(1), numericId) Then
                            lastId = Math.Max(lastId, numericId)
                        End If
                    End If
                Next
            End Using
        End If

        ' Generate the next Member ID
        lastId += 1
        Return "M" & lastId.ToString("D3") ' Format as M001, M002, M003
    End Function


    Private Sub SaveMemberToExcel(memberId As String, name As String, gameType As String, status As String, startDate As String, endDate As String, membershipDuration As String, amountPaid As String)

        Dim ExcelFilePath As String = "C:\The Big Shot Assistant\Database\Memberships.xlsx"

        Try
            ' Check if the Excel file exists, if not, create a new one
            If Not File.Exists(ExcelFilePath) Then
                ' Create a new Excel file if it doesn't exist
                Using package As New ExcelPackage(New FileInfo(ExcelFilePath))
                    Dim worksheet = package.Workbook.Worksheets.Add("Members")
                    worksheet.Cells(1, 1).Value = "Membership ID"
                    worksheet.Cells(1, 2).Value = "Name"
                    worksheet.Cells(1, 3).Value = "Game Type"
                    worksheet.Cells(1, 4).Value = "Status"
                    worksheet.Cells(1, 5).Value = "Start Date"
                    worksheet.Cells(1, 6).Value = "End Date"
                    worksheet.Cells(1, 7).Value = "Membership Duration"
                    worksheet.Cells(1, 8).Value = "Amount Paid"
                    package.Save() ' Save the new Excel file
                End Using
                MessageBox.Show("Excel file created.")
            End If

            ' Append new member data to the existing Excel file
            Using package As New ExcelPackage(New FileInfo(ExcelFilePath))
                Dim worksheet = package.Workbook.Worksheets(0)
                Dim rowCount = worksheet.Dimension.Rows + 1

                ' Debugging: Check if the row count is being updated correctly
                'MessageBox.Show("Row count: " & rowCount.ToString())

                worksheet.Cells(rowCount, 1).Value = memberId
                worksheet.Cells(rowCount, 2).Value = name
                worksheet.Cells(rowCount, 3).Value = gameType
                worksheet.Cells(rowCount, 4).Value = status
                worksheet.Cells(rowCount, 5).Value = startDate
                worksheet.Cells(rowCount, 6).Value = endDate
                worksheet.Cells(rowCount, 7).Value = membershipDuration
                worksheet.Cells(rowCount, 8).Value = amountPaid
                package.Save() ' Save the updated Excel file
                MessageBox.Show("Data saved successfully.")
            End Using
            UpdateMembershipStatusInExcel()

        Catch ex As Exception
            ' Handle any errors that occur
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Generate Member ID
        Dim memberId As String = GenerateMemberId()



        ' Collect other member details
        Dim name As String = TxtName.Text
        Dim gameType As String = CmbGameType.SelectedItem.ToString()
        Dim status As String = CmbStatus.SelectedItem.ToString()
        Dim startDate As String = DtpStartDate.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = DtpEndDate.Value.ToString("yyyy-MM-dd")
        Dim membershipDuration As String = TxtMembershipDuration.Text
        Dim amountPaid As String = CmbAmtPaid.SelectedItem.ToString()

        Try

            ' Save the data to the Excel file
            SaveMemberToExcel(memberId, name, gameType, status, startDate, endDate, membershipDuration, amountPaid)


            ' Close the form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving member: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateMembershipStatusInExcel()
        Try
            ' Define the file path
            Dim filePath As String = "C:\The Big Shot Assistant\Database\Memberships.xlsx"


            ' Load the data from the Excel file
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial ' Set the license context

            ' Load the Excel file
            Using package As New ExcelPackage(New FileInfo(filePath))
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0)

                ' Loop through each row in the Excel file (starting from the second row)
                Dim row As Integer = 2
                While Not String.IsNullOrEmpty(worksheet.Cells(row, 1).Text)
                    Dim endDateText As String = worksheet.Cells(row, 6).Text ' Column 6: End Date
                    Dim statusCell As ExcelRange = worksheet.Cells(row, 4)   ' Column 4: Status

                    ' Check if the End Date is valid
                    Dim endDate As Date
                    If Date.TryParse(endDateText, endDate) Then
                        ' Update the status based on the current date
                        If Date.Today > endDate Then
                            statusCell.Value = "Expired"
                        Else
                            statusCell.Value = "Active"
                        End If
                    End If

                    row += 1
                End While

                ' Save changes to the Excel file
                package.Save()
            End Using

            MessageBox.Show("Membership statuses have been updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating membership statuses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class