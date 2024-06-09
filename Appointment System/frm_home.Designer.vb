<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_home
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
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_viewAppointments = New System.Windows.Forms.Button()
        Me.btn_openSetAppoint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_logout.BackColor = System.Drawing.Color.Red
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(190, 10)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(67, 32)
        Me.btn_logout.TabIndex = 5
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_viewAppointments
        '
        Me.btn_viewAppointments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_viewAppointments.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_viewAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_viewAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_viewAppointments.ForeColor = System.Drawing.Color.White
        Me.btn_viewAppointments.Location = New System.Drawing.Point(20, 140)
        Me.btn_viewAppointments.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_viewAppointments.Name = "btn_viewAppointments"
        Me.btn_viewAppointments.Size = New System.Drawing.Size(224, 71)
        Me.btn_viewAppointments.TabIndex = 4
        Me.btn_viewAppointments.Text = "View Appointments"
        Me.btn_viewAppointments.UseVisualStyleBackColor = False
        '
        'btn_openSetAppoint
        '
        Me.btn_openSetAppoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_openSetAppoint.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_openSetAppoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_openSetAppoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openSetAppoint.ForeColor = System.Drawing.Color.White
        Me.btn_openSetAppoint.Location = New System.Drawing.Point(20, 64)
        Me.btn_openSetAppoint.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_openSetAppoint.Name = "btn_openSetAppoint"
        Me.btn_openSetAppoint.Size = New System.Drawing.Size(224, 71)
        Me.btn_openSetAppoint.TabIndex = 3
        Me.btn_openSetAppoint.Text = "Set Appointment"
        Me.btn_openSetAppoint.UseVisualStyleBackColor = False
        '
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 232)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_viewAppointments)
        Me.Controls.Add(Me.btn_openSetAppoint)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_home"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_viewAppointments As System.Windows.Forms.Button
    Friend WithEvents btn_openSetAppoint As System.Windows.Forms.Button
End Class
