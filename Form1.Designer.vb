<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GB_All_rem_Stor = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GB_CD_Old = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.GB_Cd_Drv = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Usb_wr = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GB_Usb_Old = New System.Windows.Forms.GroupBox()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.GB_Usb_Drv = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GB_All_rem_Stor.SuspendLayout()
        Me.GB_CD_Old.SuspendLayout()
        Me.GB_Cd_Drv.SuspendLayout()
        Me.GB_Usb_wr.SuspendLayout()
        Me.GB_Usb_Old.SuspendLayout()
        Me.GB_Usb_Drv.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(14, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(412, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Выполнить"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(14, 326)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(412, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Выход"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GB_All_rem_Stor
        '
        Me.GB_All_rem_Stor.Controls.Add(Me.RadioButton3)
        Me.GB_All_rem_Stor.Controls.Add(Me.RadioButton4)
        Me.GB_All_rem_Stor.Location = New System.Drawing.Point(164, 100)
        Me.GB_All_rem_Stor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_All_rem_Stor.Name = "GB_All_rem_Stor"
        Me.GB_All_rem_Stor.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_All_rem_Stor.Size = New System.Drawing.Size(140, 92)
        Me.GB_All_rem_Stor.TabIndex = 3
        Me.GB_All_rem_Stor.TabStop = False
        Me.GB_All_rem_Stor.Text = "All Rem Stor GP"
        Me.ToolTip1.SetToolTip(Me.GB_All_rem_Stor, "Отключение / включение всех съемных носителей (через GP)")
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(12, 55)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(84, 24)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.Text = "Enable"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(12, 23)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(87, 24)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Disable"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GB_CD_Old
        '
        Me.GB_CD_Old.Controls.Add(Me.RadioButton7)
        Me.GB_CD_Old.Controls.Add(Me.RadioButton8)
        Me.GB_CD_Old.Location = New System.Drawing.Point(310, 217)
        Me.GB_CD_Old.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_CD_Old.Name = "GB_CD_Old"
        Me.GB_CD_Old.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_CD_Old.Size = New System.Drawing.Size(128, 92)
        Me.GB_CD_Old.TabIndex = 5
        Me.GB_CD_Old.TabStop = False
        Me.GB_CD_Old.Text = "Old CD"
        Me.ToolTip1.SetToolTip(Me.GB_CD_Old, "Отключение / включение уже установленных cdrom")
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(12, 55)
        Me.RadioButton7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(84, 24)
        Me.RadioButton7.TabIndex = 1
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Enable"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Checked = True
        Me.RadioButton8.Location = New System.Drawing.Point(12, 23)
        Me.RadioButton8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(87, 24)
        Me.RadioButton8.TabIndex = 0
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Disable"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'GB_Cd_Drv
        '
        Me.GB_Cd_Drv.Controls.Add(Me.RadioButton9)
        Me.GB_Cd_Drv.Controls.Add(Me.RadioButton10)
        Me.GB_Cd_Drv.Location = New System.Drawing.Point(174, 217)
        Me.GB_Cd_Drv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Cd_Drv.Name = "GB_Cd_Drv"
        Me.GB_Cd_Drv.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Cd_Drv.Size = New System.Drawing.Size(128, 92)
        Me.GB_Cd_Drv.TabIndex = 4
        Me.GB_Cd_Drv.TabStop = False
        Me.GB_Cd_Drv.Text = "CD Drivers"
        Me.ToolTip1.SetToolTip(Me.GB_Cd_Drv, "Отключение / включение драйверов cdrom")
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(12, 55)
        Me.RadioButton9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(84, 24)
        Me.RadioButton9.TabIndex = 1
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Enable"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Checked = True
        Me.RadioButton10.Location = New System.Drawing.Point(12, 23)
        Me.RadioButton10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(87, 24)
        Me.RadioButton10.TabIndex = 0
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Disable"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'GB_Usb_wr
        '
        Me.GB_Usb_wr.BackColor = System.Drawing.SystemColors.Control
        Me.GB_Usb_wr.Controls.Add(Me.RadioButton5)
        Me.GB_Usb_wr.Controls.Add(Me.RadioButton6)
        Me.GB_Usb_wr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_Usb_wr.Location = New System.Drawing.Point(310, 100)
        Me.GB_Usb_wr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Usb_wr.Name = "GB_Usb_wr"
        Me.GB_Usb_wr.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Usb_wr.Size = New System.Drawing.Size(128, 92)
        Me.GB_Usb_wr.TabIndex = 3
        Me.GB_Usb_wr.TabStop = False
        Me.GB_Usb_wr.Text = "USB Write"
        Me.ToolTip1.SetToolTip(Me.GB_Usb_wr, "Отключение / включение доступа на запись")
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(12, 55)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(85, 24)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Enable"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(12, 23)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(91, 24)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Disable"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'GB_Usb_Old
        '
        Me.GB_Usb_Old.BackColor = System.Drawing.SystemColors.Control
        Me.GB_Usb_Old.Controls.Add(Me.RadioButton13)
        Me.GB_Usb_Old.Controls.Add(Me.RadioButton14)
        Me.GB_Usb_Old.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_Usb_Old.Location = New System.Drawing.Point(14, 120)
        Me.GB_Usb_Old.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Usb_Old.Name = "GB_Usb_Old"
        Me.GB_Usb_Old.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Usb_Old.Size = New System.Drawing.Size(112, 92)
        Me.GB_Usb_Old.TabIndex = 11
        Me.GB_Usb_Old.TabStop = False
        Me.GB_Usb_Old.Text = "Old"
        Me.ToolTip1.SetToolTip(Me.GB_Usb_Old, "Отключение / включение драйверов usbstor")
        Me.GB_Usb_Old.Visible = False
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(12, 55)
        Me.RadioButton13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(85, 24)
        Me.RadioButton13.TabIndex = 1
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "Enable"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Checked = True
        Me.RadioButton14.Location = New System.Drawing.Point(12, 23)
        Me.RadioButton14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(91, 24)
        Me.RadioButton14.TabIndex = 0
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "Disable"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'GB_Usb_Drv
        '
        Me.GB_Usb_Drv.BackColor = System.Drawing.SystemColors.Control
        Me.GB_Usb_Drv.Controls.Add(Me.RadioButton2)
        Me.GB_Usb_Drv.Controls.Add(Me.RadioButton12)
        Me.GB_Usb_Drv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GB_Usb_Drv.Location = New System.Drawing.Point(14, 22)
        Me.GB_Usb_Drv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Usb_Drv.Name = "GB_Usb_Drv"
        Me.GB_Usb_Drv.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GB_Usb_Drv.Size = New System.Drawing.Size(112, 92)
        Me.GB_Usb_Drv.TabIndex = 12
        Me.GB_Usb_Drv.TabStop = False
        Me.GB_Usb_Drv.Text = "New + Old"
        Me.ToolTip1.SetToolTip(Me.GB_Usb_Drv, "Отключение / включение драйверов usbstor")
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 55)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(85, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Enable"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Checked = True
        Me.RadioButton12.Location = New System.Drawing.Point(12, 23)
        Me.RadioButton12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(91, 24)
        Me.RadioButton12.TabIndex = 0
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Disable"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(7, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "+"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GB_Usb_Old)
        Me.GroupBox1.Controls.Add(Me.GB_Usb_Drv)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 120)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USB Drivers"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(456, 389)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_Usb_wr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GB_CD_Old)
        Me.Controls.Add(Me.GB_Cd_Drv)
        Me.Controls.Add(Me.GB_All_rem_Stor)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "USB / CD - Disable / enable"
        Me.GB_All_rem_Stor.ResumeLayout(False)
        Me.GB_All_rem_Stor.PerformLayout()
        Me.GB_CD_Old.ResumeLayout(False)
        Me.GB_CD_Old.PerformLayout()
        Me.GB_Cd_Drv.ResumeLayout(False)
        Me.GB_Cd_Drv.PerformLayout()
        Me.GB_Usb_wr.ResumeLayout(False)
        Me.GB_Usb_wr.PerformLayout()
        Me.GB_Usb_Old.ResumeLayout(False)
        Me.GB_Usb_Old.PerformLayout()
        Me.GB_Usb_Drv.ResumeLayout(False)
        Me.GB_Usb_Drv.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GB_All_rem_Stor As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GB_CD_Old As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents GB_Cd_Drv As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GB_Usb_wr As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GB_Usb_Old As GroupBox
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents GB_Usb_Drv As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
