Imports MySql.Data.MySqlClient
Public Class frm_registerUser

    Private Sub frm_manageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Sub clear()
        txt_name.Clear()
        txt_password.Clear()
        txt_username.Clear()
        cbo_role.SelectedIndex = -1
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If txt_password.Text = String.Empty Or txt_conPass.Text = String.Empty Then
            MsgBox("Please Enter a Password", vbExclamation)
            conn.Close()
            Return
        ElseIf StrComp(txt_password.Text, txt_conPass.Text, CompareMethod.Binary) Then
            MsgBox("Password does not match", vbExclamation)
            conn.Close()
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO `tbl_user`(`name`, `username`, `password`, `role`) VALUES (@name, @username, @password, @role)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@name", txt_name.Text)
                cmd.Parameters.AddWithValue("@username", txt_username.Text)
                cmd.Parameters.AddWithValue("@password", txt_password.Text)
                cmd.Parameters.AddWithValue("@role", cbo_role.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("New User Registered", vbInformation)
                Else
                    MsgBox("Registration failed", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
        End If
    End Sub

    Private Sub txt_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_username.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class