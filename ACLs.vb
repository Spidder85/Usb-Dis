Imports ProcessPrivileges
Module ACLs
    'Private Const locFile = "\remOldFile.exe"
    'Private Const locPath = "C:\windows"
    Private oACL As Security.AccessControl.FileSecurity
    Private BuiltInUsersSid As Security.Principal.SecurityIdentifier

    Public Sub setFileAccess(ByVal oFileName As String, ByVal Rights As Security.AccessControl.FileSystemRights, ByVal Access As Security.AccessControl.AccessControlType)

        Dim oFileACLs As New Security.AccessControl.FileSecurity(oFileName, Security.AccessControl.AccessControlSections.Access)
        Dim oBuiltInUsersSid As New Security.Principal.SecurityIdentifier(Security.Principal.WellKnownSidType.WorldSid, Nothing)

        ' Устанавливаем на права <Rights> доступ <Access> на фалй <oFileName> для "Everyone"
        Dim oRule As New Security.AccessControl.FileSystemAccessRule(oBuiltInUsersSid,
                                                                      Rights,
                                                                     Security.AccessControl.InheritanceFlags.None, Security.AccessControl.PropagationFlags.None,
                                                                     Access)
        oFileACLs.AddAccessRule(oRule)
        System.IO.File.SetAccessControl(oFileName, oFileACLs)
    End Sub

    Public Sub clsSecur(ByVal FileName As String)



        remInheritAndLocAcc(FileName)


    End Sub
    Public Sub remInheritAndLocAcc(ByVal FileName As String)
        BuiltInUsersSid = New Security.Principal.SecurityIdentifier(Security.Principal.WellKnownSidType.WorldSid, Nothing)

        If IO.File.Exists(FileName) Then    ' Если файл существует - сброс разрешений
            Dim process As Process = Process.GetCurrentProcess
            Dim PrivEnable As ProcessPrivileges.PrivilegeEnabler = New ProcessPrivileges.PrivilegeEnabler(process, ProcessPrivileges.Privilege.TakeOwnership)
            Dim sid = WindowsIdentity.GetCurrent().User
            Dim account = CType(sid.Translate(GetType(NTAccount)), NTAccount)
            Dim rootInfo = New FileInfo(FileName) ' DirectoryInfo(FileName) ' FileInfo(FileName)
            rootInfo.SetOwnerAndRights(account)
            PrivEnable.Dispose()

            Dim fi As New System.IO.FileInfo(FileName)
            Dim fs As System.Security.AccessControl.FileSecurity = fi.GetAccessControl

            Dim oBuiltInUsersSid As New Security.Principal.SecurityIdentifier(Security.Principal.WellKnownSidType.BuiltinAdministratorsSid, Nothing)
            fs.SetOwner(oBuiltInUsersSid)
            Try
                IO.File.SetAccessControl(FileName, fs)
            Catch ex As Exception
            End Try

            Dim fs1 As FileSecurity = IO.File.GetAccessControl(FileName)
            fs1 = IO.File.GetAccessControl(FileName)
            ' Убираем наследование безопастности
            fs1.SetAccessRuleProtection(True, False)
            IO.File.SetAccessControl(FileName, fs1)

            ' получаем ACL для файла
            Dim oFileACLs As New Security.AccessControl.FileSecurity(FileName, Security.AccessControl.AccessControlSections.Access)

            ' удаляем все локальные настройки безопастности
            For Each oAccessRule As System.Security.AccessControl.FileSystemAccessRule In oFileACLs.GetAccessRules(True, False, GetType(System.Security.Principal.NTAccount))
                oFileACLs.RemoveAccessRuleAll(oAccessRule)
                System.IO.File.SetAccessControl(FileName, oFileACLs)
            Next
            oACL = IO.File.GetAccessControl(FileName)
            Dim oRule As New Security.AccessControl.FileSystemAccessRule(BuiltInUsersSid,
                                                                      Security.AccessControl.FileSystemRights.FullControl,
                                                                     Security.AccessControl.InheritanceFlags.None, Security.AccessControl.PropagationFlags.None,
                                                                     Security.AccessControl.AccessControlType.Allow)
            oACL.AddAccessRule(oRule)
            System.IO.File.SetAccessControl(FileName, oACL)
        End If
    End Sub

End Module
Module Extensions
    <Extension()>
    Sub SetOwnerAndRights(info As FileSystemInfo, account As NTAccount)
        If TypeOf info Is DirectoryInfo Then
            Try
                Dim di = CType(info, DirectoryInfo)
                Dim security = di.GetAccessControl()
                security.SetOwner(account)
                di.SetAccessControl(security)
                security.SetAccessRule(New FileSystemAccessRule(account,
                                                            FileSystemRights.FullControl, InheritanceFlags.ContainerInherit Or
                                                            InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                di.SetAccessControl(security)
            Catch ex As Exception
            End Try
        ElseIf TypeOf info Is FileInfo Then
            Try
                Dim fi = CType(info, FileInfo)
                Dim security = fi.GetAccessControl()
                security.SetOwner(account)
                security.AddAccessRule(New FileSystemAccessRule(account, FileSystemRights.FullControl, AccessControlType.Allow))
                fi.SetAccessControl(security)
            Catch ex As Exception
            End Try
        End If
    End Sub
End Module