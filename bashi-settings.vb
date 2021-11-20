Public Class bashi_settings

    Private Sub bashi_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.size
        If My.Settings.alwaysontop = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.alwaysontop = True
        Else
            My.Settings.alwaysontop = False
        End If
        My.Settings.size = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim Value As Integer
        ' is there an (integer) NUMBER in the textbox?
        If Integer.TryParse(TextBox1.Text, Value) Then
            If Value > 0 AndAlso Value < 879 Then
                My.Settings.size = TextBox1.Text
            Else
                MessageBox.Show("please enter a number!")
            End If
        Else
            MessageBox.Show("please enter a number!")
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Process.Start("https://soafen.love")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Application.Exit()
        End
    End Sub
End Class