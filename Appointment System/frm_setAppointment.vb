Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frm_setAppointment

    Private Sub frm_setAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        timePicker.Format = DateTimePickerFormat.Time
        timePicker.ShowUpDown = True

        AddHandler txt_name.TextChanged, AddressOf ValidateInputs
        AddHandler txt_email.TextChanged, AddressOf ValidateInputs
        AddHandler txt_contactNum.TextChanged, AddressOf ValidateInputs
        AddHandler cbo_agenda.TextChanged, AddressOf ValidateInputs
    End Sub

    Private Sub btn_setAppointment_Click(sender As Object, e As EventArgs) Handles btn_setAppointment.Click
        Try
            conn.Open()

            cmd = New MySqlCommand("INSERT INTO `tbl_appointments`(`name`, `contact`, `email`, `agenda`, `date`, `time`) VALUES (@name, @contact, @email, @agenda, @date, @time)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@contact", txt_contactNum.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@agenda", cbo_agenda.Text)
            cmd.Parameters.AddWithValue("@date", datePicker.Value.Date.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@time", timePicker.Value.ToString("H:mm:ss"))
            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Appointment Set", vbInformation)
            Else
                MsgBox("Appointment Failed", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
        cbo_agenda.Text = ""

    End Sub

    Private Sub txt_contactNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contactNum.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_email_Leave(sender As Object, e As EventArgs) Handles txt_email.Leave
        If Not Regex.Match(txt_email.Text, "^.*@.*\.com$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter a valid email address (e.g., user@example.com)")
            txt_email.Focus()
        End If
    End Sub

    Private Sub ValidateInputs(sender As Object, e As EventArgs)
        btn_setAppointment.Enabled = Not (txt_name.Text = String.Empty OrElse txt_email.Text = String.Empty OrElse txt_name.Text = String.Empty OrElse cbo_agenda.Text = String.Empty)
    End Sub

    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
        If datePicker.Value < Date.Today Then
            MessageBox.Show("Date cannot be before current date.")
        End If
    End Sub
End Class