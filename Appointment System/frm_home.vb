Public Class frm_home
    
    Private Sub btn_openSetAppoint_Click(sender As Object, e As EventArgs) Handles btn_openSetAppoint.Click
        frm_setAppointment.Show()
    End Sub

    Private Sub btn_viewAppointments_Click(sender As Object, e As EventArgs) Handles btn_viewAppointments.Click
        frm_scheduledAppointments.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()
    End Sub
End Class