Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Disable automatic row addition
        DataGridView1.AllowUserToAddRows = False

        ' Call the method to add columns to DataGridView
        AddColumnsToDataGridView()

        ' Add the first row manually
        AddFirstRow()
    End Sub

    Private Sub AddFirstRow()
        ' Add the first row with the serial number
        Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add())

        ' Set the serial number for the first row
        newRow.Cells("SerialNumber").Value = 1

        ' Set other default values for the first row
        newRow.Cells("Name").Value = ""  ' Default Name
        newRow.Cells("Date").Value = ""  ' Default Date (empty or dynamically set)
        newRow.Cells("GameType").Value = ""  ' Default Game Type
        newRow.Cells("TableNumber").Value = ""  ' Default Table Number
        newRow.Cells("StartTime").Value = ""  ' Default Start Time
        newRow.Cells("EndTime").Value = ""  ' Default End Time
        newRow.Cells("FrameNumber").Value = ""  ' Default Frame Number
        newRow.Cells("Payment").Value = ""  ' Default Payment type
        newRow.Cells("Amount").Value = ""  ' Default Amount
        newRow.Cells("PaymentStatus").Value = ""  ' Default Payment Status
        newRow.Cells("Member").Value = ""  ' Default Member Status
    End Sub
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

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

    Private Sub BtnAddRow_Click(sender As Object, e As EventArgs) Handles BtnAddRow.Click
        ' Create a new row
        Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add())

        ' Set the serial number for the new row
        newRow.Cells("SerialNumber").Value = currentSerialNumber

        ' Increment the serial number for the next row
        currentSerialNumber += 1

        ' You can set default values for other columns here if necessary
        newRow.Cells("Name").Value = ""  ' Default Name
        newRow.Cells("Date").Value = ""  ' Default Date (empty or you can set it dynamically)
        newRow.Cells("GameType").Value = ""  ' Default Game Type
        newRow.Cells("TableNumber").Value = ""  ' Default Table Number
        newRow.Cells("StartTime").Value = ""  ' Default Start Time
        newRow.Cells("EndTime").Value = ""  ' Default End Time
        newRow.Cells("FrameNumber").Value = ""  ' Default Frame Number
        newRow.Cells("Payment").Value = ""  ' Default Payment type
        newRow.Cells("Amount").Value = ""  ' Default Amount
        newRow.Cells("PaymentStatus").Value = ""  ' Default Payment Status
        newRow.Cells("Member").Value = ""  ' Default Member Status
    End Sub


    Private Sub AddColumnsToDataGridView()
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
        frameNumberColumn.Items.AddRange("1", "2", "3", "4", "5")
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
        amountColumn.HeaderText = "Amount"
        DataGridView1.Columns.Add(amountColumn)

        ' Add Payment Status column
        Dim paymentStatusColumn As New DataGridViewComboBoxColumn()
        paymentStatusColumn.Name = "PaymentStatus"
        paymentStatusColumn.HeaderText = "Payment Status"
        paymentStatusColumn.Items.AddRange("Paid", "Pending")
        DataGridView1.Columns.Add(paymentStatusColumn)
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
            If Not row.IsNewRow AndAlso Not IsRowStruckOut(row) AndAlso Not IsDBNull(row.Cells("Amount").Value) AndAlso IsNumeric(row.Cells("Amount").Value) Then
                totalRevenue += Convert.ToDecimal(row.Cells("Amount").Value)
            End If
        Next

        ' Update the label with the total revenue in INR format
        TotalRevenueLabel1.Text = "Total Revenue: ₹" & totalRevenue.ToString("N2") ' INR symbol with 2 decimal places
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


    Private Sub BtnEndTime_Click_1(sender As Object, e As EventArgs) Handles BtnEndTime.Click

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ' Prompt the user with a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Do you want to export the entries before closing?", "Exit Application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        ' Handle the user's response
        Select Case result
            Case DialogResult.Yes
                ' If the user chooses Yes, call the function to export the entries
                ' ExportEntries()
                ' Close the application after exporting
                Me.Close()

            Case DialogResult.No
                ' If the user chooses No, just close the application without exporting
                Me.Close()

            Case DialogResult.Cancel
                ' If the user chooses Cancel, do nothing and return to the application
                Return

        End Select
    End Sub




End Class
