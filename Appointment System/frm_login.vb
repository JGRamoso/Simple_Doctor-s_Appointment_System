Imports MySql.Data.MySqlClient
Public Class frm_login
    Shadows name As String
    Dim username As String
    Dim password As String
    Dim role As String
    Private Sub frm_login_load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT * FROM `tbl_user` WHERE `username`='" & txt_username.Text & "' AND `password`='" & txt_password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                name = dr.Item("name").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString
            Else
                found = False
                name = ""
                username = ""
                password = ""
                role = ""

            End If
            If found = True Then
                If StrComp(txt_username.Text, username, CompareMethod.Binary) Or StrComp(txt_password.Text, password, CompareMethod.Binary) Then
                    MsgBox("Wrong Username or Password", vbExclamation)
                    conn.Close()
                    Return
                Else
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        frm_home.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_setAppointment.Show()

                    End If
                End If
            ElseIf txt_username.Text = String.Empty Then
                MsgBox("Please Enter your username", vbExclamation)
                conn.Close()
                Return
            ElseIf txt_password.Text = String.Empty Then
                MsgBox("Please Enter your password", vbExclamation)
                conn.Close()
                Return
            Else
                MsgBox("Wrong Username or Password", vbExclamation)
            End If
            txt_password.Clear()
            txt_username.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class
