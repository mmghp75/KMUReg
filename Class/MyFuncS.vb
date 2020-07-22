Public Class MyFuncS
    Public Shared Function myrandint(MaxInt As Int32, Optional m As Int32 = 0, Optional n As Int32 = 0) As Object
        ' This functions creates random numbers between [1 MaxInt] (1 itself And MaxInt itself)
        Randomize()

        If m = 0 And n = 0 Then
            Dim oResult(0) As Integer
            oResult(0) = Math.Ceiling(Rnd() * MaxInt)
            Return oResult
        ElseIf m <> 0 And n <> 0
            Dim oResult(m - 1, n - 1) As Integer
            For i = 0 To m - 1
                For j = 0 To n - 1
                    oResult(i, j) = Math.Ceiling(Rnd() * MaxInt)
                Next
            Next
            Return oResult
        End If

        Dim oResult0(0) As Int32
        Return oResult0 '("Incorrect Number of Inputs")
    End Function
End Class
