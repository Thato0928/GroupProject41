Option Strict On
Option Explicit On
Option Infer Off
Public Class HIV
    Inherits Disease

    Public Sub New(name As String, nP As Integer, nT As Integer, nA As Integer, nD As Integer, t As String)
        MyBase.New(name, nP, nT, nA, nD, t)

    End Sub
End Class
