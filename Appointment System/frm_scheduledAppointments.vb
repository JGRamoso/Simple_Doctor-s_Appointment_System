Imports MySql.Data.MySqlClient
Public Class frm_scheduledAppointments

    Dim j As New Integer
    Private Sub frm_scheduledAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_appointments()

        DataGridView1.Columns("Column5").DefaultCellStyle.Format = "yyyy/MM/dd"
    End Sub

    Sub load_appointments()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `id`, `name`, `contact`, `email`, `agenda`, `date`, `time` FROM `tbl_appointments`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(dr.Item("id"), dr.Item("name"), dr.Item("contact"), dr.Item("email"), dr.Item("agenda"), dr.Item("date"), dr.Item("time"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

            If MsgBox("Are you sure you want to Delete this Appointment?", vbExclamation + vbYesNo) = vbYes Then
                DataGridView1.Rows.Remove(selectedRow)

                Try
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM `tbl_appointments` WHERE `ID`=@ID", conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    Dim i As Integer = cmd.ExecuteNonQuery()

                    If i > 0 Then
                        MsgBox("Appointment Deleted", vbInformation)
                    Else
                        MsgBox("Appointment Deletion Failed", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd = New MySqlCommand("UPDATE `tbl_appointments` SET `time` = @time WHERE `ID`=@ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@time", DataGridView1.Rows(j).Cells(6).Value.ToString)
                cmd.Parameters.AddWithValue("@id", DataGridView1.Rows(j).Cells(0).Value.ToString)
                i = cmd.ExecuteNonQuery

            Next
            If i > 0 Then
                MsgBox("Appointment Updated", vbInformation)
            Else
                MsgBox("Appointment Update Failed", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class