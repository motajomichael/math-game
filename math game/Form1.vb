Public Class Form1

    Dim ans As Integer
    Dim score As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Randomize()

        generatemaths()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If TextBox1.Text = ans Then
            MsgBox("correct answer")
            score += 1
            TextBox1.Text = ""
        Else : MsgBox("wrong answer, wrong answers attract -1")
            score -= 1
            TextBox1.Text = ""
        End If
        Label6.Text = "YOUR SCORE IS : " & score
        generatemaths()
    End Sub

    Private Sub generatemaths()

        Dim a As Integer = Int(Rnd() * 20 + 1)
        Dim b As Integer = Int(Rnd() * 20 + 1)

        Dim c As Integer = Int(Rnd() * 4)
        Label2.Text = a
        Label4.Text = b


        Select Case c
            Case 0
                Label3.Text = "+"
                ans = Label2.Text + Label4.Text
            Case 1
                Label3.Text = "-"
                ans = Label2.Text - Label4.Text
            Case 2
                Label3.Text = "*"
                ans = Label2.Text * Label4.Text
            Case 3
                Label3.Text = "\"
                ans = Label2.Text / Label4.Text
        End Select


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
            MsgBox("Time up!!! Wrong answer")

        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 600
        Timer1.Interval = 1
        Timer1.Enabled = True

    End Sub
End Class
