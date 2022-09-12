Public Class Vaccine
    Private _name As String
    Private _doses As Integer
    Private _Vaccinated As Integer
    Private _infectedvaccinated As Integer
    Private _effectiveness As Double
    Public Sub New(n As String, d As Integer, e As Double)
        _name = n
        _doses = d
        _effectiveness = e
    End Sub
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Property doses() As Integer
        Get
            Return _doses
        End Get
        Set(value As Integer)
            _doses = value
        End Set
    End Property
    Public Property infectedvaccinated() As Integer
        Get
            Return _infectedvaccinated
        End Get
        Set(value As Integer)
            _infectedvaccinated = value
        End Set
    End Property
    Public Property vaccinated() As Integer
        Get
            Return _Vaccinated
        End Get
        Set(value As Integer)
            _Vaccinated = value
        End Set
    End Property

    Public Property Effectiveness() As Double
        Get
            Return _effectiveness
        End Get
        Set(value As Double)
            _effectiveness = value
        End Set
    End Property

    Public Function Veffectiveness() As Double
        Dim ave As Double
        ave = (infectedvaccinated / vaccinated) * 100
        Return 100 - ave
    End Function
End Class
