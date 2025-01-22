﻿Imports System.IO
Imports OfficeOpenXml

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set EPPlus LicenseContext for non-commercial use
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial


        ' Generate Member ID and automatically insert it into the textbox
        TxtMemberId.Text = GenerateMemberId()
    End Sub


    Private Function GenerateMemberId() As String
        Dim filePath As String = "C:\Users\shaik\OneDrive\Documents\MembershipData.xlsx"
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


    Private Sub SaveMemberToExcel(memberId As String, name As String, membershipType As String, status As String, startDate As String, endDate As String)

        Dim ExcelFilePath As String = "C:\Users\shaik\OneDrive\Documents\MembershipData.xlsx"

        Try
            ' Check if the Excel file exists, if not, create a new one
            If Not File.Exists(ExcelFilePath) Then
                ' Create a new Excel file if it doesn't exist
                Using package As New ExcelPackage(New FileInfo(ExcelFilePath))
                    Dim worksheet = package.Workbook.Worksheets.Add("Members")
                    worksheet.Cells(1, 1).Value = "Membership ID"
                    worksheet.Cells(1, 2).Value = "Name"
                    worksheet.Cells(1, 3).Value = "Membership Type"
                    worksheet.Cells(1, 4).Value = "Status"
                    worksheet.Cells(1, 5).Value = "Start Date"
                    worksheet.Cells(1, 6).Value = "End Date"
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
                worksheet.Cells(rowCount, 3).Value = membershipType
                worksheet.Cells(rowCount, 4).Value = status
                worksheet.Cells(rowCount, 5).Value = startDate
                worksheet.Cells(rowCount, 6).Value = endDate
                package.Save() ' Save the updated Excel file
                MessageBox.Show("Data saved successfully.")
            End Using

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
        Dim membershipType As String = CmbMembershipType.SelectedItem.ToString()
        Dim status As String = CmbStatus.SelectedItem.ToString()
        Dim startDate As String = DtpStartDate.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = DtpEndDate.Value.ToString("yyyy-MM-dd")

        Try

            ' Save the data to the Excel file
            SaveMemberToExcel(memberId, name, membershipType, status, startDate, endDate)


            ' Close the form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving member: " & ex.Message)
        End Try
    End Sub


End Class