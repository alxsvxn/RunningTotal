Option Strict On
Option Compare Binary
Option Explicit On
'Alexis Villagran

Imports System.Diagnostics.Eventing.Reader

Module RunningTotal
    'TO-DO List
    '[X] Keep track of transactions in a Function called RunningTotal()
    '[X] Get current total as needed
    '[] Provide a way to clear/zero the total 
    '[] Super bonus: Create a method to include sales tax in the transaction

    Sub Main()
        Dim userInput As String
        Dim transactionNumber As Decimal
        Dim quit As Boolean = False
        Do

            Console.WriteLine("Enter a transaction amount")
            Console.WriteLine("Enter Q to quit")
            Console.WriteLine("Enter T to show the total")
            Console.WriteLine("Enter C to clear the total")
            userInput = Console.ReadLine()

            Try
                transactionNumber = CDec(userInput)
                RunningTotal(transactionNumber, False)

            Catch ex As Exception

                Select Case userInput
                    Case "q"
                        quit = True

                    Case "t"
                        Console.WriteLine($"The current total is {RunningTotal(0, False).ToString("c")}")

                    Case "c"
                        RunningTotal(0, True)

                    Case Else
                        Console.WriteLine($"You entered {userInput}.")

                End Select

            End Try


        Loop Until quit = True

        Console.Clear()
        Console.WriteLine($"Here is your running total: {RunningTotal(0, False).ToString("c")}")

    End Sub

    Function RunningTotal(Optional currentNumber As Decimal = 0, Optional clear As Boolean = False) As Decimal
        Static _runningTotal As Decimal = 0

        If clear Then
            _runningTotal = 0
        Else
            _runningTotal += currentNumber
        End If

        Return _runningTotal
    End Function

End Module
