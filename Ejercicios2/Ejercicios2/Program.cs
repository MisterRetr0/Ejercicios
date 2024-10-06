using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] numeros = new int[3, 4];

        for (int i = 0; i < 3; i++)
        {

            for (int j = 0; j < 4; j++)
            {
                // Solicitar la entrada al usuario
                Console.Write($"Ingrese el número de la posición [{i}, {j}] (entre 20 y 50 y par): ");
                int x;

                // Bucle para validar la entrada
                while (true)
                {
                    // Intenta leer la entrada del usuario
                    string input = Console.ReadLine();

                    // Intenta convertir la entrada a un entero
                    if (int.TryParse(input, out x) && x >= 20 && x <= 50 && x % 2 == 0)
                    {
                        // Asignar el valor a la matriz
                        numeros[i, j] = x;
                        break; // Si es válido, salimos del bucle
                    }
                    else
                    {
                        // Si no es válido, mostramos un mensaje de error
                        Console.Write("Entrada no válida. Por favor ingrese un número par entre 20 y 50: ");
                    }
                }
            }
        }

        // Imprimir la matriz
        Console.WriteLine("\nElementos de la matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(numeros[i, j] + " "); 
            }
            Console.WriteLine(); // Nueva línea después de cada fila
        }

        SumarFilas(numeros);
        PromediarColumnas(numeros);
    }

    // Función para sumar cada fila
    static void SumarFilas(int[,] matriz)
    {
        Console.WriteLine("\nSuma de cada fila:");
        Console.WriteLine("");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int suma = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma += matriz[i, j];
            }
            Console.WriteLine($"Suma de la fila {i + 1}: {suma}");
        }
    }

    // Función para calcular el promedio de cada columna
    static void PromediarColumnas(int[,] matriz)
    {
        Console.WriteLine("\nPromedio de cada columna:");
        Console.WriteLine("");
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            double suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma += matriz[i, j];
            }
            double promedio = suma / matriz.GetLength(0);
            Console.WriteLine($"Promedio de la columna {j + 1}: {promedio}");
        }
    }
}
