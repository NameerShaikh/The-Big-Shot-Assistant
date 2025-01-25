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
        TxtMembershipID = New Label()
        TxtName = New Label()
        TxtGameType = New Label()
        TxtStatus = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' TxtMembershipID
        ' 
        TxtMembershipID.AutoSize = True
        TxtMembershipID.Location = New Point(353, 50)
        TxtMembershipID.Name = "TxtMembershipID"
        TxtMembershipID.Size = New Size(53, 20)
        TxtMembershipID.TabIndex = 0
        TxtMembershipID.Text = "Label1"
        ' 
        ' TxtName
        ' 
        TxtName.AutoSize = True
        TxtName.Location = New Point(274, 126)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(53, 20)
        TxtName.TabIndex = 1
        TxtName.Text = "Label1"
        ' 
        ' TxtGameType
        ' 
        TxtGameType.AutoSize = True
        TxtGameType.Location = New Point(260, 204)
        TxtGameType.Name = "TxtGameType"
        TxtGameType.Size = New Size(53, 20)
        TxtGameType.TabIndex = 2
        TxtGameType.Text = "Label2"
        ' 
        ' TxtStatus
        ' 
        TxtStatus.AutoSize = True
        TxtStatus.Location = New Point(244, 288)
        TxtStatus.Name = "TxtStatus"
        TxtStatus.Size = New Size(53, 20)
        TxtStatus.TabIndex = 3
        TxtStatus.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(227, 350)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 4
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(167, 400)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 5
        Label5.Text = "Label5"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(999, 589)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TxtStatus)
        Controls.Add(TxtGameType)
        Controls.Add(TxtName)
        Controls.Add(TxtMembershipID)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtMembershipID As Label
    Friend WithEvents TxtName As Label
    Friend WithEvents TxtGameType As Label
    Friend WithEvents TxtStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
