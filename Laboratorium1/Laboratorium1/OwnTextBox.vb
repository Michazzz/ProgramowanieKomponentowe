Public Class OwnTextBox
    Inherits System.Windows.Forms.RichTextBox
    Public Property NaszInterface As Changes

    Public Sub New()
        MyBase.New()
    End Sub

    Private Sub rtbText_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        NaszInterface.Zmiana()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)
    End Sub
End Class
