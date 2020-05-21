Public Class Form2

    Dim clickcount As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.BackColor = Color.Red
        Label1.Text = "Red"
        Label1.BackColor = Color.Red
        clickcount = clickcount + 1
        Label2.Text = "You've Clicked " & clickcount & " time(s)."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.BackColor = Color.Orange
        Label1.Text = "Orange"
        Label1.BackColor = Color.Orange
        clickcount = clickcount + 1
        Label2.Text = "You've Clicked " & clickcount & " time(s)."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.BackColor = Color.Yellow
        Label1.Text = "Yellow"
        Label1.BackColor = Color.Yellow
        clickcount = clickcount + 1
        Label2.Text = "You've Clicked " & clickcount & " time(s)."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.BackColor = Color.Lime
        Label1.Text = "Green"
        Label1.BackColor = Color.Lime
        clickcount = clickcount + 1
        Label2.Text = "You've Clicked " & clickcount & " time(s)."
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.BackColor = Color.Blue
        Label1.Text = "Blue"
        Label1.BackColor = Color.Blue
        clickcount = clickcount + 1
        Label2.Text = "You've Clicked " & clickcount & " time(s)."
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.BackColor = Color.Transparent
        Label1.Text = "White"
        Label1.BackColor = Color.Transparent
        clickcount = 0
        Label2.Text = "You've Clicked " & clickcount & " time(s)."
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        clickcount = 0
        Label2.Text = "You've Clicked " & clickcount & " time(s)."
        Me.Hide()
        Form1.Show()
    End Sub
End Class
