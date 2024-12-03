Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then Move(Avatar, -5, 0)
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then Move(Avatar, 5, 0)
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then Move(Avatar, 0, 5)
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then Move(Avatar, 0, -5)
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.R Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        Avatar.Refresh()
    End Sub
    Sub Move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        'If p.Bounds.IntersectsWith(Coin.Bounds) Then
        'Coin.Visible = False
        'End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Enemy, Avatar, 10)
        follow(Enemy2, Avatar, 5)
    End Sub
    Sub follow(e As PictureBox, a As PictureBox, s As Integer)
        If e.Location.Y < a.Location.Y Then
            Move(e, 0, s)
        Else
            Move(e, 0, -s)
        End If

        If e.Location.X < a.Location.X Then
            Move(e, s, 0)
        Else
            Move(e, -s, 0)
        End If
    End Sub

End Class
