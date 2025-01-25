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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 20)
        Label1.TabIndex = 0
        Label1.Text = "Membership ID"
        ' 
        ' TxtMemberId
        ' 
        TxtMemberId.Location = New Point(259, 51)
        TxtMemberId.Name = "TxtMemberId"
        TxtMemberId.Size = New Size(222, 27)
        TxtMemberId.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(78, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 3
        Label3.Text = "Game Type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(70, 332)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 4
        Label4.Text = "Start Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(85, 414)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 5
        Label5.Text = "End Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(79, 521)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 6
        Label6.Text = "Status"
        ' 
        ' CmbGameType
        ' 
        CmbGameType.DropDownStyle = ComboBoxStyle.DropDownList
        CmbGameType.FormattingEnabled = True
        CmbGameType.Items.AddRange(New Object() {"Pool", "Snooker"})
        CmbGameType.Location = New Point(262, 203)
        CmbGameType.Name = "CmbGameType"
        CmbGameType.Size = New Size(197, 28)
        CmbGameType.TabIndex = 8
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(257, 131)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(238, 27)
        TxtName.TabIndex = 9
        ' 
        ' DtpStartDate
        ' 
        DtpStartDate.Location = New Point(293, 332)
        DtpStartDate.Name = "DtpStartDate"
        DtpStartDate.Size = New Size(238, 27)
        DtpStartDate.TabIndex = 10
        ' 
        ' DtpEndDate
        ' 
        DtpEndDate.Location = New Point(285, 411)
        DtpEndDate.Name = "DtpEndDate"
        DtpEndDate.Size = New Size(307, 27)
        DtpEndDate.TabIndex = 11
        ' 
        ' CmbStatus
        ' 
        CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CmbStatus.FormattingEnabled = True
        CmbStatus.Items.AddRange(New Object() {"Active", "Expired"})
        CmbStatus.Location = New Point(282, 513)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(358, 28)
        CmbStatus.TabIndex = 12
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(258, 548)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(317, 52)
        BtnSave.TabIndex = 13
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(70, 265)
        Label7.Name = "Label7"
        Label7.Size = New Size(154, 20)
        Label7.TabIndex = 14
        Label7.Text = "Membership Duration"
        ' 
        ' TxtMembershipDuration
        ' 
        TxtMembershipDuration.Location = New Point(282, 268)
        TxtMembershipDuration.Name = "TxtMembershipDuration"
        TxtMembershipDuration.ReadOnly = True
        TxtMembershipDuration.Size = New Size(240, 27)
        TxtMembershipDuration.TabIndex = 15
        TxtMembershipDuration.Text = "Monthly"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(74, 460)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 20)
        Label8.TabIndex = 16
        Label8.Text = "Amount Paid"
        ' 
        ' CmbAmtPaid
        ' 
        CmbAmtPaid.DropDownStyle = ComboBoxStyle.DropDownList
        CmbAmtPaid.FormattingEnabled = True
        CmbAmtPaid.Items.AddRange(New Object() {"6,000", "10,000"})
        CmbAmtPaid.Location = New Point(266, 466)
        CmbAmtPaid.Name = "CmbAmtPaid"
        CmbAmtPaid.Size = New Size(382, 28)
        CmbAmtPaid.TabIndex = 17
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 645)
        Controls.Add(CmbAmtPaid)
        Controls.Add(Label8)
        Controls.Add(TxtMembershipDuration)
        Controls.Add(Label7)
        Controls.Add(BtnSave)
        Controls.Add(CmbStatus)
        Controls.Add(DtpEndDate)
        Controls.Add(DtpStartDate)
        Controls.Add(TxtName)
        Controls.Add(CmbGameType)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtMemberId)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
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
End Class
