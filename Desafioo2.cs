using System;

class OperacionesBasicas
{
    public static int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiplicar(int num1, int num2)
    {
        return (num1 * num2);
    }
    public static int Dividir(int num1, int num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            Console.WriteLine("No es posible dividir por cero");
            return 0;
        }
    }
}

class ProgramaPrincipal
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer valor: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int suma = OperacionesBasicas.Sumar(numero1, numero2);
        int resta = OperacionesBasicas.Restar(numero1, numero2);
        int multiplicacion = OperacionesBasicas.Multiplicar(numero1, numero2);
        int division = OperacionesBasicas.Dividir(numero1, numero2);

        Console.WriteLine($"La suma de los valores es: {suma}");
        Console.WriteLine($"La resta de los valores es: {resta}");
        Console.WriteLine($"La multiplicacion de los valores es: {multiplicacion}");
        Console.WriteLine($"La division de los valores es: {division}");
    }
}
