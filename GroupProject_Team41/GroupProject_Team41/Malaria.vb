Option Strict On
Option Explicit On
Option Infer Off
Public Class Malaria
    Inherits Disease
    Private _vaccines As Vaccine
    Private _numSurvived() As Integer
    
    'constructor
     Public Sub New(name As String, t As String, size As Integer)
        MyBase.New(name, t, size)
        ReDim _numSurvived(size)
        _vaccines = New Vaccine
    End Sub
    
    'property methods
    Public Property vaccines() As Vaccine
        Get
            Return _vaccines
        End Get
        Set(value As Vaccine)
            _vaccines = value
        End Set
    End Property
    Public Property numsurvived(i As Integer) As Integer
        Get
            Return _numSurvived(i)

        End Get
        Set(value As Integer)
            _numSurvived(i) = value

        End Set
    End Property
    
    'general methods
    Public Function DeathSurvivalRatio() As String
        Dim max As Integer
        Dim d, s As Integer
        Dim Ratio As String
        Dim totalDied, totalSurvived As Integer
        For i As Integer = 1 To _numSurvived.Length - 1
            totalDied += numdied(i)
            totalSurvived += numsurvived(i)
        Next i
        max = totalDied

        If max < totalSurvived Then
            max = totalSurvived
        End If
        d = CInt(totalDied / max)
        s = CInt(totalSurvived / max)
        Ratio = CStr(d & ":" & s)
        Return Ratio
    End Function

    Public Overridable Function SurvivalRate() As Double
        Dim rate As Double
        Dim status1, status2 As String
        Dim Totalinf As Integer
        Dim Totalsurv As Integer
        For i As Integer = 1 To _numSurvived.Length - 1
            Totalinf += NumInfected(i)
            Totalsurv += numsurvived(i)
        Next i
        rate = CDbl(Format(((Totalsurv / Totalinf) * 100), "0.##"))
        status1 = "Total survived: " & CStr(Totalsurv)
        status2 = "Survival Rate: " & CStr(rate)
        Return CDbl(status1 & Environment.NewLine _
            & status2)
    End Function
    Public Function Veffective() As Double
        Return _vaccines.Veffectiveness()

    End Function
    Public Overrides Function Infectionrate(size As Integer) As Double
        Return MyBase.infectionRate(size)
    End Function
    Public Overrides Function AvePeopleInfected(size As Integer) As Double
        Return MyBase.AvePeopleInfected(size)
    End Function
    Public Overrides Function DeathRate() As Double
        Return MyBase.DeathRate()
    End Function

    Public Overrides Function yearEval(size As Integer) As String
        Dim max As Integer
        Dim Rate As String
        max = numsurvived(1)
        If max < numsurvived(size) Then
            Rate = "Increasing"
        Else
            Rate = "Decreasing"
        End If
        Return MyBase.yearEval(size) + " " & Environment.NewLine _
        & "Survival rate:" & Rate
    End Function

    Public Overrides Function Display(size As Integer) As String
        Dim totalsurv As Integer
        For i As Integer = 1 To size
            totalsurv += numsurvived(i)
        Next
        Return MyBase.Display(size) & Environment.NewLine _
            & "Number of Cured: " & CStr(totalsurv) & Environment.NewLine _
         & "Survival Rate: " & Format(SurvivalRate(), "0.##") & Environment.NewLine _
             & "Death-Survival Ratio" & " " & DeathSurvivalRatio() & Environment.NewLine _
              & "Vaccine Name: " & vaccines.name & Environment.NewLine _
               & "Number of doses: " & CStr(vaccines.doses) & Environment.NewLine _
               & "Number of Vaccinated:" & CStr(vaccines.vaccinated) & Environment.NewLine _
                & "Number of Infected while Vaccinated:" & CStr(vaccines.infectedvaccinated) & Environment.NewLine _
         & "Vaccine effectiveness:" & Format(Veffective(), "0.##")
    End Function
End Class
