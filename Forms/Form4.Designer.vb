<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        TxtMembershipID = New Label()
        TxtName = New Label()
        TxtGameType = New Label()
        TxtDuration = New Label()
        TxtStartDate = New Label()
        TxtEndDate = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TxtStatus = New Label()
        TxtAmtPaid = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label6 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtMembershipID
        ' 
        TxtMembershipID.Anchor = AnchorStyles.Left
        TxtMembershipID.AutoSize = True
        TxtMembershipID.Font = New Font("Segoe UI", 13.8F)
        TxtMembershipID.Location = New Point(291, 11)
        TxtMembershipID.Name = "TxtMembershipID"
        TxtMembershipID.Size = New Size(81, 31)
        TxtMembershipID.TabIndex = 0
        TxtMembershipID.Text = "Label1"
        ' 
        ' TxtName
        ' 
        TxtName.Anchor = AnchorStyles.Left
        TxtName.AutoSize = True
        TxtName.Font = New Font("Segoe UI", 13.8F)
        TxtName.Location = New Point(291, 65)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(81, 31)
        TxtName.TabIndex = 1
        TxtName.Text = "Label1"
        ' 
        ' TxtGameType
        ' 
        TxtGameType.Anchor = AnchorStyles.Left
        TxtGameType.AutoSize = True
        TxtGameType.Font = New Font("Segoe UI", 13.8F)
        TxtGameType.Location = New Point(291, 119)
        TxtGameType.Name = "TxtGameType"
        TxtGameType.Size = New Size(81, 31)
        TxtGameType.TabIndex = 2
        TxtGameType.Text = "Label2"
        ' 
        ' TxtDuration
        ' 
        TxtDuration.Anchor = AnchorStyles.Left
        TxtDuration.AutoSize = True
        TxtDuration.Font = New Font("Segoe UI", 13.8F)
        TxtDuration.Location = New Point(291, 173)
        TxtDuration.Name = "TxtDuration"
        TxtDuration.Size = New Size(99, 31)
        TxtDuration.TabIndex = 3
        TxtDuration.Text = "Monthly"
        ' 
        ' TxtStartDate
        ' 
        TxtStartDate.Anchor = AnchorStyles.Left
        TxtStartDate.AutoSize = True
        TxtStartDate.Font = New Font("Segoe UI", 13.8F)
        TxtStartDate.Location = New Point(291, 227)
        TxtStartDate.Name = "TxtStartDate"
        TxtStartDate.Size = New Size(81, 31)
        TxtStartDate.TabIndex = 4
        TxtStartDate.Text = "Label4"
        ' 
        ' TxtEndDate
        ' 
        TxtEndDate.Anchor = AnchorStyles.Left
        TxtEndDate.AutoSize = True
        TxtEndDate.Font = New Font("Segoe UI", 13.8F)
        TxtEndDate.Location = New Point(291, 281)
        TxtEndDate.Name = "TxtEndDate"
        TxtEndDate.Size = New Size(81, 31)
        TxtEndDate.TabIndex = 5
        TxtEndDate.Text = "Label5"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TxtStatus, 1, 7)
        TableLayoutPanel1.Controls.Add(TxtAmtPaid, 1, 6)
        TableLayoutPanel1.Controls.Add(TxtMembershipID, 1, 0)
        TableLayoutPanel1.Controls.Add(TxtEndDate, 1, 5)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(TxtStartDate, 1, 4)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(TxtDuration, 1, 3)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(TxtGameType, 1, 2)
        TableLayoutPanel1.Controls.Add(Label7, 0, 4)
        TableLayoutPanel1.Controls.Add(TxtName, 1, 1)
        TableLayoutPanel1.Controls.Add(Label8, 0, 5)
        TableLayoutPanel1.Controls.Add(Label9, 0, 6)
        TableLayoutPanel1.Controls.Add(Label10, 0, 7)
        TableLayoutPanel1.Controls.Add(Label6, 0, 3)
        TableLayoutPanel1.Font = New Font("Segoe UI", 12F)
        TableLayoutPanel1.Location = New Point(18, 12)
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
        TableLayoutPanel1.Size = New Size(577, 434)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' TxtStatus
        ' 
        TxtStatus.Anchor = AnchorStyles.Left
        TxtStatus.AutoSize = True
        TxtStatus.Font = New Font("Segoe UI", 13.8F)
        TxtStatus.Location = New Point(291, 390)
        TxtStatus.Name = "TxtStatus"
        TxtStatus.Size = New Size(93, 31)
        TxtStatus.TabIndex = 16
        TxtStatus.Text = "Label12"
        ' 
        ' TxtAmtPaid
        ' 
        TxtAmtPaid.Anchor = AnchorStyles.Left
        TxtAmtPaid.AutoSize = True
        TxtAmtPaid.Font = New Font("Segoe UI", 13.8F)
        TxtAmtPaid.Location = New Point(291, 335)
        TxtAmtPaid.Name = "TxtAmtPaid"
        TxtAmtPaid.Size = New Size(93, 31)
        TxtAmtPaid.TabIndex = 15
        TxtAmtPaid.Text = "Label11"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F)
        Label1.Location = New Point(3, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 31)
        Label1.TabIndex = 7
        Label1.Text = "1] Membership ID"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F)
        Label2.Location = New Point(3, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 31)
        Label2.TabIndex = 8
        Label2.Text = "2] Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F)
        Label3.Location = New Point(3, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 31)
        Label3.TabIndex = 9
        Label3.Text = "3] Game Type"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F)
        Label7.Location = New Point(3, 227)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 31)
        Label7.TabIndex = 11
        Label7.Text = "5] Start Date"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F)
        Label8.Location = New Point(3, 281)
        Label8.Name = "Label8"
        Label8.Size = New Size(132, 31)
        Label8.TabIndex = 12
        Label8.Text = "6] End Date"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F)
        Label9.Location = New Point(3, 335)
        Label9.Name = "Label9"
        Label9.Size = New Size(171, 31)
        Label9.TabIndex = 13
        Label9.Text = "7] Amount Paid"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F)
        Label10.Location = New Point(3, 390)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 31)
        Label10.TabIndex = 14
        Label10.Text = "8] Status"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.Font = New Font("Segoe UI", 13.8F)
        Label6.Location = New Point(3, 163)
        Label6.Name = "Label6"
        Label6.Size = New Size(266, 51)
        Label6.TabIndex = 10
        Label6.Text = "4] Membership Duration"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 470)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form4"
        Text = "Member Details"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TxtMembershipID As Label
    Friend WithEvents TxtName As Label
    Friend WithEvents TxtGameType As Label
    Friend WithEvents TxtDuration As Label
    Friend WithEvents TxtStartDate As Label
    Friend WithEvents TxtEndDate As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtStatus As Label
    Friend WithEvents TxtAmtPaid As Label
End Class
