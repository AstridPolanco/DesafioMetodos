using System;
class Program
{
    public static void SumarNumeros()
    {
        try
        {
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine($"La suma de los numeros es: {suma}");
        }
        catch (FormatException) 
        {
            Console.WriteLine("Error: Ingrese numeros enteros.");
        }
        catch (OverflowException) 
        {
            Console.WriteLine("Error: El numero ingresado es demasiado alto o demasiado bajo");
        }
        catch (Exception ex) 
        {
        Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("La operacion ha finalizado.");
        }
    }

    static void Main(string[] args)
    {
        SumarNumeros();
    }
}