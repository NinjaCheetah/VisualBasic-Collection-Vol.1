Public Class Form3

    Dim num1 As Integer
    Dim num2 As Integer
    Dim opr As String
    Dim ans As Decimal
    Dim num1done As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If num1 = 0 And num2 = 0 Then
            num1 = 1
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 1
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 10
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 10
            Label1.Text = num2
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If num1 = 0 Then
            num1 = 2
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 2
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 20
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 20
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If num1 = 0 Then
            num1 = 3
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 3
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 30
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 30
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If num1 = 0 Then
            num1 = 4
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 4
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 40
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 40
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If num1 = 0 Then
            num1 = 5
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 5
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 50
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 50
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If num1 = 0 Then
            num1 = 6
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 6
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 60
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 60
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If num1 = 0 Then
            num1 = 7
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 7
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 70
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 70
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If num1 = 0 Then
            num1 = 8
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 8
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 80
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 80
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If num1 = 0 Then
            num1 = 9
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 = 0 And num1done = 1 Then
            num2 = 9
            Label1.Text = num2
        ElseIf num1 <= 9 And num1done = 0 Then
            num1 = num1 + 90
            Label1.Text = num1
        ElseIf num1 <> 0 And num2 <= 9 And num1done = 1 Then
            num2 = num2 + 90
            Label1.Text = num2
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        num1 = 0
        Label1.Text = num1
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        opr = "+"
        num1done = 1
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If num1 <> 0 And num2 <> 0 And opr = "+" Then
            ans = num1 + num2
            Label1.Text = ans
        ElseIf num1 <> 0 And num2 <> 0 And opr = "-" Then
            ans = num1 - num2
            Label1.Text = ans
        ElseIf num1 <> 0 And num2 <> 0 And opr = "*" Then
            ans = num1 * num2
            Label1.Text = ans
        ElseIf num1 <> 0 And num2 <> 0 And opr = "/" Then
            ans = num1 / num2
            Label1.Text = ans
        ElseIf num1 = 0 Or num2 = 0 Then
            MessageBox.Show("ERROR: Missing number")
        End If
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num1 = 0
        num2 = 0
        ans = 0
        num1done = 0
        Label1.Text = "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        opr = "-"
        num1done = 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        opr = "*"
        num1done = 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        opr = "/"
        num1done = 1
    End Sub
End Class