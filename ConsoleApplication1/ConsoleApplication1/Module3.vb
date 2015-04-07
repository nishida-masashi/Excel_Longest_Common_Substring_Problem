Module Module3

    Sub str_1()

        Const str1 As String = "Ask not what your country can do for you, but what you can do for your country."
        Dim len_1 As Integer = str1.Length
        
        Dim max As Integer = -1
        Dim last As Integer = -1

        Dim data As Integer()
        ReDim data(len_1 + 1)

        For a As Integer = 0 To len_1 - 1
            For b As Integer = len_1 - 1 To 0 Step -1
                If a > b Then
                    If String.Equals(str1(a), str1(b)) Then
                        data(b + 1) = data(b) + 1
                        If max < data(b + 1) Then
                            max = data(b + 1)
                            last = b + 1
                        End If
                    Else
                        data(b + 1) = 0
                    End If
                End If
            Next
        Next

        Console.WriteLine(str1.Substring(last - max, max))

    End Sub

End Module
