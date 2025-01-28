Imports System.ComponentModel
Imports System.IO
Imports System.IO.Packaging
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports OfficeOpenXml





Public Class Form2

    Dim activeCustomerNames As New List(Of String)()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Disable automatic row addition
        DataGridView1.AllowUserToAddRows = False

        ' Call the method to add columns to DataGridView
        AddColumnsToDataGridView()

        ' Add the first row manually
        AddFirstRow()




        InitializeMembershipDataGrid()
        UpdateMembershipStatusInExcel()
        LoadMembershipData()

        CalculateMembershipStatus()


        UpdateMembershipIcons()

    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ' Check if the selected tab is the Inventory tab
        If TabControl1.SelectedTab.Text = "Inventory Manager" Then
            ' Call your function
            SetInventoryDateTimeTextbox()
        End If
    End Sub


    Private currentSerialNumber As Integer = 2

    Private Function GetNextSerialNumber() As Integer

        ' If no rows exist, start with serial number 1
        If DataGridView1.Rows.Count = 0 Then
            Return 1
        End If

        ' Get the last serial number from the last row in the SerialNumber column
        Dim lastSerialNumber As Integer = Convert.ToInt32(DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells("SerialNumber").Value)

        ' Return the next serial number
        Return lastSerialNumber + 1
    End Function

    ' Event: Trigger the button click when editing starts in the last row
    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
        ' Check if the user is editing the last row
        If e.RowIndex = DataGridView1.Rows.Count - 1 Then
            ' Simulate the BtnAddRow click event
            BtnAddRow.PerformClick()
        End If
    End Sub

    Private Sub BtnAddRow_Click(sender As Object, e As EventArgs) Handles BtnAddRow.Click
        ' Create a new row
        Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add())

        ' Set the serial number for the new row
        newRow.Cells("SerialNumber").Value = currentSerialNumber
        DataGridView1.Columns("SerialNumber").ReadOnly = True

        ' Increment the serial number for the next row
        currentSerialNumber += 1

        ' You can set default values for other columns here if necessary
        newRow.Cells("Name").Value = ""  ' Default Name
        newRow.Cells("Date").Value = ""  ' Default Date (empty or you can set it dynamically)
        newRow.Cells("Member").Value = ""  ' Default Member Status
        newRow.Cells("GameType").Value = ""  ' Default Game Type
        newRow.Cells("TableNumber").Value = ""  ' Default Table Number
        newRow.Cells("StartTime").Value = ""  ' Default Start Time
        newRow.Cells("EndTime").Value = ""  ' Default End Time
        newRow.Cells("FrameNumber").Value = ""  ' Default Frame Number
        newRow.Cells("Payment").Value = ""  ' Default Payment type
        newRow.Cells("Amount").Value = ""  ' Default Amount
        newRow.Cells("AddOns").Value = ""  ' Default Name
        newRow.Cells("Total").Value = ""  ' Default Name
        newRow.Cells("PaymentStatus").Value = ""  ' Default Payment Status


        ' Inside method where a row is added to the Entry Manager grid
        ' Assuming you are adding customer names to the grid here:
        activeCustomerNames.Add(Name) ' customerName is the name of the person added in the Entry Manager grid



    End Sub





    Private Sub DataGridView1_Paint(sender As Object, e As PaintEventArgs) Handles DataGridView1.Paint
        Try
            ' Load the logo image
            Dim logo As Image = Image.FromFile("C:\The Big Shot Assistant\Images\DGBG.jpg")

            ' Create a rectangle that matches the size of the DataGridView1
            Dim gridRectangle As New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height)

            ' Set transparency level (already in the image or by code)
            Dim logoOpacity As Single = 0.08F ' Adjust as needed (0.0 to 1.0)
            Dim attributes As New Imaging.ImageAttributes()
            Dim colorMatrix As New Imaging.ColorMatrix() With {
            .Matrix33 = logoOpacity
        }
            attributes.SetColorMatrix(colorMatrix, Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Bitmap)

            ' Draw the scaled image on the DataGridView1 background
            e.Graphics.DrawImage(
            logo,
            gridRectangle, ' Stretch the image to fit the DataGridView1
            0,
            0,
            logo.Width,
            logo.Height,
            GraphicsUnit.Pixel,
            attributes
        )
        Catch ex As Exception
            MessageBox.Show("Error drawing logo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_Resize(sender As Object, e As EventArgs) Handles DataGridView1.Resize
        ' Redraw the DataGridView1 when resized
        DataGridView1.Invalidate() ' Triggers the Paint event
    End Sub












    Private Sub AddColumnsToDataGridView()

        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)




        ' Add Serial Number column
        Dim serialColumn As New DataGridViewTextBoxColumn()
        serialColumn.Name = "SerialNumber"
        serialColumn.HeaderText = "Serial Number"
        serialColumn.ReadOnly = False
        DataGridView1.Columns.Add(serialColumn)

        ' Add Name column
        Dim nameColumn As New DataGridViewTextBoxColumn()
        nameColumn.Name = "Name"
        nameColumn.HeaderText = "Name"
        DataGridView1.Columns.Add(nameColumn)

        ' Add Member column (ComboBox)
        Dim memberColumn As New DataGridViewComboBoxColumn()
        memberColumn.Name = "Member"
        memberColumn.HeaderText = "Member"
        memberColumn.Items.AddRange("Member", "Non-Member")
        DataGridView1.Columns.Add(memberColumn)


        ' Add Date column
        Dim dateColumn As New DataGridViewTextBoxColumn()
        dateColumn.Name = "Date"
        dateColumn.HeaderText = "Date"
        DataGridView1.Columns.Add(dateColumn)

        ' Add Game Type column (ComboBox)
        Dim gameTypeColumn As New DataGridViewComboBoxColumn()
        gameTypeColumn.Name = "GameType"
        gameTypeColumn.HeaderText = "Game Type"
        gameTypeColumn.Items.AddRange("Pool", "Mini Snooker", "Snooker")
        DataGridView1.Columns.Add(gameTypeColumn)

        ' Add Table Number column (ComboBox)
        Dim tableNumberColumn As New DataGridViewComboBoxColumn()
        tableNumberColumn.Name = "TableNumber"
        tableNumberColumn.HeaderText = "Table Number"
        ' Initially add all the tables (they'll be filtered later based on the game type)
        tableNumberColumn.Items.AddRange("Table 1", "Table 2", "Table 3", "Table 4")
        DataGridView1.Columns.Add(tableNumberColumn)

        ' Add Start Time column
        Dim startTimeColumn As New DataGridViewTextBoxColumn()
        startTimeColumn.Name = "StartTime"
        startTimeColumn.HeaderText = "Start Time"
        DataGridView1.Columns.Add(startTimeColumn)

        ' Add End Time column
        Dim endTimeColumn As New DataGridViewTextBoxColumn()
        endTimeColumn.Name = "EndTime"
        endTimeColumn.HeaderText = "End Time"
        DataGridView1.Columns.Add(endTimeColumn)

        ' Add Frame Number column (ComboBox)
        Dim frameNumberColumn As New DataGridViewComboBoxColumn()
        frameNumberColumn.Name = "FrameNumber"
        frameNumberColumn.HeaderText = "No. Of Frames"
        frameNumberColumn.Items.AddRange("0", "1", "2", "3", "4", "5")
        DataGridView1.Columns.Add(frameNumberColumn)

        ' Add Payment column (ComboBox)
        Dim paymentColumn As New DataGridViewComboBoxColumn()
        paymentColumn.Name = "Payment"
        paymentColumn.HeaderText = "Payment"
        paymentColumn.Items.AddRange("Frame Wise", "Time Wise")
        DataGridView1.Columns.Add(paymentColumn)

        ' Add Amount column
        Dim amountColumn As New DataGridViewTextBoxColumn()
        amountColumn.Name = "Amount"
        amountColumn.HeaderText = "Table Charge"
        DataGridView1.Columns.Add(amountColumn)

        ' Add Ons column
        Dim addOnsColumn As New DataGridViewTextBoxColumn()
        addOnsColumn.Name = "AddOns"
        addOnsColumn.HeaderText = "AddOns"
        DataGridView1.Columns.Add(addOnsColumn)



        'Total amount = amount + add-ons
        Dim totalColumn As New DataGridViewTextBoxColumn()
        totalColumn.Name = "Total"
        totalColumn.HeaderText = "Total"
        DataGridView1.Columns.Add(totalColumn)

        ' Add Payment Status column
        Dim paymentStatusColumn As New DataGridViewComboBoxColumn()
        paymentStatusColumn.Name = "PaymentStatus"
        paymentStatusColumn.HeaderText = "Payment Status"
        paymentStatusColumn.Items.AddRange("Paid", "Pending")
        DataGridView1.Columns.Add(paymentStatusColumn)

    End Sub


    Private Sub AddFirstRow()
        ' Add the first row with the serial number
        Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add())

        ' Set the serial number for the first row
        newRow.Cells("SerialNumber").Value = 1
        DataGridView1.Columns("SerialNumber").ReadOnly = True

        ' Set other default values for the first row
        newRow.Cells("Name").Value = ""  ' Default Name
        newRow.Cells("Date").Value = ""  ' Default Date (empty or dynamically set)
        newRow.Cells("Member").Value = ""  ' Default Member Status
        newRow.Cells("GameType").Value = ""  ' Default Game Type
        newRow.Cells("TableNumber").Value = ""  ' Default Table Number
        newRow.Cells("StartTime").Value = ""  ' Default Start Time
        newRow.Cells("EndTime").Value = ""  ' Default End Time
        newRow.Cells("FrameNumber").Value = ""  ' Default Frame Number
        newRow.Cells("Payment").Value = ""  ' Default Payment type
        newRow.Cells("Amount").Value = ""  ' Default Amount
        newRow.Cells("AddOns").Value = ""  ' Default AddOns
        newRow.Cells("Total").Value = ""  ' Default Total
        newRow.Cells("PaymentStatus").Value = ""  ' Default Payment Status

        ' Attach the CellBeginEdit event handler
        AddHandler DataGridView1.CellBeginEdit, AddressOf DataGridView1_CellBeginEdit



    End Sub





    Dim openComboBox As ComboBox = Nothing

    ' This event fires when the user moves the mouse over the DataGridView
    Private Sub DataGridView1_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseMove
        Dim hitTest As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)

        ' Check if the mouse is hovering over a ComboBoxCell
        If hitTest.Type = DataGridViewHitTestType.Cell AndAlso
       TypeOf DataGridView1.Rows(hitTest.RowIndex).Cells(hitTest.ColumnIndex) Is DataGridViewComboBoxCell Then

            Dim comboBoxCell As DataGridViewComboBoxCell = CType(DataGridView1.Rows(hitTest.RowIndex).Cells(hitTest.ColumnIndex), DataGridViewComboBoxCell)

            ' Open the dropdown if it is not already opened
            If openComboBox Is Nothing Then
                ' Set the current cell to be edited (opens the combo box)
                DataGridView1.CurrentCell = DataGridView1.Rows(hitTest.RowIndex).Cells(hitTest.ColumnIndex)

                ' Force the ComboBox dropdown to open
                Dim comboBox As ComboBox = CType(DataGridView1.EditingControl, ComboBox)
                If comboBox IsNot Nothing Then
                    comboBox.DroppedDown = True
                    openComboBox = comboBox  ' Store reference to the open combo box
                End If
            End If
        End If
    End Sub

    ' This event fires when editing ends and the combo box dropdown needs to be closed
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        ' When editing is done, close the dropdown if it was open
        If openComboBox IsNot Nothing Then
            openComboBox.DroppedDown = False
            openComboBox = Nothing  ' Clear reference to the open combo box
        End If
    End Sub










    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BtnStrikeRow_Click(sender As Object, e As EventArgs) Handles BtnStrikeRow.Click
        ' Check if any row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the first selected row (you can modify this if multiple rows are allowed)
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Loop through each cell in the row and apply strikethrough font style
            For Each cell As DataGridViewCell In selectedRow.Cells
                ' Apply strikethrough font style to the cell text
                cell.Style.Font = New Font(cell.InheritedStyle.Font, FontStyle.Strikeout)
            Next
        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub



    ' Function to recalculate the total revenue
    ' Function to recalculate the total revenue, excluding struck-out rows
    ' Button click event to calculate total revenue
    ' Button click event to calculate total revenue
    Private Sub BtnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles BtnCalculateRevenue.Click
        Dim totalRevenue As Decimal = 0

        ' Loop through all rows in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Check if the row is not empty, not struck out, and the Amount column has a valid value
            If Not row.IsNewRow AndAlso Not IsRowStruckOut(row) AndAlso Not IsDBNull(row.Cells("Total").Value) AndAlso IsNumeric(row.Cells("Total").Value) Then
                totalRevenue += Convert.ToDecimal(row.Cells("Total").Value)
            End If
        Next

        ' Update the label with the total revenue in INR format
        TotalRevenueLabel1.Text = totalRevenue.ToString("N2") ' INR symbol with 2 decimal places
    End Sub

    ' Button click event to reset the total revenue to zero
    Private Sub BtnClearRevenue_Click(sender As Object, e As EventArgs) Handles BtnClearRevenue.Click
        TotalRevenueLabel1.Text = "Total Revenue: ₹0.00" ' Reset to zero with INR formatting
    End Sub

    ' Helper function to check if a row is struck out
    Private Function IsRowStruckOut(row As DataGridViewRow) As Boolean
        For Each cell As DataGridViewCell In row.Cells
            ' Check if the cell's font style is set to Strikeout
            If cell.Style.Font IsNot Nothing AndAlso cell.Style.Font.Style.HasFlag(FontStyle.Strikeout) Then
                Return True ' If any cell in the row is struck out, consider the row as struck out
            End If
        Next
        Return False ' If no cells are struck out, the row is not struck out
    End Function








    ' Button click event for Start Time
    Private Sub BtnStartTime_Click(sender As Object, e As EventArgs) Handles BtnStartTime.Click
        ' Check if a row is selected
        If DataGridView1.CurrentRow IsNot Nothing AndAlso Not DataGridView1.CurrentRow.IsNewRow Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow

            ' Check if Date and Start Time columns exist
            If selectedRow.Cells("Date") IsNot Nothing AndAlso selectedRow.Cells("StartTime") IsNot Nothing Then
                ' Set the current system date in the Date column
                selectedRow.Cells("Date").Value = DateTime.Now.ToString("dd MMM yy") ' Format: 20 Jan 25

                ' Set the current system time in the Start Time column
                selectedRow.Cells("StartTime").Value = DateTime.Now.ToString("hh:mm tt") ' Format: 02:30 PM
            Else
                MessageBox.Show("Date or Start Time column not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a valid row to set the Date and Start Time.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Button click event for End Time
    ' Button click event for End Time
    Private Sub BtnEndTime_Click(sender As Object, e As EventArgs) Handles BtnEndTime.Click
        ' Check if a row is selected
        If DataGridView1.CurrentRow IsNot Nothing AndAlso Not DataGridView1.CurrentRow.IsNewRow Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow

            ' Check if the Date, Start Time, and End Time columns exist
            If selectedRow.Cells("Date") IsNot Nothing AndAlso selectedRow.Cells("StartTime") IsNot Nothing AndAlso selectedRow.Cells("EndTime") IsNot Nothing Then
                ' Get the current system time
                Dim currentDateTime As DateTime = DateTime.Now

                ' Set the current system time to the End Time column
                selectedRow.Cells("EndTime").Value = currentDateTime.ToString("hh:mm tt") ' Format: 01:00 AM
            Else
                MessageBox.Show("Date, Start Time, or End Time column not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a valid row to set the End Time.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub













    Function RoundToNearestFive(amount As Double) As Double
        Return Math.Round(amount / 5) * 5
    End Function

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Try

            ' Check if any rows are selected
            Dim selectedRows = DataGridView1.SelectedRows
            If selectedRows.Count = 0 Then
                MessageBox.Show("Please select at least one row to calculate the total.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            For Each row As DataGridViewRow In selectedRows
                If Not row.IsNewRow Then
                    Dim gameType As String = row.Cells("GameType").Value?.ToString()?.ToLower()
                    Dim startTime As DateTime = DateTime.Parse(row.Cells("StartTime").Value?.ToString())
                    Dim endTime As DateTime = DateTime.Parse(row.Cells("EndTime").Value?.ToString())
                    Dim duration As Double = (endTime - startTime).TotalMinutes
                    Dim memberStatus As String = row.Cells("Member").Value?.ToString()?.ToLower()
                    Dim paymentMethod As String = row.Cells("Payment").Value?.ToString()?.ToLower()
                    Dim amount As Double = 0


                    ' Skip calculation for members
                    If memberStatus = "member" Then
                        row.Cells("Amount").Value = 0
                        Continue For
                    End If

                    Select Case gameType
                        Case "pool"
                            If duration <= 30 Then
                                amount = 100
                            ElseIf duration <= 50 Then
                                amount = 100 + (duration - 30) * (150 / 60)
                            ElseIf duration <= 60 Then
                                amount = 150
                            Else
                                amount = 150 + (duration - 60) * (150 / 60)
                            End If

                        Case "mini snooker"
                            If duration <= 30 Then
                                amount = 130
                            ElseIf duration <= 50 Then
                                amount = 130 + (duration - 30) * (200 / 60)
                            ElseIf duration <= 60 Then
                                amount = 200
                            Else
                                amount = 200 + (duration - 60) * (200 / 60)
                            End If

                        Case "snooker"
                            If paymentMethod = "time wise" Then
                                If duration <= 30 Then
                                    amount = 150
                                ElseIf duration <= 50 Then
                                    amount = 150 + (duration - 30) * (200 / 60)
                                ElseIf duration <= 60 Then
                                    amount = 250
                                Else
                                    amount = 200 + (duration - 60) * (200 / 60)
                                End If
                            ElseIf paymentMethod = "frame wise" Then
                                ' Existing frame-based calculation logic
                                Dim frames As Integer = Integer.Parse(row.Cells("FrameNumber").Value?.ToString())
                                If frames = 1 Then
                                    amount = 150
                                ElseIf frames = 2 Then
                                    amount = 300
                                ElseIf frames > 2 Then
                                    amount = 300 + ((frames - 2) * 125)
                                End If
                            End If
                    End Select

                    ' Round to the nearest 5
                    row.Cells("Amount").Value = RoundToNearestFive(amount)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred during calculation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click
        Try
            ' Check if any rows are selected
            Dim selectedRows = DataGridView1.SelectedRows
            If selectedRows.Count = 0 Then
                MessageBox.Show("Please select at least one row to calculate the total.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Iterate over selected rows
            For Each row As DataGridViewRow In selectedRows
                If Not row.IsNewRow Then
                    Dim amount As Double = 0
                    Dim addOns As Double = 0

                    ' Safely parse values from Amount and AddOns columns
                    If Not Double.TryParse(row.Cells("Amount").Value?.ToString(), amount) Then
                        MessageBox.Show("Invalid value in 'Table Charge' column.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    If Not Double.TryParse(row.Cells("AddOns").Value?.ToString(), addOns) Then
                        MessageBox.Show("Invalid value in AddOns column.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Update Total column
                    row.Cells("Total").Value = amount + addOns
                End If
            Next

        Catch ex As Exception
            ' Catch any unhandled exceptions
            MessageBox.Show("An error occurred while calculating the total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub















    Private Sub InitializeMembershipDataGrid()
        ' Clear existing columns (if any)
        MembershipDataGrid.Columns.Clear()

        ' Membership ID Column
        Dim colMembershipID As New DataGridViewTextBoxColumn()
        colMembershipID.Name = "Membership ID"
        colMembershipID.HeaderText = "Membership ID"
        colMembershipID.ReadOnly = True
        MembershipDataGrid.Columns.Add(colMembershipID)

        ' Name Column
        Dim colName As New DataGridViewTextBoxColumn()
        colName.Name = "Name"
        colName.HeaderText = "Name"
        MembershipDataGrid.Columns.Add(colName)



        ' Membership Type Column (Dropdown)
        Dim colGameType As New DataGridViewTextBoxColumn()
        colGameType.Name = "Game Type"
        colGameType.HeaderText = "Type"
        MembershipDataGrid.Columns.Add(colGameType)




        ' Membership Status Column (Dropdown)
        Dim colStatus As New DataGridViewTextBoxColumn()
        colStatus.Name = "Membership Status"
        colStatus.HeaderText = "Status"
        MembershipDataGrid.Columns.Add(colStatus)





        ' Icon Column for Status
        Dim colStatusIcon As New DataGridViewImageColumn()
        colStatusIcon.Name = "Status Icon"
        colStatusIcon.HeaderText = "Status Icon"
        colStatusIcon.ImageLayout = DataGridViewImageCellLayout.Zoom ' Adjust image layout
        colStatusIcon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Center alignment
        MembershipDataGrid.Columns.Add(colStatusIcon)


        ' Configure DataGridView properties
        MembershipDataGrid.AllowUserToAddRows = True
        MembershipDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        MembershipDataGrid.MultiSelect = False
        MembershipDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



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

        Catch ex As Exception
            MessageBox.Show("Error updating membership statuses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CalculateMembershipStatus()
        Try
            Dim activeCount As Integer = 0
            Dim expiredCount As Integer = 0

            ' Loop through rows in MembershipDataGrid to count active and expired members
            For Each row As DataGridViewRow In MembershipDataGrid.Rows
                If Not row.IsNewRow Then
                    Dim membershipStatus As String = row.Cells("Membership Status").Value?.ToString().ToLower()

                    If membershipStatus = "active" Then
                        activeCount += 1
                    ElseIf membershipStatus = "expired" Then
                        expiredCount += 1
                    End If
                End If
            Next

            ' Update labels with the counts
            ActiveMemberLabel.Text = $"{activeCount}"
            ExpiredMemberLabel.Text = $"{expiredCount}"

        Catch ex As Exception
            ' Handle any unexpected errors
            MessageBox.Show($"An error occurred while calculating membership status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    Private Sub LoadMembershipData()
        ' Define the file path for the Memberships.xlsx file
        Dim filePath As String = "C:\The Big Shot Assistant\Database\Memberships.xlsx"

        ' Ensure the file exists before proceeding
        If Not File.Exists(filePath) Then
            MessageBox.Show("The Memberships file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Load the data from the Excel file
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial ' Set the license context

        Using package As New ExcelPackage(New FileInfo(filePath))
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0) ' Load the first worksheet

            ' Ensure the worksheet has data
            If worksheet.Dimension Is Nothing Then Exit Sub

            ' Clear existing rows in the DataGridView
            MembershipDataGrid.Rows.Clear()

            ' Loop through the rows in the worksheet starting from the second row (skip headers)
            For row As Integer = 2 To worksheet.Dimension.End.Row
                ' Retrieve data from the respective columns
                Dim membershipID As String = worksheet.Cells(row, 1).Text ' Membership ID
                Dim name As String = worksheet.Cells(row, 2).Text ' Name
                Dim gameType As String = worksheet.Cells(row, 3).Text ' Game Type
                Dim status As String = worksheet.Cells(row, 4).Text ' Status
                Dim statusIcon As Image = Nothing

                ' Determine the icon based on the status
                UpdateMembershipIcons()

                ' Add the data to the DataGridView
                MembershipDataGrid.Rows.Add(membershipID, name, gameType, status, statusIcon)
            Next
        End Using
    End Sub








    Private Sub UpdateMembershipIcons()
        Try
            ' Paths to icons for active and expired members
            Dim activeIcon As Image = Image.FromFile("C:\The Big Shot Assistant\Images\Check.jpg")
            Dim expiredIcon As Image = Image.FromFile("C:\The Big Shot Assistant\Images\Cross.jpg")

            ' Loop through the rows in MembershipDataGrid
            For Each row As DataGridViewRow In MembershipDataGrid.Rows
                If Not row.IsNewRow Then
                    Dim membershipStatus As String = row.Cells("Membership Status").Value?.ToString().ToLower()

                    ' Assign icon based on status
                    If membershipStatus = "active" Then
                        row.Cells("Status Icon").Value = activeIcon
                    ElseIf membershipStatus = "expired" Then
                        row.Cells("Status Icon").Value = expiredIcon
                    End If
                End If
            Next

        Catch ex As Exception
            ' Handle any errors (e.g., file not found, null reference)
            MessageBox.Show($"An error occurred while updating membership icons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub BtnCheckActive_Click(sender As Object, e As EventArgs) Handles BtnCheckActive.Click
        ' Open the form showing active memberships
        Dim activeForm As New ActiveExpiredForm(True) ' Pass True to show active memberships
        activeForm.Show()
    End Sub

    Private Sub BtnCheckExpired_Click(sender As Object, e As EventArgs) Handles BtnCheckExpired.Click
        ' Open the form showing expired memberships
        Dim expiredForm As New ActiveExpiredForm(False) ' Pass False to show expired memberships
        expiredForm.Show()
    End Sub










    Private Sub BtnAddMember_Click(sender As Object, e As EventArgs) Handles BtnAddMember.Click
        ' Open Add Member Form
        Dim addMemberForm As New Form3()
        addMemberForm.ShowDialog()

        ' Reload DataGridView after form is closed
        LoadMembershipData()

        CalculateMembershipStatus()
        UpdateMembershipIcons()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click
        ' Check if a row is selected in the DataGridView
        If MembershipDataGrid.SelectedRows.Count > 0 Then
            ' Get the selected Member ID (or key identifier) from the DataGridView
            Dim memberId As String = MembershipDataGrid.SelectedRows(0).Cells(0).Value.ToString()

            ' Path to the Excel file
            Dim excelFilePath As String = "C:\The Big Shot Assistant\Database\Memberships.xlsx"

            ' Call the function to fetch details from the Excel file
            Dim memberDetails As List(Of String) = GetMemberDetailsFromExcel(memberId, excelFilePath)

            ' If details are found, open Form4 and pass the details
            If memberDetails IsNot Nothing AndAlso memberDetails.Count >= 8 Then
                Dim form4 As New Form4()
                form4.DisplayMemberDetails(memberDetails)
                form4.Show()
            Else
                MessageBox.Show("Member details not found in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a row to view details.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Function to retrieve member details from the Excel file using EPPlus
    Private Function GetMemberDetailsFromExcel(memberId As String, filePath As String) As List(Of String)
        Dim details As New List(Of String)

        Try
            ' Open the Excel file using EPPlus
            Using package As New ExcelPackage(New FileInfo(filePath))
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0) ' Assume data is in the first sheet

                ' Find the row with the matching Member ID (assuming it is in column 1)
                For row As Integer = 2 To worksheet.Dimension.Rows ' Start from 2 to skip headers
                    Dim currentId As String = worksheet.Cells(row, 1).Text ' Column A for Member ID
                    If currentId = memberId Then
                        ' Fetch all 8 columns of data (columns 1 to 8)
                        For col As Integer = 1 To 8
                            details.Add(worksheet.Cells(row, col).Text)
                        Next
                        Exit For
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading Excel file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return details
    End Function















    Private Sub BtnSaveNotes_Click(sender As Object, e As EventArgs) Handles BtnSaveNotes.Click

        ' Get the current date and time for timestamping the data inside the file
        Dim currentDateTime As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        ExportNotesAndAddOns(currentDateTime)

    End Sub

    Private Sub RichTextBox1_Paint(sender As Object, e As PaintEventArgs) Handles RichTextBox1.Paint
        ' Create a pen with a bold width and color for the border
        Dim boldBorderPen As New Pen(Color.Black, 3) ' 3 is the width of the bold border

        ' Draw the border (Rectangle) around the RichTextBox
        e.Graphics.DrawRectangle(boldBorderPen, 0, 0, RichTextBox1.Width - 1, RichTextBox1.Height - 1)
    End Sub








    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Try
            ' Step 1: Programmatically press BtnCalculateRevenue to calculate total revenue
            BtnCalculateRevenue.PerformClick()
            BtnBaseTotal.PerformClick()

            ' Step 2: Get the calculated total revenue
            Dim totalRevenue As Double = Double.Parse(TotalRevenueLabel1.Text)
            Dim totalBaseRevenue As Double = Double.Parse(TotalTableChargeLabel.Text)

            ' Step 3: Get the current date and time for timestamping the data inside the file
            Dim currentDateTime As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")

            ' Export for Entry Manager Tab
            ExportEntryManager(currentDateTime, totalRevenue, totalBaseRevenue)



            ' Export for Notes and AddOns Tab
            ExportNotesAndAddOns(currentDateTime)

            MessageBox.Show("Data Exported Successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while exporting: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportEntryManager(currentDateTime As String, totalRevenue As Double, totalBaseRevenue As Double)
        ' Define the master file path for Entry Manager
        Dim entryFilePath As String = "C:\The Big Shot Assistant\Database\Entries.xlsx"

        Dim package As New ExcelPackage(New FileInfo(entryFilePath))
        Dim worksheet As ExcelWorksheet

        ' Check if the worksheet exists or needs to be created
        If package.Workbook.Worksheets.Count = 0 Then
            worksheet = package.Workbook.Worksheets.Add("Entries")
        Else
            worksheet = package.Workbook.Worksheets(0)
        End If

        ' Add the timestamp to a new row in the first column
        Dim rowIndex As Integer = If(worksheet.Dimension Is Nothing, 1, worksheet.Dimension.End.Row + 1)
        worksheet.Cells(rowIndex, 1).Value = $"Exported on {currentDateTime}"

        ' Loop through the data and append it, and add Total Revenue in the last row
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                worksheet.Cells(i + rowIndex + 1, j + 1).Value = DataGridView1.Rows(i).Cells(j).Value
            Next
        Next

        ' Add Total Base Revenue in the last second row
        worksheet.Cells(rowIndex + DataGridView1.Rows.Count + 1, DataGridView1.Columns.Count + 1).Value = totalBaseRevenue
        worksheet.Cells(rowIndex + DataGridView1.Rows.Count + 1, DataGridView1.Columns.Count + 2).Value = totalRevenue

        ' Save the file with the new data
        package.Save()
    End Sub









    Private Function ExportNotesAndAddOns(currentDateTime As String) As Boolean
        ' Define the master file path for Notes and AddOns
        Dim notesFilePath As String = "C:\The Big Shot Assistant\Database\Notes and AddOns Data.xlsx"

        ' Get the current notes text from RichTextBox
        Dim currentNotes As String = RichTextBox1.Text

        ' Ensure notes are not empty before saving
        If String.IsNullOrWhiteSpace(currentNotes) Then
            MessageBox.Show("No notes to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if the notes text has changed (if yes, save the new version)
        If HasNotesChanged(notesFilePath, currentNotes) Then
            Dim package As New ExcelPackage(New FileInfo(notesFilePath))

            ' Check if there are worksheets already
            Dim worksheet As ExcelWorksheet
            If package.Workbook.Worksheets.Count = 0 Then
                ' If no worksheets exist, create a new one
                worksheet = package.Workbook.Worksheets.Add("NotesAndAddOns")
            Else
                ' If worksheets exist, get the first one
                worksheet = package.Workbook.Worksheets(0)
            End If

            ' Check if the worksheet is empty (first export), if so, start from the first row
            Dim rowIndex As Integer
            If worksheet.Dimension Is Nothing Then
                rowIndex = 1 ' If worksheet is empty, start at row 1
            Else
                rowIndex = worksheet.Dimension.End.Row + 1 ' Otherwise, append to the next available row
            End If

            ' Add the timestamp in column "A" for each row
            worksheet.Cells(rowIndex, 1).Value = currentDateTime

            ' Add notes to the next row in column "B"
            worksheet.Cells(rowIndex + 1, 2).Value = currentNotes

            ' Save the file with the new data
            package.Save()

            MessageBox.Show("Notes have been successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No changes detected. Notes have not been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



        Return False
    End Function

    Private Function HasNotesChanged(filePath As String, currentNotes As String) As Boolean
        ' Check if the current notes content has changed by comparing it with the last saved notes
        If Not File.Exists(filePath) Then
            Return True ' If the file does not exist, save the new notes
        End If

        Dim package As New ExcelPackage(New FileInfo(filePath))
        Dim worksheet As ExcelWorksheet

        ' Check if there are any worksheets
        If package.Workbook.Worksheets.Count = 0 Then
            ' If no worksheets exist, return true to save new notes
            Return True
        End If

        worksheet = package.Workbook.Worksheets(0)

        ' If the worksheet is empty, save the new notes
        If worksheet.Dimension Is Nothing Then
            Return True
        End If

        ' If the last saved notes are different, save the new notes
        Dim lastSavedNotes As String = worksheet.Cells(worksheet.Dimension.End.Row, 1).Value?.ToString()
        If lastSavedNotes <> currentNotes Then
            Return True
        End If

        Return False
    End Function












    Dim exportInitiated As Boolean = False ' Flag to track export initiation
    Dim closingInitiated As Boolean = False ' Flag to track if form closing is initiated

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ' Check if the form closing logic has been initiated before
            If Not closingInitiated Then
                ' Mark the form closing as initiated
                closingInitiated = True

                ' Check if export has already been initiated
                If Not exportInitiated Then
                    ' Show message box prompting user to export data before closing
                    Dim result As DialogResult = MessageBox.Show("Do you want to export the data before closing?", "Export Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                    ' If user chooses Yes, export the data
                    If result = DialogResult.Yes Then
                        ' Set the flag to true to indicate export has been initiated
                        exportInitiated = True

                        ' Trigger the export logic (only once)
                        BtnExport.PerformClick()  ' Triggering the Export process

                        ' Show success message and exit application after export
                        MessageBox.Show("Data exported successfully. Closing the application.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Application.Exit()  ' Exit the application

                        ' If user chooses No, close the application without exporting
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Closing the application without exporting data.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Application.Exit()  ' Exit the application

                        ' If user clicks Cancel, prevent the form from closing
                    ElseIf result = DialogResult.Cancel Then
                        e.Cancel = True ' Cancel the form closing event
                        MessageBox.Show("The application will not close. Please save your data or go back.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                ' Prevent additional closing prompts if closing was initiated
                e.Cancel = False
            End If

        Catch ex As Exception
            ' Handle any errors that occur during the exit process
            MessageBox.Show("An error occurred while attempting to exit: " & ex.Message, "Exit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub BtnBaseTotal_Click(sender As Object, e As EventArgs) Handles BtnBaseTotal.Click
        Dim totalBaseRevenue As Decimal = 0

        ' Loop through all rows in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Check if the row is not empty, not struck out, and the Amount column has a valid value
            If Not row.IsNewRow AndAlso Not IsRowStruckOut(row) AndAlso Not IsDBNull(row.Cells("Amount").Value) AndAlso IsNumeric(row.Cells("Amount").Value) Then
                totalBaseRevenue += Convert.ToDecimal(row.Cells("Amount").Value)
            End If
        Next

        ' Update the label with the total revenue in INR format
        TotalTableChargeLabel.Text = totalBaseRevenue.ToString("N2") ' INR symbol with 2 decimal places
    End Sub



    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        BtnSetDateTime.PerformClick()
    End Sub








    Private Sub BtnSetDateTime_Click(sender As Object, e As EventArgs) Handles BtnSetDateTime.Click
        SetInventoryDateTimeTextbox()
    End Sub





    Private Sub BtnSaveInventory_Click(sender As Object, e As EventArgs) Handles BtnSaveInventory.Click
        ' Get input values
        Dim dateValue As String = If(String.IsNullOrWhiteSpace(TextBox1.Text), DateTime.Now.ToString("yyyy-MM-dd"), TextBox1.Text)
        Dim timeValue As String = If(String.IsNullOrWhiteSpace(TextBox2.Text), DateTime.Now.ToString("HH:mm:ss"), TextBox2.Text)
        Dim itemValue As String = TextBox3.Text
        Dim quantityValue As String = TextBox4.Text ' Optional
        Dim pricePerQuantityValue As String = TextBox5.Text ' Optional
        Dim totalValue As String = TextBox6.Text
        Dim remarksValue As String = RichTextBox2.Text ' Optional

        ' Validate mandatory fields
        If String.IsNullOrWhiteSpace(itemValue) Then
            MessageBox.Show("The Item field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(totalValue) Then
            MessageBox.Show("The Total field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' File path for the Excel file
        Dim filePath As String = "C:\The Big Shot Assistant\Database\Inventory.xlsx"

        ' Check if the directory exists
        Dim directoryPath As String = Path.GetDirectoryName(filePath)
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath) ' Create the directory if it doesn't exist
        End If

        ' Check if the file already exists
        Dim fileExists As Boolean = File.Exists(filePath)

        ' Create or update the Excel file
        Using package As New ExcelPackage(New FileInfo(filePath))
            Dim worksheet As ExcelWorksheet

            If fileExists Then
                ' Load the existing worksheet
                worksheet = package.Workbook.Worksheets.FirstOrDefault()
            Else
                ' Create a new worksheet
                worksheet = package.Workbook.Worksheets.Add("Inventory")
                ' Add headers to the worksheet
                worksheet.Cells(1, 1).Value = "Date"
                worksheet.Cells(1, 2).Value = "Time"
                worksheet.Cells(1, 3).Value = "Item"
                worksheet.Cells(1, 4).Value = "Quantity"
                worksheet.Cells(1, 5).Value = "Price per Quantity"
                worksheet.Cells(1, 6).Value = "Total"
                worksheet.Cells(1, 7).Value = "Remarks"
            End If

            Dim nextRow As Integer
            If worksheet.Dimension Is Nothing Then
                nextRow = 2 ' Start from the second row if the sheet is empty (row 1 is for headers)
            Else
                nextRow = worksheet.Dimension.End.Row + 1
            End If


            ' Add data to the worksheet
            worksheet.Cells(nextRow, 1).Value = dateValue
            worksheet.Cells(nextRow, 2).Value = timeValue
            worksheet.Cells(nextRow, 3).Value = itemValue
            worksheet.Cells(nextRow, 4).Value = If(String.IsNullOrWhiteSpace(quantityValue), "N/A", quantityValue)
            worksheet.Cells(nextRow, 5).Value = If(String.IsNullOrWhiteSpace(pricePerQuantityValue), "N/A", pricePerQuantityValue)
            worksheet.Cells(nextRow, 6).Value = totalValue
            worksheet.Cells(nextRow, 7).Value = If(String.IsNullOrWhiteSpace(remarksValue), "N/A", remarksValue)

            ' Save the Excel file
            package.Save()
        End Using

        ' Show success message
        MessageBox.Show("Data saved successfully to Inventory.xlsx!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear the input fields for the next entry
        ClearInputs()
    End Sub

    ' Clear input fields
    Private Sub ClearInputs()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        RichTextBox2.Clear()
    End Sub



    Private Sub SetInventoryDateTimeTextbox()
        ' Set current date in TextBox1
        TextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd") ' Format: 2025-01-28

        ' Set current time in TextBox2
        TextBox2.Text = DateTime.Now.ToString("HH:mm:ss") ' Format: 14:30:45

    End Sub



End Class



