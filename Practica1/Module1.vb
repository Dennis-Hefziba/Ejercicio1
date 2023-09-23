Module Module1

    'Escriba un programa que solicite la edad de una persona y determine si es menor o
    'mayor de edad, deberá mostrar un mensaje.

    Sub Main(Args As String())

        Dim retorno As Boolean = True

        Console.WriteLine("Hola Bienvenido al sistema de validacion de edades")
        Console.WriteLine("")

        Do
            Console.WriteLine()
            Console.WriteLine("-----------------------------")
            Console.WriteLine("Por favor ingrese su edad")

            Dim edadTexto As String = Console.ReadLine()

            'Convertir la entrada en numero entero
            Dim edad As Integer


            If Integer.TryParse(edadTexto, edad) Then

            End If

            If edad >= 18 Then
                Console.WriteLine("Eres mayor de edad")
                Console.WriteLine("-----------------------------")

            ElseIf edad > 0 Then
                Console.WriteLine("No eres mayor de edad")
                Console.WriteLine("-----------------------------")

            Else
                Console.WriteLine("Ingresa una edad valida")
                Console.WriteLine("-----------------------------")
            End If

            Console.WriteLine()
            Console.WriteLine("Si deseas ingresar otra edad presiona cualquier tecla para continuar de lo contrario")
            Console.Write("Presiona S para salir...")
            Dim respuesta As ConsoleKeyInfo = Console.ReadKey()
            Console.WriteLine()

            If respuesta.Key = ConsoleKey.S Then
                Exit Do
            End If

        Loop While retorno = True



    End Sub

End Module
