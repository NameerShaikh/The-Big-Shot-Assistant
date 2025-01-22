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
        CmbMembershipType = New ComboBox()
        TxtName = New TextBox()
        DtpStartDate = New DateTimePicker()
        DtpEndDate = New DateTimePicker()
        CmbStatus = New ComboBox()
        BtnSave = New Button()
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
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 3
        Label3.Text = "Type"
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
        Label6.Location = New Point(84, 483)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 6
        Label6.Text = "Status"
        ' 
        ' CmbMembershipType
        ' 
        CmbMembershipType.FormattingEnabled = True
        CmbMembershipType.Items.AddRange(New Object() {"Pool", "Snooker"})
        CmbMembershipType.Location = New Point(262, 203)
        CmbMembershipType.Name = "CmbMembershipType"
        CmbMembershipType.Size = New Size(197, 28)
        CmbMembershipType.TabIndex = 8
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
        CmbStatus.FormattingEnabled = True
        CmbStatus.Items.AddRange(New Object() {"Active", "Expired"})
        CmbStatus.Location = New Point(279, 471)
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
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 645)
        Controls.Add(BtnSave)
        Controls.Add(CmbStatus)
        Controls.Add(DtpEndDate)
        Controls.Add(DtpStartDate)
        Controls.Add(TxtName)
        Controls.Add(CmbMembershipType)
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
    Friend WithEvents CmbMembershipType As ComboBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents DtpStartDate As DateTimePicker
    Friend WithEvents DtpEndDate As DateTimePicker
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents BtnSave As Button
End Class
