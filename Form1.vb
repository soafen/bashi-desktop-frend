Public Class Form1
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Private Sub Form1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        My.Settings.position = Me.Location
    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bashi_settings.ShowDialog()
            If My.Settings.alwaysontop = True Then
                Me.TopMost = True
            Else
                Me.TopMost = False
            End If
            Me.Location = My.Settings.position
            Me.Size = New Point(My.Settings.size, My.Settings.size)
        End If
    End Sub


    Public Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.alwaysontop = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
        Me.Location = My.Settings.position
        Me.Size = New Point(My.Settings.size, My.Settings.size)
    End Sub
End Class
