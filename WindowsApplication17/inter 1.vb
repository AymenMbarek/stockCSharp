Public Class Form2

    Private WithEvents animationTimer As New Timer()
        Private animationOffset As Integer = 0

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            animationTimer.Interval = 50 ' Set the interval for the animation (in milliseconds)
            animationTimer.Start() ' Start the timer
        End Sub

        Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
            ' Update the label's position
            Label1.Left += 5 ' Move the label to the right by 5 pixels

            ' Check if the label has reached the end of the form
            If Label1.Left + Label1.Width > Me.ClientSize.Width Then
                ' Reset the label's position
                Label1.Left = -Label1.Width
            End If
        End Sub
    End Class


