using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Clasificación de Calificaciones Escolares");
        Console.WriteLine("----------------------------------------");

        Console.Write("Ingrese la nota: ");
        double nota;

        if (double.TryParse(Console.ReadLine(), out nota))
        {
            Console.WriteLine("----------------------------------------");

            if (nota >= 9.5)
            {
                Console.WriteLine("La calificación obtenida es Excelente");
            }
            else if (nota >= 8.5)
            {
                Console.WriteLine("La calificación obtenida es Muy Buena");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("La calificación obtenida es Buena");
            }
            else
            {
                Console.WriteLine("La calificación obtenida es Deficiente");
            }

            Console.WriteLine("----------------------------------------");
        }
        else
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("La entrada no es válida. Por favor, ingrese una nota válida.");
            Console.WriteLine("----------------------------------------");

            // AUTOEVALUACION 10 U20230466
        }
    }
}
