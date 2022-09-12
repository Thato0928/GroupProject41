Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class Disease
    Private _Name As String  'Redim all the arrays and fix the constructors
    Private _NumTests() As Integer
    Private _Population() As Integer
    Private _NumInfected() As Integer
    'rivate _NumSurvived As Integer
    Private _NumDied() As Integer
    Private _TypeOfDisease As String
    Public Sub New(name As String, nP As Integer, nT As Integer, nA As Integer, nD As Integer, t As String)
        _Name = name
        _Population = nP
        _NumTests = nT
        _NumInfected = nA
        '_NumSurvived = nS
        _NumDied = nD
        _TypeOfDisease = t


    End Sub
    Public Property name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property population() As Integer 'modify all the property methods because we changed all attributes to arrays
        Get
            Return _Population
        End Get
        Set(value As Integer)
            _Population = value
        End Set
    End Property
    Public Property NumTests() As Integer
        Get
            Return _NumTests
        End Get
        Set(value As Integer)
            _NumTests = value
        End Set
    End Property

    Public Property NumInfected() As Integer
        Get
            Return _NumInfected
        End Get
        Set(value As Integer)
            _NumInfected = value
        End Set
    End Property

    Public Property numdied() As Integer
        Get
            Return _NumDied
        End Get
        Set(value As Integer)
            _NumDied = value
        End Set
    End Property
    Public Property typeofdisease() As String
        Get
            Return _TypeOfDisease
        End Get
        Set(value As String)
            _TypeOfDisease = value
        End Set
    End Property
    Public Overridable Function AvePeopleInfected() As Double
        Dim average As Double
        average = (NumInfected / population) * 100
        Return average
    End Function

    Public Overridable Function infectionRate() As Double
        Return (NumInfected / population) * 100
    End Function


    Public Overridable Function DeathRate() As Double
        Return (numdied / NumInfected) * 100
    End Function
    Public Overridable Function yearEval() As String

    End Function


    Public Overridable Function Display() As String
        Return "Name of disease:" & name & Environment.NewLine _
           & "Population number:" & CStr(population) & Environment.NewLine _
       & "Number of people infected:" & CStr(NumInfected) & Environment.NewLine _
       & "Infection Rate" & CStr(infectionRate()) & Environment.NewLine _
    

    End Function
End Class
