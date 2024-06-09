<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_setAppointment
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_contactNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cbo_agenda = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_setAppointment = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.timePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "CONTACT #"
        '
        'txt_contactNum
        '
        Me.txt_contactNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contactNum.Location = New System.Drawing.Point(27, 108)
        Me.txt_contactNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_contactNum.Multiline = True
        Me.txt_contactNum.Name = "txt_contactNum"
        Me.txt_contactNum.Size = New System.Drawing.Size(288, 31)
        Me.txt_contactNum.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "EMAIL ADDRESS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "NAME"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(27, 172)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(288, 31)
        Me.txt_email.TabIndex = 19
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(27, 44)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(288, 31)
        Me.txt_name.TabIndex = 18
        '
        'cbo_agenda
        '
        Me.cbo_agenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_agenda.FormattingEnabled = True
        Me.cbo_agenda.Items.AddRange(New Object() {"Checkup", "Consultation"})
        Me.cbo_agenda.Location = New System.Drawing.Point(109, 228)
        Me.cbo_agenda.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_agenda.Name = "cbo_agenda"
        Me.cbo_agenda.Size = New System.Drawing.Size(92, 24)
        Me.cbo_agenda.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "AGENDA"
        '
        'datePicker
        '
        Me.datePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker.Location = New System.Drawing.Point(140, 269)
        Me.datePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.datePicker.Size = New System.Drawing.Size(175, 22)
        Me.datePicker.TabIndex = 28
        Me.datePicker.Value = New Date(2024, 6, 9, 19, 39, 18, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Date and Time"
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_clear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Location = New System.Drawing.Point(179, 330)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(136, 39)
        Me.btn_clear.TabIndex = 31
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_setAppointment
        '
        Me.btn_setAppointment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_setAppointment.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_setAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_setAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setAppointment.ForeColor = System.Drawing.Color.White
        Me.btn_setAppointment.Location = New System.Drawing.Point(26, 330)
        Me.btn_setAppointment.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_setAppointment.Name = "btn_setAppointment"
        Me.btn_setAppointment.Size = New System.Drawing.Size(136, 39)
        Me.btn_setAppointment.TabIndex = 30
        Me.btn_setAppointment.Text = "Set Appointment"
        Me.btn_setAppointment.UseVisualStyleBackColor = False
        '
        'timePicker
        '
        Me.timePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timePicker.Location = New System.Drawing.Point(194, 295)
        Me.timePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.timePicker.Size = New System.Drawing.Size(121, 26)
        Me.timePicker.TabIndex = 32
        Me.timePicker.Value = New Date(2024, 6, 9, 19, 39, 18, 0)
        '
        'frm_setAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 383)
        Me.Controls.Add(Me.timePicker)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_setAppointment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_agenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_contactNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_name)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_setAppointment"
        Me.Text = "frm_setAppointment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_contactNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents cbo_agenda As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_setAppointment As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents timePicker As System.Windows.Forms.DateTimePicker
End Class
