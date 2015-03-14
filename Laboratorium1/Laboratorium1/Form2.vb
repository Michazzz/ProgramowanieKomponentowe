Public Class Form2
    Implements Changes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OwnTextBox1.NaszInterface = Me
        Me.OwnButtonInherits1.NaszInterface = Me
    End Sub

    Public Function Save() As Integer Implements Changes.Save
        Me.OwnButtonInherits1.Enabled = False
        Return 0
    End Function

    Public Sub Zmiana() Implements Changes.Zmiana
        Me.OwnButtonInherits1.Enabled = True
    End Sub
End Class

Public Interface Changes
    Function Save() As Integer
    Sub Zmiana()
End Interface
