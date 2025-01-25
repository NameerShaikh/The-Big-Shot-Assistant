<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        TxtMemberId = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CmbGameType = New ComboBox()
        TxtName = New TextBox()
        DtpStartDate = New DateTimePicker()
        DtpEndDate = New DateTimePicker()
        CmbStatus = New ComboBox()
        BtnSave = New Button()
        Label7 = New Label()
        TxtMembershipDuration = New TextBox()
        Label8 = New Label()
        CmbAmtPaid = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.Location = New Point(53, 20)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 0
        Label1.Text = "Membership ID"
        ' 
        ' TxtMemberId
        ' 
        TxtMemberId.Anchor = AnchorStyles.Left
        TxtMemberId.Font = New Font("Segoe UI", 13.8F)
        TxtMemberId.Location = New Point(272, 13)
        TxtMemberId.Margin = New Padding(5)
        TxtMemberId.Name = "TxtMemberId"
        TxtMemberId.ReadOnly = True
        TxtMemberId.Size = New Size(344, 38)
        TxtMemberId.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.Location = New Point(53, 85)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 25)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.Location = New Point(53, 150)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 3
        Label3.Text = "Game Type"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.Location = New Point(53, 280)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 4
        Label4.Text = "Start Date"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.Location = New Point(53, 345)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 25)
        Label5.TabIndex = 5
        Label5.Text = "End Date"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F)
        Label6.Location = New Point(53, 478)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 25)
        Label6.TabIndex = 6
        Label6.Text = "Status"
        ' 
        ' CmbGameType
        ' 
        CmbGameType.Anchor = AnchorStyles.Left
        CmbGameType.DropDownStyle = ComboBoxStyle.DropDownList
        CmbGameType.Font = New Font("Segoe UI", 13.8F)
        CmbGameType.FormattingEnabled = True
        CmbGameType.Items.AddRange(New Object() {"Pool", "Snooker"})
        CmbGameType.Location = New Point(272, 143)
        CmbGameType.Margin = New Padding(5)
        CmbGameType.Name = "CmbGameType"
        CmbGameType.Size = New Size(344, 39)
        CmbGameType.TabIndex = 8
        ' 
        ' TxtName
        ' 
        TxtName.Anchor = AnchorStyles.Left
        TxtName.Font = New Font("Segoe UI", 13.8F)
        TxtName.Location = New Point(272, 78)
        TxtName.Margin = New Padding(5)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(344, 38)
        TxtName.TabIndex = 9
        ' 
        ' DtpStartDate
        ' 
        DtpStartDate.Anchor = AnchorStyles.Left
        DtpStartDate.Font = New Font("Segoe UI", 13.8F)
        DtpStartDate.Location = New Point(272, 273)
        DtpStartDate.Margin = New Padding(5)
        DtpStartDate.Name = "DtpStartDate"
        DtpStartDate.Size = New Size(344, 38)
        DtpStartDate.TabIndex = 10
        ' 
        ' DtpEndDate
        ' 
        DtpEndDate.Anchor = AnchorStyles.Left
        DtpEndDate.Font = New Font("Segoe UI", 13.8F)
        DtpEndDate.Location = New Point(272, 338)
        DtpEndDate.Margin = New Padding(5)
        DtpEndDate.Name = "DtpEndDate"
        DtpEndDate.Size = New Size(344, 38)
        DtpEndDate.TabIndex = 11
        ' 
        ' CmbStatus
        ' 
        CmbStatus.Anchor = AnchorStyles.Left
        CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CmbStatus.Font = New Font("Segoe UI", 13.8F)
        CmbStatus.FormattingEnabled = True
        CmbStatus.Items.AddRange(New Object() {"Active", "Expired"})
        CmbStatus.Location = New Point(272, 471)
        CmbStatus.Margin = New Padding(5)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(344, 39)
        CmbStatus.TabIndex = 12
        ' 
        ' BtnSave
        ' 
        BtnSave.Anchor = AnchorStyles.None
        BtnSave.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSave.Location = New Point(186, 558)
        BtnSave.Margin = New Padding(5)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(236, 53)
        BtnSave.TabIndex = 13
        BtnSave.Text = "Save Member"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.Location = New Point(53, 215)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(198, 25)
        Label7.TabIndex = 14
        Label7.Text = "Membership Duration"
        ' 
        ' TxtMembershipDuration
        ' 
        TxtMembershipDuration.Anchor = AnchorStyles.Left
        TxtMembershipDuration.Font = New Font("Segoe UI", 13.8F)
        TxtMembershipDuration.Location = New Point(272, 208)
        TxtMembershipDuration.Margin = New Padding(5)
        TxtMembershipDuration.Name = "TxtMembershipDuration"
        TxtMembershipDuration.ReadOnly = True
        TxtMembershipDuration.Size = New Size(344, 38)
        TxtMembershipDuration.TabIndex = 15
        TxtMembershipDuration.Text = "Monthly"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.Location = New Point(53, 410)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 25)
        Label8.TabIndex = 16
        Label8.Text = "Amount Paid"
        ' 
        ' CmbAmtPaid
        ' 
        CmbAmtPaid.Anchor = AnchorStyles.Left
        CmbAmtPaid.DropDownStyle = ComboBoxStyle.DropDownList
        CmbAmtPaid.Font = New Font("Segoe UI", 13.8F)
        CmbAmtPaid.FormattingEnabled = True
        CmbAmtPaid.Items.AddRange(New Object() {"6,000", "10,000"})
        CmbAmtPaid.Location = New Point(272, 403)
        CmbAmtPaid.Margin = New Padding(5)
        CmbAmtPaid.Name = "CmbAmtPaid"
        CmbAmtPaid.Size = New Size(344, 39)
        CmbAmtPaid.TabIndex = 17
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.9775276F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.02247F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 353F))
        TableLayoutPanel1.Controls.Add(Label16, 0, 7)
        TableLayoutPanel1.Controls.Add(Label10, 0, 6)
        TableLayoutPanel1.Controls.Add(Label11, 0, 5)
        TableLayoutPanel1.Controls.Add(Label12, 0, 4)
        TableLayoutPanel1.Controls.Add(Label13, 0, 3)
        TableLayoutPanel1.Controls.Add(Label14, 0, 2)
        TableLayoutPanel1.Controls.Add(Label15, 0, 1)
        TableLayoutPanel1.Controls.Add(TxtMemberId, 2, 0)
        TableLayoutPanel1.Controls.Add(TxtName, 2, 1)
        TableLayoutPanel1.Controls.Add(CmbGameType, 2, 2)
        TableLayoutPanel1.Controls.Add(TxtMembershipDuration, 2, 3)
        TableLayoutPanel1.Controls.Add(DtpStartDate, 2, 4)
        TableLayoutPanel1.Controls.Add(DtpEndDate, 2, 5)
        TableLayoutPanel1.Controls.Add(CmbAmtPaid, 2, 6)
        TableLayoutPanel1.Controls.Add(CmbStatus, 2, 7)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 1)
        TableLayoutPanel1.Controls.Add(Label3, 1, 2)
        TableLayoutPanel1.Controls.Add(Label7, 1, 3)
        TableLayoutPanel1.Controls.Add(Label4, 1, 4)
        TableLayoutPanel1.Controls.Add(Label5, 1, 5)
        TableLayoutPanel1.Controls.Add(Label8, 1, 6)
        TableLayoutPanel1.Controls.Add(Label6, 1, 7)
        TableLayoutPanel1.Controls.Add(Label9, 0, 0)
        TableLayoutPanel1.Font = New Font("Microsoft Sans Serif", 12F)
        TableLayoutPanel1.Location = New Point(32, 24)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(621, 526)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(6, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 29)
        Label9.TabIndex = 18
        Label9.Text = "1]"
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(6, 408)
        Label10.Name = "Label10"
        Label10.Size = New Size(35, 29)
        Label10.TabIndex = 19
        Label10.Text = "7]"
        Label10.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(6, 343)
        Label11.Name = "Label11"
        Label11.Size = New Size(35, 29)
        Label11.TabIndex = 20
        Label11.Text = "6]"
        Label11.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(6, 278)
        Label12.Name = "Label12"
        Label12.Size = New Size(35, 29)
        Label12.TabIndex = 21
        Label12.Text = "5]"
        Label12.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(6, 213)
        Label13.Name = "Label13"
        Label13.Size = New Size(35, 29)
        Label13.TabIndex = 22
        Label13.Text = "4]"
        Label13.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(6, 148)
        Label14.Name = "Label14"
        Label14.Size = New Size(35, 29)
        Label14.TabIndex = 23
        Label14.Text = "3]"
        Label14.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.None
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(6, 83)
        Label15.Name = "Label15"
        Label15.Size = New Size(35, 29)
        Label15.TabIndex = 24
        Label15.Text = "2]"
        Label15.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.None
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(6, 476)
        Label16.Name = "Label16"
        Label16.Size = New Size(35, 29)
        Label16.TabIndex = 25
        Label16.Text = "8]"
        Label16.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 625)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(BtnSave)
        Font = New Font("Segoe UI", 13.8F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Member Details"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMemberId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbGameType As ComboBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents DtpStartDate As DateTimePicker
    Friend WithEvents DtpEndDate As DateTimePicker
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMembershipDuration As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbAmtPaid As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
