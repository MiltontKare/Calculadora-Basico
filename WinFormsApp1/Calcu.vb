Public Class CALCU
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTRETR.Click
        Me.Hide()
        MENU.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OPCION.Items.Add("+")
        OPCION.Items.Add("-")
        OPCION.Items.Add("*")
        OPCION.Items.Add("/")


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTLIMP_Click(sender As Object, e As EventArgs) Handles BTLIMP.Click
        n1.Text = ""
        n2.Text = ""
        TXTRES.Text = ""
    End Sub

    Private Sub BTCALCULAR_Click(sender As Object, e As EventArgs) Handles BTCALCULAR.Click
        If (OPCION.SelectedItem = "+") Then
            TXTRES.Text = Val(n1.Text) + Val(n2.Text)
        ElseIf (OPCION.SelectedItem = "-") Then
            TXTRES.Text = Val(n1.Text) - Val(n2.Text)
        ElseIf (OPCION.SelectedItem = "*") Then
            TXTRES.Text = Val(n1.Text) * Val(n2.Text)
        ElseIf (OPCION.SelectedItem = "/") Then
            TXTRES.Text = Val(n1.Text) / Val(n2.Text)
        Else
            MessageBox.Show("SELECCIONE UNA OPERACIÓN")
        End If
    End Sub

    Private Sub OPCION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OPCION.SelectedIndexChanged

    End Sub
End Class
