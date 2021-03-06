﻿Friend Class CsvDateFormatter
    Inherits Singleton(Of CsvDateFormatter)
    Implements ICsvRecordFormatter

    Public Function Parse(text As StringSegment) As Object Implements ICsvRecordFormatter.Parse
        Return Date.Parse(text.CopyToString)
    End Function

    Public Function GetString(data As Object, format As String) As String Implements ICsvRecordFormatter.GetString
        Return DirectCast(data, Date).ToString(format)
    End Function

    Public Function ParseBlittablePrimitive(text As StringSegment, ByRef primitive As CsvBlittablePrimitive) As Boolean Implements ICsvRecordFormatter.ParseBlittablePrimitive
        Return False
    End Function
End Class
