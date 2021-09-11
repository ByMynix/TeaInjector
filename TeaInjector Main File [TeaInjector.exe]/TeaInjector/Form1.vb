Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Threading
Imports System.Diagnostics
Imports System.Diagnostics.Process
Public Class Form1
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            OpenFileDialog1.ShowDialog()
            My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, "C:\TeaInjector\ServiceHub.Microsoft.dll", overwrite:=True)
            MetroButton1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("No File selected")
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim p = Process.GetProcessesByName("hl2")
            If p.Count > 0 Then
                Dim info As New ProcessStartInfo
                info.FileName = ("C:\TeaInjector\ServiceHub.Microsoft.exe")
                info.Verb = "runas"
                Process.Start(info)
                My.Computer.Audio.Play("C:\TeaInjector\ServiceHub.MicrosoftSound.wav", AudioPlayMode.Background)
            Else
                MessageBox.Show("Process not found! Start Team Fortress 2 first before you try to inject")
            End If
        Catch ex As Exception
            MessageBox.Show("File not found! Your antivirus may have removed the essential files. Check that your antivirus is deactivated and use the 'Repair all Files' method")
        End Try
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click
        MessageBox.Show("=====================

--How to Use--

- Turn off any antivirus on your computer
- Start Team Fortress 2
- Click on [Choose File] and choose your file (cheat.dll)
- Click on [Inject]
- Enjoy !

--------------")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As WebClient = New WebClient()
        If MetroTextBox1.Text = client.DownloadString("https://teainjector.bymynix.xyz/Update%20Checker%201.1.txt") Then

        Else
            Timer1.Interval = 3 * 1000
            Timer1.Start()
        End If
        MetroButton1.Enabled = False
    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs)
        Process.Start("https://cheatermad.com/")
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            Dim info As New ProcessStartInfo
            info.FileName = ("C:\TeaInjector\Repair.exe")
            info.Verb = "runas"
            Process.Start(info)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("File not found! Your antivirus may have removed the essential files. Check that your antivirus is deactivated and reinstall TeaInjector")
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Dim url As String = "https://teainjector.bymynix.xyz/Changelogs.txt"
        Try
            Using wc As New System.Net.WebClient()
                MsgBox(wc.DownloadString(url))
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MessageBox.Show("New update available! The update will start automatically.")
        Dim h As New Form2
        h.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Process.Start("https://projects.bymynix.xyz")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://bit.ly/cheatermad")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://bit.ly/cheaterninja")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("http://discord.bymynix.xyz/")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://corsair.wtf/")
    End Sub
End Class
