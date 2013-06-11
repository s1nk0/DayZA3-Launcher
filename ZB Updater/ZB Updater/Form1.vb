Imports Ionic.Zip
Public Class Form1
    Private Sub DownloadUpdate(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim getRemoteVersion As String
        Dim downloadUpdate As String
        Dim extractLocation As String = "update\"
        Dim launcherEXE As String = "Zoombies Launcher.exe"
        Dim newUpdate As String = "update.zip"

        Try
            Using WC As New System.Net.WebClient()
                getRemoteVersion = WC.DownloadString("http://cdn.pwnoz0r.com/zoombies/launcher/read/ziplauncher.txt")
            End Using
        Catch ex As Exception
            MsgBox("The servers are unavilable at this time. Please try again later.")
            System.Diagnostics.Process.Start("Zoombies Launcher.exe")
            Me.Close()
        End Try

        My.Computer.Network.DownloadFile(getRemoteVersion, newUpdate)

        If My.Computer.FileSystem.FileExists(launcherEXE) Then
            Try
                Using zip1 As ZipFile = ZipFile.Read(newUpdate)
                    For Each exex In zip1
                        exex.Extract(extractLocation, ExtractExistingFileAction.OverwriteSilently)
                    Next
                End Using

                'Dim getNewFileList As String = extractLocation + "/Zoombies Launcher.exe" + extractLocation + "/clientver.txt" + extractLocation + "\parameters.txt"

                'Dim getFileListArray() As String = {"Zoombies Launcher.exe", "clientver.txt"}

                'Dim newFileArray As My.Computer.FileSystem.CopyFile( _
                'extractLocation + "/Zoombies Launcher.exe", _
                'extractLocation + "/clientver.txt", _
                'extractLocation + "/parameters.txt", override=true)

                Dim zoombiesLauncher As String = extractLocation + "/Zoombies Launcher.exe"
                Dim clientVer As String = extractLocation + "/clientver.txt"
                Dim params As String = extractLocation + "/parameters.txt"
                Dim getParent As String = My.Computer.FileSystem.GetParentPath(extractLocation)

                'My.Computer.FileSystem.MoveFile(zoombiesLauncher + clientVer + params, getParent.ToString)
                'My.Computer.FileSystem.CopyFile(zoombiesLauncher + clientVer + params, getParent, True)
                'My.Computer.FileSystem.DeleteDirectory(extractLocation, FileIO.DeleteDirectoryOption.DeleteAllContents)
                MsgBox("Update complete!")
                'MsgBox(getParent.ToString)
                'System.Diagnostics.Process.Start(launcherEXE)
                My.Computer.FileSystem.DeleteFile(newUpdate)
                My.Computer.FileSystem.MoveFile(zoombiesLauncher + clientVer + params, getParent)
                Me.Close()
            Catch ex As Exception
                MsgBox("Update failed. Please run the launcher again.")
                My.Computer.FileSystem.DeleteFile(newUpdate)
                Me.Close()
            End Try
        Else
            MsgBox("Zoombies Launcher is not installed.")
            'If My.Computer.FileSystem.FileExists(newUpdate) Then
            My.Computer.FileSystem.DeleteFile(newUpdate)
            'Else
            Me.Close()
        End If
        'End If
    End Sub
End Class