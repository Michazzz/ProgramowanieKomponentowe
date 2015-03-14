Public Class OwnButtonInherits
    Inherits System.Windows.Forms.Button
    Public Property NaszInterface As Changes

    Public Sub New()
        MyBase.New()
        Me.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Me.Click
        NaszInterface.Save()
    End Sub
End Class
