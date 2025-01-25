Imports OfficeOpenXml
Imports System.IO

Public Class ActiveExpiredForm


    Private allMemberships As List(Of Membership)

    Public Sub New(isActive As Boolean)
        InitializeComponent()
        ' Load membership data from the Excel file and filter by active/expired
        LoadMembershipData(isActive)
    End Sub

    Private Sub LoadMembershipData(isActive As Boolean)
        ' List to store memberships
        allMemberships = New List(Of Membership)()

        ' Define the file path for the Memberships.xlsx file
        Dim membershipFilePath As String = "C:\Users\shaik\OneDrive\Documents\The Big Shot Assistant Database\Membership Manager\Memberships.xlsx"

        If File.Exists(membershipFilePath) Then
            ' Open the Excel file and read data
            Dim package As New ExcelPackage(New FileInfo(membershipFilePath))
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0)

            ' Loop through the rows in the worksheet to read membership data
            For row As Integer = 2 To worksheet.Dimension.End.Row ' Assuming first row is header
                ' Read the values from the sheet
                Dim membershipID As String = worksheet.Cells(row, 1).Text
                Dim name As String = worksheet.Cells(row, 2).Text
                Dim gameType As String = worksheet.Cells(row, 3).Text
                Dim status As String = worksheet.Cells(row, 4).Text
                Dim startDate As String = worksheet.Cells(row, 5).Text
                Dim endDate As String = worksheet.Cells(row, 6).Text
                Dim membershipDuration As String = worksheet.Cells(row, 7).Text
                Dim amtPaid As String = worksheet.Cells(row, 8).Text

                ' Create a new Membership object and add to the list
                Dim member As New Membership() With {
                    .MembershipID = membershipID,
                    .Name = name,
                    .GameType = gameType,
                    .Status = status,
                    .StartDate = startDate,
                    .EndDate = endDate,
                    .Duration = membershipDuration,
                    .AmtPaid = amtPaid
                }


                allMemberships.Add(member)
            Next

            ' Filter based on status (Active/Expired)
            Dim filteredMembers = allMemberships.Where(Function(m) m.Status = If(isActive, "Active", "Expired")).ToList()

            ' Bind the filtered data to the DataGridView
            DataGridView1.DataSource = filteredMembers
            DataGridView1.ReadOnly = True ' Make DataGridView read-only

            ' Optionally: Auto-size columns to fit content
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Else
            MessageBox.Show("Membership file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class


Public Class Membership
        Public Property MembershipID As String
        Public Property Name As String
        Public Property GameType As String
    Public Property Status As String

    Public Property StartDate As String
    Public Property EndDate As String
    Public Property Duration As String
    Public Property AmtPaid As String


End Class










