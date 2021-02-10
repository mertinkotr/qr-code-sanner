Imports ZXing.Common
Imports ZXing
Imports ZXing.QrCode
Public Class Form1
    Dim pic As Bitmap = New Bitmap(390, 390)
    Dim gfx As Graphics = Graphics.FromImage(pic)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 30), New Point(0, 0), pic.Size)
        PictureBox1.Image = pic
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Reader As New BarcodeReader()
        PictureBox2.Image = pic
        Dim result As Result = Reader.Decode(pic)
        Try
            Dim decoded As String = result.ToString().Trim()
            TextBox1.Text = decoded
        Catch ex As Exception

        End Try

    End Sub
End Class
