Public Class Form1
    Dim mousePos As Point
    Dim angle As Single
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.OptimizedDoubleBuffer _
                 Or ControlStyles.AllPaintingInWmPaint _
                 Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim gr As Graphics = e.Graphics
        gr.Clear(Color.White)
        Using pen As New Pen(Color.Blue, 5)
            'pen.Color = Color.Pink
            'gr.DrawLine(pen,
            '        New Point(0, 0),
            '        New Point(e.ClipRectangle.Width,
            '                  e.ClipRectangle.Height))
            'pen.Color = Color.Red
            'gr.DrawLine(pen,
            '            New Point(e.ClipRectangle.Width, 0),
            '            New Point(0, e.ClipRectangle.Height))
            'pen.Width = 7
            'pen.Color = Color.Purple
            'gr.DrawRectangle(pen,
            '                 New Rectangle(50, 15, 100, 75))
            'pen.Color = Color.Blue
            'pen.Width = 2
            'gr.DrawRectangle(pen,
            '                 New Rectangle(
            '                    New Point(100, 100),
            '                    New Size(50, 50)))
            'pen.Color = Color.Coral
            'gr.DrawEllipse(pen, New Rectangle(50,
            '                                  25,
            '                                  e.ClipRectangle.Width - 100,
            '                                  e.ClipRectangle.Height - 50))
            'pen.Color = Color.Aquamarine
            'pen.Width = 20
            'gr.DrawArc(pen,
            '           New Rectangle(50, 25, e.ClipRectangle.Width - 100, e.ClipRectangle.Height - 50),
            '           0,
            '           45)

            'gr.TranslateTransform(10, 20)
            'gr.RotateTransform(5)

            'gr.DrawImage(My.Resources.lena,
            '             e.ClipRectangle)


            'pen.Color = Color.Pink
            'pen.Width = 5
            'gr.DrawBezier(pen,
            '              New Point(0, 0),
            '              New Point(e.ClipRectangle.Width / 2, 15),
            '              mousePos,
            '              New Point(e.ClipRectangle.Width, e.ClipRectangle.Height))

            'pen.Color = Color.Green
            'Dim brush As Brush = pen.Brush
            'gr.FillRectangle(brush,
            '                 New Rectangle(50, 15, 100, 75))
            'pen.Color = Color.White
            Dim font As New Font("Arial", 19)
            gr.DrawString(mousePos.ToString(),
                          font,
                          pen.Brush,
                          New Point(mousePos.X + 10, mousePos.Y))

            'gr.ResetTransform()
            'Dim tbrush As New TextureBrush(My.Resources.mickey)
            'tbrush.WrapMode = Drawing2D.WrapMode.TileFlipX
            'tbrush.TranslateTransform(mousePos.X, mousePos.Y)
            'gr.FillEllipse(tbrush, e.ClipRectangle)

            gr.TranslateTransform(e.ClipRectangle.Width / 2,
                                  e.ClipRectangle.Height / 2)
            Using img As New Bitmap(My.Resources.sol, New Size(100, 100))
                Dim rangle As Single = angle * 0.0174533
                Dim radio As Single = Width / 3
                gr.DrawImage(img,
                             New PointF(radio * Math.Cos(rangle) - img.Width / 2,
                                        radio * Math.Sin(rangle) - img.Height / 2))
            End Using
        End Using
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Me.Refresh()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        mousePos = e.Location
    End Sub

    Private Sub sunUpdater_Tick(sender As Object, e As EventArgs) Handles sunUpdater.Tick
        angle = (angle + 1) Mod 360
        Text = angle.ToString()
        Me.Refresh()
    End Sub
End Class
