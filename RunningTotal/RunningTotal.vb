'Alexis Villagran

Option Strict On
Option Compare Binary
Option Explicit On
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
            Console.WriteLine("Enter a transaction amount or press Q to exit")
            userInput = Console.ReadLine()

            Try
                transactionNumber = CDec(userInput)
                RunningTotal(transactionNumber)

            Catch ex As Exception

                If userInput = "q" Then
                    quit = True
                Else
                    Console.WriteLine($"You entered {userInput}.")
                End If

            End Try


        Loop Until quit = True

        Console.Clear()
        Console.WriteLine($"Here is your running total: {RunningTotal(0)}")

    End Sub

    Function RunningTotal(currentNumber As Decimal) As Decimal
        Static _runningTotal As Decimal

        _runningTotal += currentNumber

        Return _runningTotal
    End Function

End Module
