Imports System.Reflection.Emit

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Method to display the member details in the respective labels
    End Sub

    Public Sub DisplayMemberDetails(memberDetails As List(Of String))
        If memberDetails IsNot Nothing AndAlso memberDetails.Count >= 8 Then
            TxtMembershipID.Text = memberDetails(0)
            TxtName.Text = memberDetails(1)
            TxtGameType.Text = memberDetails(2)
            TxtStatus.Text = memberDetails(3)
            TxtStartDate.Text = memberDetails(4)
            TxtEndDate.Text = memberDetails(5)
            TxtAmtPaid.Text = memberDetails(7)
        Else
            MessageBox.Show("Member details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class