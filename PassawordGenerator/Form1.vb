Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim password
        password = ""

        If txtUser.Text <> "" And txtPassw1.Text <> "" And txtPassw2.Text <> "" And txtPassw3.Text <> "" And txtPassw4.Text <> "" And txtPassw5.Text <> "" And txtPassw6.Text <> "" Then

            password = txtPassw1.Text & txtPassw2.Text & txtPassw3.Text & txtPassw4.Text & txtPassw5.Text & txtPassw6.Text

            dgvPassword.Rows.Add(txtUser.Text, password)

            txtPassw1.Text = ""
            txtPassw2.Text = ""
            txtPassw3.Text = ""
            txtPassw4.Text = ""
            txtPassw5.Text = ""
            txtPassw6.Text = ""
            txtUser.Text = ""

        Else

            MsgBox("Fill the user name or generete the password!")

        End If



    End Sub
    Private Sub bntGenerete_Click(sender As Object, e As EventArgs) Handles bntGenerete.Click

        txtPassw1.Text = ""
        txtPassw2.Text = ""
        txtPassw3.Text = ""
        txtPassw4.Text = ""
        txtPassw5.Text = ""
        txtPassw6.Text = ""

        Dim character As String
        Dim i As Integer
        Dim f As Integer
        Dim password As String
        Dim typeOfPassword As Integer


        Const NumLetSym As String = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%&*+_-/"
        Const NumLet As String = "abcdefghijklmnopqrstuvwxyz0123456789"
        Const NumSym As String = "0123456789!@#$%&*+_-/"
        Const LetSym As String = "abcdefghijklmnopqrstuvwxyz!@#$%&*+_-/"
        Const Num As String = "0123456789"
        Const Lett As String = "abcdefghijklmnopqrstuvwxyz"

        f = 6
        password = ""
        typeOfPassword = 0

        If cbNumber.Checked And cbLetters.Checked And cbSpecial.Checked Then 'NumLettSym
            Do While f > 0
                Randomize()
                i = Int(Rnd() * Len(NumLetSym)) + 1
                character = Mid(NumLetSym, i, 1)
                password = password & character
                f -= 1
            Loop


            txtPassw1.Text &= password(0).ToString
            txtPassw2.Text &= password(1).ToString
            txtPassw3.Text &= password(2).ToString
            txtPassw4.Text &= password(3).ToString
            txtPassw5.Text &= password(4).ToString
            txtPassw6.Text &= password(5).ToString

        ElseIf cbNumber.Checked And cbLetters.Checked Then 'NumLett
            Do While f > 0
                Randomize()
                i = Int(Rnd() * Len(NumLet)) + 1
                character = Mid(NumLet, i, 1)
                password = password & character
                f -= 1
            Loop


            txtPassw1.Text &= password(0).ToString
            txtPassw2.Text &= password(1).ToString
            txtPassw3.Text &= password(2).ToString
            txtPassw4.Text &= password(3).ToString
            txtPassw5.Text &= password(4).ToString
            txtPassw6.Text &= password(5).ToString

        ElseIf cbNumber.Checked And cbSpecial.Checked Then 'NumSym
            Do While f > 0
                Randomize()
                i = Int(Rnd() * Len(NumSym)) + 1
                character = Mid(NumSym, i, 1)
                password = password & character
                f -= 1
            Loop


            txtPassw1.Text &= password(0).ToString
            txtPassw2.Text &= password(1).ToString
            txtPassw3.Text &= password(2).ToString
            txtPassw4.Text &= password(3).ToString
            txtPassw5.Text &= password(4).ToString
            txtPassw6.Text &= password(5).ToString

        ElseIf cbLetters.Checked = True And cbSpecial.Checked Then 'LetSym
            Do While f > 0
                Randomize()
                i = Int(Rnd() * Len(LetSym)) + 1
                character = Mid(LetSym, i, 1)
                password = password & character
                f -= 1
            Loop


            txtPassw1.Text &= password(0).ToString
            txtPassw2.Text &= password(1).ToString
            txtPassw3.Text &= password(2).ToString
            txtPassw4.Text &= password(3).ToString
            txtPassw5.Text &= password(4).ToString
            txtPassw6.Text &= password(5).ToString

        ElseIf cbNumber.Checked = True Then 'Num
            Do While f > 0
                Randomize()
                i = Int(Rnd() * Len(Num)) + 1
                character = Mid(Num, i, 1)
                password = password & character
                f -= 1
            Loop


            txtPassw1.Text &= password(0).ToString
            txtPassw2.Text &= password(1).ToString
            txtPassw3.Text &= password(2).ToString
            txtPassw4.Text &= password(3).ToString
            txtPassw5.Text &= password(4).ToString
            txtPassw6.Text &= password(5).ToString

        ElseIf cbLetters.Checked = True Then 'Lett
            Do While f > 0
                Randomize()
                i = Int(Rnd() * Len(Lett)) + 1
                character = Mid(Lett, i, 1)
                password = password & character
                f -= 1
            Loop


            txtPassw1.Text &= password(0).ToString
            txtPassw2.Text &= password(1).ToString
            txtPassw3.Text &= password(2).ToString
            txtPassw4.Text &= password(3).ToString
            txtPassw5.Text &= password(4).ToString
            txtPassw6.Text &= password(5).ToString

        ElseIf cbSpecial.Checked = True Then
            MsgBox("Chose one another opition number or letter.")

        ElseIf cbNumber.Checked = False And cbLetters.Checked = False And cbSpecial.Checked = False Then
            MsgBox("Select at least one format to generete the password")

        End If

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvPassword.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvPassword.SelectedRows
                dgvPassword.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        dgvPassword.Rows.Clear()
    End Sub

End Class
