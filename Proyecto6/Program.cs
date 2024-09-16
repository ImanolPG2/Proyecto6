using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arregloOrdenado = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.WriteLine("Arreglo ordenado:");
        ImprimirArreglo(arregloOrdenado);

        Console.Write("\nIngrese un número entero para buscar: ");
        if (int.TryParse(Console.ReadLine(), out int numeroBuscado))
        {
            bool encontrado = BusquedaBinariaTopDown(arregloOrdenado, numeroBuscado);

            if (encontrado)
            {
                Console.WriteLine($"El número {numeroBuscado} existe en el arreglo.");
            }
            else
            {
                Console.WriteLine($"El número {numeroBuscado} no existe en el arreglo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static bool BusquedaBinariaTopDown(int[] arreglo, int objetivo)
    {
        return BusquedaBinariaRecursiva(arreglo, objetivo, 0, arreglo.Length - 1);
    }

    static bool BusquedaBinariaRecursiva(int[] arreglo, int objetivo, int izquierda, int derecha)
    {
        if (izquierda > derecha)
        {
            return false;
        }

        int medio = izquierda + (derecha - izquierda) / 2;

        if (arreglo[medio] == objetivo)
        {
            return true;
        }
        if (objetivo < arreglo[medio])
        {
            return BusquedaBinariaRecursiva(arreglo, objetivo, izquierda, medio - 1);
        }

        return BusquedaBinariaRecursiva(arreglo, objetivo, medio + 1, derecha);
    }

    static void ImprimirArreglo(int[] arreglo)
    {
        foreach (int numero in arreglo)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}