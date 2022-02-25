Imports System

Module Program
    Sub Main()
        'practica de un ejercicio x'
        Console.Title = "Jacquelinne"
        Console.WriteLine("Programa para saber que numero es mayor o menor")

        Dim numero1, numero2, numero3, x, y As Integer
        'Dim nombre, apellido As Char'
        'Dim promedio As Double'


        Console.Write("ingresa el primer numero: ")

        numero1 = Console.ReadLine()

        Console.Write("ingresa el segundo numero: ")
        numero2 = Console.ReadLine()

        Console.Write("ingresa el tercer numero: ")
        numero3 = Console.ReadLine()

        If numero1 > numero3 And numero1 > numero2 Then

            x = numero1

        ElseIf numero2 > numero3 And numero2 > numero1 Then

            x = numero2

        Else
            x = numero3

        End If

        If numero1 < numero3 And numero1 < numero2 Then

            y = numero1

        ElseIf numero2 < numero3 And numero2 < numero1 Then

            y = numero2

        Else
            y = numero3

        End If

        Console.WriteLine("El numero mayor es: " & x)
        Console.WriteLine("El numero menor es: " & y)

        Console.ReadKey()

    End Sub
End Module
