'Imports Microsoft.VisualBasic.PowerPacks
'Imports System.Security.AccessControl
'Imports System.Drawing
'Imports System.IO
'Imports System.Management


Public Class Form1
    Enum State
        Enable = True   ' разблокировать (разблокировано)
        Disable = False ' заблокировать (заблокировано)
    End Enum



    'Public Dis1 As Boolean, Dis2 As Boolean, Dis3 As Boolean ' USB
    'Public Dis4 As Boolean, Dis5 As Boolean                  ' CD-Rom

    Public St_Usb_Drv, St_Usb_Old, St_Rem_Stor, St_Cd_Drv, St_Cd_Old, St_Usb_Wr As Boolean ' состояние блокироквки (true - разблокированы)
    Public Id_Usb_Drv, Id_Usb_Old, Id_Rem_Stor, Id_Cd_Drv, Id_Cd_Old, Id_Usb_Wr As Boolean ' действие на блокировку (true - разблокировать)

    Public id_change As Boolean = False

    Dim Cmnd As String()

    Dim sys As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Check()
        Dim Rez As Integer

        On Error Resume Next

        St_Usb_Drv = False : St_Rem_Stor = False : St_Cd_Drv = False
        St_Cd_Old = False : St_Usb_Wr = False : St_Usb_Old = False

        ' проверка драйверов USB
        sys = Environ$("systemroot")

        If Not My.Computer.FileSystem.FileExists(sys & "\inf\usbstor.inf") Or Not My.Computer.FileSystem.FileExists(sys & "\inf\Usbstor.pnf") Then
            If Not My.Computer.FileSystem.FileExists(sys & "\inf\usbstor.inf") And Not My.Computer.FileSystem.FileExists(sys & "\inf\Usbstor.pnf") Then
                GB_Usb_Drv.BackColor = Color.Red
            Else
                GB_Usb_Drv.BackColor = Color.Orange
            End If

        Else
            GB_Usb_Drv.BackColor = Color.GreenYellow
            St_Usb_Drv = State.Enable
        End If

        ' установленые USB
        'HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord)
        Rez = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 0)
        If Rez = 4 Then
            GB_Usb_Old.BackColor = Color.Red
        Else
            GB_Usb_Old.BackColor = Color.GreenYellow
            St_Usb_Old = State.Enable
        End If

        ' проверка драйверов CD-Rom
        If Not My.Computer.FileSystem.FileExists(sys & "\inf\cdrom.inf") Or Not My.Computer.FileSystem.FileExists(sys & "\inf\cdrom.pnf") Then
            If Not My.Computer.FileSystem.FileExists(sys & "\inf\cdrom.inf") And Not My.Computer.FileSystem.FileExists(sys & "\inf\cdrom.pnf") Then
                GB_Cd_Drv.BackColor = Color.Red
            Else

                GB_Cd_Drv.BackColor = Color.Orange
            End If
        Else
                GB_Cd_Drv.BackColor = Color.GreenYellow
            St_Cd_Drv = State.Enable
        End If
        ' USB устройства всех класов (gpedit.msc)
        ' Конфигурация компьютера
        Rez = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\RemovableStorageDevices", "Deny_All", 0)
        'HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Group Policy Objects\{2703EC39-4914-47BC-9918-1B27C3343AE4}Machine\Software\Policies\Microsoft\Windows\RemovableStorageDevices
        If Rez = 1 Then
            GB_All_rem_Stor.BackColor = Color.Red
        Else
            GB_All_rem_Stor.BackColor = Color.GreenYellow
            St_Rem_Stor = State.Enable
        End If
        ' Конфигурация пользователя
        Rez = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\RemovableStorageDevices", "Deny_All", 0)
        'HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Group Policy Objects\{2703EC39-4914-47BC-9918-1B27C3343AE4}User\Software\Policies\Microsoft\Windows\RemovableStorageDevices
        If Rez = 1 Or GB_All_rem_Stor.BackColor = Color.Red Then
            GB_All_rem_Stor.BackColor = Color.Red
            St_Rem_Stor = State.Disable
        Else
            GB_All_rem_Stor.BackColor = Color.GreenYellow
            St_Rem_Stor = State.Enable
        End If
        ' установленые CD-Rom
        Rez = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\cdrom", "Start", 0)
        If Rez = 4 Then
            GB_CD_Old.BackColor = Color.Red
        Else
            GB_CD_Old.BackColor = Color.GreenYellow
            St_Cd_Old = State.Enable
        End If
        ' запись
        Rez = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", "WriteProtect", 0)
        If Rez = 1 Then
            GB_Usb_wr.BackColor = Color.Red
        Else
            GB_Usb_wr.BackColor = Color.GreenYellow
            St_Usb_Wr = State.Enable
        End If

        If GB_Usb_Drv.BackColor = Color.GreenYellow Then
            RadioButton2.Checked = True
        End If
        If GB_Usb_Old.BackColor = Color.GreenYellow Then
            RadioButton13.Checked = True
        Else
            RadioButton14.Checked = True
        End If
        If GB_All_rem_Stor.BackColor = Color.GreenYellow Then
            RadioButton3.Checked = True
        End If
        If St_Usb_Drv <> St_Usb_Old And id_gr = False Then
            Gb_Click()
        End If
        If GB_Cd_Drv.BackColor = Color.GreenYellow Then
            RadioButton9.Checked = True
        End If
        If GB_CD_Old.BackColor = Color.GreenYellow Then
            RadioButton7.Checked = True
        End If
        If GB_Usb_wr.BackColor = Color.GreenYellow Then
            RadioButton5.Checked = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Environment.OSVersion.Version.Major > 6 Or (Environment.OSVersion.Version.Major = 6 And Environment.OSVersion.Version.Minor >= 1) Then

            Check()
            Cmnd = Environment.GetCommandLineArgs()

            'Label1.Text = Environment.OSVersion.ToString
            Label2.Text = My.Computer.Info.OSFullName
            'Label3.Text = My.Computer.Info.OSVersion
            'Label3.Text = Environment.OSVersion.Version.MajorRevision

            'Dim answer As String = ""

            '' add Imports System.Management and add a resource to System.Management
            'Dim osClass As New ManagementClass("Win32_OperatingSystem")
            'For Each queryObj As ManagementObject In osClass.GetInstances()
            '    answer = DirectCast(queryObj.GetPropertyValue("Version"), String)
            'Next

            ' изменения = состояние
            Id_Cd_Drv = St_Cd_Drv
            Id_Cd_Old = St_Cd_Old
            Id_Rem_Stor = St_Rem_Stor
            Id_Usb_Drv = St_Usb_Drv
            Id_Usb_Wr = St_Usb_Wr
            Id_Usb_Old = St_Usb_Old

            If Cmnd.Length > 1 Then
                id_change = False
                For i = 1 To Cmnd.Length - 1
                    Select Case LCase(Cmnd(i))
                        Case "dr", "/dr", "-dr"    ' отключение "Съемные устройства всех типов"
                            Id_Rem_Stor = State.Disable
                            id_change = True
                        Case "er", "/er", "-er"    ' включение "Съемные устройства всех типов"
                            Id_Rem_Stor = State.Enable
                            id_change = True
                        Case "du", "/du", "-du" ' отключение USB
                            Id_Usb_Drv = State.Disable
                            Id_Usb_Wr = State.Disable
                            Id_Usb_Old = State.Disable
                            id_change = True
                        Case "eu", "/eu", "-eu"    ' включение USB
                            Id_Usb_Drv = State.Enable
                            Id_Usb_Wr = State.Enable
                            Id_Usb_Old = State.Enable
                            id_change = True
                        Case "dc", "/dc", "-dc"    ' отключение CD/DVD
                            Id_Cd_Drv = State.Disable
                            Id_Cd_Old = State.Disable
                            id_change = True
                        Case "ec", "/ec", "-ec"    ' включение CD/DVD
                            Id_Cd_Drv = State.Enable
                            Id_Cd_Old = State.Enable
                            id_change = True
                        Case "dis", "/dis", "-dis"  ' отключение всего
                            Id_Cd_Drv = State.Disable
                            Id_Cd_Old = State.Disable
                            Id_Rem_Stor = State.Disable
                            Id_Usb_Drv = State.Disable
                            Id_Usb_Wr = State.Disable
                            Id_Usb_Old = State.Disable
                            id_change = True
                        Case "en", "/en", "-en"   ' включение всего
                            Id_Cd_Drv = State.Enable
                            Id_Cd_Old = State.Enable
                            Id_Rem_Stor = State.Enable
                            Id_Usb_Drv = State.Enable
                            Id_Usb_Wr = State.Enable
                            Id_Usb_Old = State.Enable
                            id_change = True
                    End Select
                Next
                If id_change Then
                    Obrab()
                    Me.Close()
                End If
            Else
                'Dis1 = RadioButton2.Checked
                'Dis2 = RadioButton3.Checked
                'Dis3 = RadioButton5.Checked
                'Dis4 = RadioButton9.Checked
                'Dis5 = RadioButton7.Checked
            End If
        Else
            MsgBox("Вы используете устаревшую версию ОС:" + Chr(13) + My.Computer.Info.OSFullName + Chr(13) + Chr(13) + "Данная версия ОС не поддерживается программой.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ошибка версии ОС")
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Id_Cd_Drv = RadioButton9.Checked
        Id_Cd_Old = RadioButton7.Checked
        Id_Rem_Stor = RadioButton3.Checked
        Id_Usb_Drv = RadioButton2.Checked
        Id_Usb_Wr = RadioButton5.Checked
        If Not id_gr Then
            Id_Usb_Old = RadioButton2.Checked
            '            RadioButton13.Checked = True
        Else
            Id_Usb_Old = RadioButton13.Checked
        End If
        Obrab()
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = 112 Then
            About.ShowDialog()
        End If
    End Sub

    Private Sub Button2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = 112 Then
            About.ShowDialog()
        End If
    End Sub

    Private Sub Obrab()
        Dim str1 As String = "", Rez As Integer
        Dim Kod As Integer

        On Error Resume Next

        ' Драйвера USB
        If Id_Usb_Drv <> St_Usb_Drv Then
            str1 = "Драйвера USB: '"

            If Id_Usb_Drv Then ' разблокировать
                ' убираем все имеющиеся разрешения
                remInheritAndLocAcc(sys & "\Inf\Usbstor.pnf.dis")
                remInheritAndLocAcc(sys & "\Inf\Usbstor.inf.dis")
                ' разрешаем полны доступ
                setFileAccess(sys & "\Inf\Usbstor.pnf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)
                setFileAccess(sys & "\Inf\Usbstor.inf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)

                My.Computer.FileSystem.RenameFile(sys & "\Inf\Usbstor.pnf.dis", "Usbstor.pnf")
                My.Computer.FileSystem.RenameFile(sys & "\Inf\Usbstor.inf.dis", "Usbstor.inf")

                ' включаем уже установленные USB (остановка службы "Съемные ЗУ")
                'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord)

                str1 = str1 & "разблокированы'" & Chr(13)
            Else    ' заблокировать
                ' убираем все имеющиеся разрешения
                remInheritAndLocAcc(sys & "\Inf\Usbstor.pnf")
                remInheritAndLocAcc(sys & "\Inf\Usbstor.inf")
                ' разрешаем полный доступ
                setFileAccess(sys & "\Inf\Usbstor.pnf", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)
                setFileAccess(sys & "\Inf\Usbstor.inf", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)

                My.Computer.FileSystem.RenameFile(sys & "\Inf\Usbstor.pnf", "Usbstor.pnf.dis")
                My.Computer.FileSystem.RenameFile(sys & "\Inf\Usbstor.inf", "Usbstor.inf.dis")

                ' запрещаем полный доступ
                remInheritAndLocAcc(sys & "\Inf\Usbstor.pnf.dis")
                remInheritAndLocAcc(sys & "\Inf\Usbstor.inf.dis")
                setFileAccess(sys & "\Inf\Usbstor.pnf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Deny)
                setFileAccess(sys & "\Inf\Usbstor.inf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Deny)

                ' выключаем уже установленные USB (запуск службы "Съемные ЗУ")
                'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord)

                str1 = str1 & "заблокированы'" & Chr(13)
            End If
        End If
        ' Ранее установленные USB
        If Id_Usb_Old <> St_Usb_Old Then
            str1 &= "Старые USB: '"

            If Id_Usb_Old Then ' разблокировать
                ' включаем уже установленные USB (остановка службы "Съемные ЗУ")
                Kod = 3

                str1 = str1 & "разблокированы'" & Chr(13)
            Else    ' заблокировать
                ' выключаем уже установленные USB (запуск службы "Съемные ЗУ")
                Kod = 4

                str1 = str1 & "заблокированы'" & Chr(13)
            End If
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", Kod, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        ' Съемные запоминающие устройства всех типов
        If Id_Rem_Stor <> St_Rem_Stor Then
            str1 = str1 & "Съемные запоминающие устройства: '"
            ' My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\RemovableStorageDevices", "Deny_All", 0)
            If Id_Rem_Stor Then ' разблокировать
                Kod = 0
                'My.Computer.Registry.LocalMachine.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\RemovableStorageDevices", True).DeleteValue("Deny_All")
                'My.Computer.Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\RemovableStorageDevices", True).DeleteValue("Deny_All")
                'myreg.DeleteValue("Deny_All")
                
                str1 = str1 & "разблокированы'" & Chr(13)
            Else    ' заблокировать
                Kod = 1
                'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\RemovableStorageDevices", "Deny_All", Kod, Microsoft.Win32.RegistryValueKind.DWord)
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\RemovableStorageDevices", "Deny_All", Kod, Microsoft.Win32.RegistryValueKind.DWord)
                str1 = str1 & "заблокированы'" & Chr(13)
            End If

            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\RemovableStorageDevices", "Deny_All", Kod, Microsoft.Win32.RegistryValueKind.DWord)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\RemovableStorageDevices", "Deny_All", Kod, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        ' Запрет записи
        If Id_Usb_Wr <> St_Usb_Wr Then
            str1 = str1 & "Запись USB: '"
            If Id_Usb_Wr Then
                Kod = 0
                str1 = str1 & "разблокирована'" & Chr(13)
            Else
                Kod = 1
                str1 = str1 & "заблокирована'" & Chr(13)
            End If
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\StorageDevicePolicies", "WriteProtect", Kod, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        ' Драйвера CD-Rom
        If Id_Cd_Drv <> St_Cd_Drv Then
            str1 = str1 & "Драйвера CD-Rom: '"
            If Id_Cd_Drv Then
                ' убираем все имеющиеся разрешения
                remInheritAndLocAcc(sys & "\Inf\cdrom.pnf.dis")
                remInheritAndLocAcc(sys & "\Inf\cdrom.inf.dis")
                ' разрешаем полны доступ
                setFileAccess(sys & "\Inf\cdrom.pnf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)
                setFileAccess(sys & "\Inf\cdrom.inf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)

                My.Computer.FileSystem.RenameFile(sys & "\Inf\cdrom.pnf.dis", "cdrom.pnf")
                My.Computer.FileSystem.RenameFile(sys & "\Inf\cdrom.inf.dis", "cdrom.inf")
                str1 = str1 & "разблокированы'" & Chr(13)
            Else
                ' убираем все имеющиеся разрешения
                remInheritAndLocAcc(sys & "\Inf\cdrom.pnf")
                remInheritAndLocAcc(sys & "\Inf\cdrom.inf")
                ' разрешаем полный доступ
                setFileAccess(sys & "\Inf\cdrom.pnf", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)
                setFileAccess(sys & "\Inf\cdrom.inf", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow)

                My.Computer.FileSystem.RenameFile(sys & "\Inf\cdrom.pnf", "cdrom.pnf.dis")
                My.Computer.FileSystem.RenameFile(sys & "\Inf\cdrom.inf", "cdrom.inf.dis")

                ' запрещаем полный доступ
                remInheritAndLocAcc(sys & "\Inf\cdrom.pnf.dis")
                remInheritAndLocAcc(sys & "\Inf\cdrom.inf.dis")
                setFileAccess(sys & "\Inf\cdrom.pnf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Deny)
                setFileAccess(sys & "\Inf\cdrom.inf.dis", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Deny)
                str1 = str1 & "заблокированы'" & Chr(13)
            End If
        End If

        ' Установленые CD_Rom
        If Id_Cd_Old <> St_Cd_Old Then
            str1 = str1 & "Установленые CD-Rom: '"
            If Id_Cd_Old Then
                Kod = 3
                str1 = str1 & "Разблокированы'" & Chr(13)
            Else
                Kod = 4
                str1 = str1 & "Заблокированы'" & Chr(13)
            End If
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\cdrom", "Start", Kod, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If Cmnd.Length <= 1 Then
            MsgBox(str1, vbInformation + vbOKOnly, "Готово")
        End If

        Check()
    End Sub

    Dim gb_Len As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim len_i As Integer
        'Dim len As Integer

        If id_gr = False Then
            len_i = -10
            'len = 135
            If GroupBox1.Height < gb_Len - GB_Usb_Old.Height Then Timer1.Stop()
        Else
            len_i = 10
            'len = 235
            If GroupBox1.Height > gb_Len + GB_Usb_Old.Height Then Timer1.Stop()
        End If
        GroupBox1.Height += len_i
        'CheckBox1.Size = New Size(159, CheckBox1.Size.Height + len_i)

    End Sub

    Dim id_gr As Boolean = False
    Private Sub Gb_Click()
        id_gr = Not id_gr
        If id_gr Then
            Label1.Text = "-"
            GB_Usb_Drv.Text = "New"
            GB_Usb_Old.Visible = True
        Else
            Label1.Text = "+"
            GB_Usb_Drv.Text = "New + Old"
            GB_Usb_Old.Visible = False
        End If
        'CheckBox1.Checked = id_gr
        gb_Len = GroupBox1.Height
        Timer1.Enabled = True
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Gb_Click()
    End Sub
End Class
