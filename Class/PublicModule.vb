Imports System.Runtime.CompilerServices
Module PublicModule
    Public ConnectionString As String = ConfigurationManager.ConnectionStrings("KMURegConnectionString").ConnectionString '"Data Source=.;Initial Catalog=KMUReg;Persist Security Info=True;User ID=sa;Password=Mmgh100122" '

    <Extension()>
    Public Function AreEqualDays(ByVal oDate1 As DateTime,
                                 ByVal oDate2 As DateTime) As Boolean
        Return Math.Truncate(oDate1.ToOADate) = Math.Truncate(oDate2.ToOADate)
    End Function
    Public Function ToDate(ByVal oDate) As Date
        Return Date.FromOADate(Math.Truncate(oDate.ToOADate))
    End Function

End Module
