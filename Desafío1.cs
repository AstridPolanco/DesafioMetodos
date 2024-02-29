using System;

class Ingresos
{
    public static void CalcularIngresos()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        double ingreso1, ingreso2, ingreso3, suma, promedio;

        Console.Write("Introduzca el ingreso del primer mes: ");
        ingreso1 = Convert.ToDouble (Console.ReadLine());

        Console.Write("Introduzca el ingreso del segundo mes: ");
        ingreso2 = Convert.ToDouble (Console.ReadLine());

        Console.Write("Introduzca el ingreso del tercer mes: ");
        ingreso3 = Convert.ToDouble(Console.ReadLine());

        suma = ingreso1 + ingreso2 + ingreso3;
        promedio = suma / 3;

        Console.WriteLine($"Hola {nombre}, el total ganado es de {suma:C2} y el promedio {promedio:C2}.");
    }

    static void Main(string[] args)
    {
        CalcularIngresos();
    }
}