Imports System

Class Program
    Public Shared Sub Main()
        Dim i As Single = 0
        Console.Write("Enter a positive integer: ")
        i = Single.Parse(Console.ReadLine())

        If i - CInt(i) = 0 AndAlso i > 0 Then
            Dim n As Integer
            n = CInt(i)

            If n > 0 Then

                While n <> 1

                    If n Mod 2 = 0 Then
                        n = n / 2
                    Else
                        n = 3 * n + 1
                    End If

                    Console.Write(" " & n)
                End While

                Console.ReadLine()

            End If
        Else
            Console.WriteLine("Please Enter a positive integer.")
            Console.ReadLine()

        End If
    End Sub
End Class
