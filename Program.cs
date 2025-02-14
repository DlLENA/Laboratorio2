//Parte 1: Declaración y Uso de Variables

using System;

class Program
{
    static void Main()
    {
        // Declaración de variables
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        // Pedir valores al usuario
        Console.WriteLine("Introduce un número entero:");
        numeroEntero = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce un número decimal:");
        numeroDecimal = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduce un texto:");
        texto = Console.ReadLine();

        Console.WriteLine("Introduce un valor verdadero o falso (true/false):");
        valorBooleano = bool.Parse(Console.ReadLine());

        // Mostrar valores ingresados
        Console.WriteLine($"Número entero: {numeroEntero}");
        Console.WriteLine($"Número decimal: {numeroDecimal}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Valor booleano: {valorBooleano}");
    }
}


//PARTE 2: OPERACIONES MATEMATICAS 

using System;

class Program
{
    static void Main()
    {
        // Variables para operaciones
        int numero1, numero2;
        Console.WriteLine("Introduce el primer número:");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        numero2 = int.Parse(Console.ReadLine());

        // Realizar operaciones
        Console.WriteLine($"Suma: {numero1 + numero2}");
        Console.WriteLine($"Resta: {numero1 - numero2}");
        Console.WriteLine($"Multiplicación: {numero1 * numero2}");
        Console.WriteLine($"División: {(double)numero1 / numero2}"); // Aseguramos que sea decimal


    }
}


using System;

class Program
{
    static void Main()
    {
        // Pedir dos valores numéricos
        Console.WriteLine("Introduce el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        // Comparaciones y operaciones lógicas
        Console.WriteLine($"¿Es el primer número mayor que el segundo? {num1 > num2}");
        Console.WriteLine($"¿Es el primer número menor que el segundo? {num1 < num2}");
        Console.WriteLine($"¿Son iguales los dos números? {num1 == num2}");

        bool operacionLogica = (num1 > num2) && (num1 != 0);
        Console.WriteLine($"Operación lógica AND (&&): {operacionLogica}");

        operacionLogica = (num1 < num2) || (num1 == 10);
        Console.WriteLine($"Operación lógica OR (||): {operacionLogica}");
    }
}
