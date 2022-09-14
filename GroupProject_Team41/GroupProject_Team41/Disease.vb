Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class Disease
    Private _Name As String
    Private _NumTests() As Integer
    Private _Population() As Integer
    Private _NumInfected() As Integer
    Private _NumDied() As Integer
    Private _TypeOfDisease As String
    
    'constructor
    Public Sub New(name As String, t As String, size As Integer)
        _Name = name
        ReDim _NumTests(size)
        ReDim _NumDied(size)
        ReDim _NumInfected(size)
        ReDim _Population(size)
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
    
    'general methods
    Public Overridable Function AvePeopleInfected() As Double
        Dim average As Double
        average = (NumInfected / population) * 100
        Return average
    End Function

     Public Overridable Function infectionRate(size As Integer) As Double
        Dim ave, totalinf As Double

        For i As Integer = 1 To _NumInfected.Length - 1
            totalinf += NumInfected(i)
            ave += totalinf / population(i)
        Next i

        Return CDbl(Format(ave, "0.###"))
    End Function

    Public Overridable Function DeathRate() As Double
        Return (numdied / NumInfected) * 100
    End Function

   Public Overridable Function yearEval(size As Integer) As String
        Dim max, max1 As Double
        Dim trend1, trend2 As String
        max = numdied(1)
        max1 = NumInfected(1)
        If max < numdied(size) Then
            trend1 = "Increasing"
        Else
            trend1 = "Decreasing"
        End If
        If max1 < NumInfected(size) Then
            trend2 = "Increasing"
        Else
            trend2 = "Decreasing"
        End If


        Return "Death Rate:" & trend1 & Environment.NewLine _
           & "Infection Rate:" & trend2
    End Function


    Public Overridable Function Display() As String
        Return "Name of disease:" & name & Environment.NewLine _
           & "Population number:" & CStr(population) & Environment.NewLine _
       & "Number of people infected:" & CStr(NumInfected) & Environment.NewLine _
       & "Infection Rate" & CStr(infectionRate()) & Environment.NewLine _
    

    End Function
End Class
