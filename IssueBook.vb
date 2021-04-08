Public Class IssueBook

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub buttonBorrow_MouseEnter(sender As Object, e As EventArgs)
        Me.buttonBorrow.BackColor = Color.DodgerBlue
    End Sub

    Private Sub buttonBorrow_MouseLeave(sender As Object, e As EventArgs)
        Me.buttonBorrow.BackColor = Color.SlateGray
    End Sub

    Private Sub buttonReserve_MouseEnter(sender As Object, e As EventArgs)
        Me.buttonReserve.BackColor = Color.DodgerBlue
    End Sub

    Private Sub buttonReserve_MouseLeave(sender As Object, e As EventArgs)
        Me.buttonReserve.BackColor = Color.SlateGray
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class