using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[8]; 
        string numerosIngresados = ""; // Para almacenar los números en el orden de ingreso

        for (int i = 0; i < 8; i++)
        {
            // Solicitar la entrada al usuario
            Console.Write($"Ingrese el {i + 1} número (entre 3 y 6): ");
            int x;

            // Bucle para validar la entrada
            while (true)
            {
                // Intenta leer la entrada del usuario
                string input = Console.ReadLine();

                // Intenta convertir la entrada a un entero
                if (int.TryParse(input, out x) && x >= 3 && x <= 6)
                {
                    // Si es válido, salimos del bucle
                    break;
                }
                else
                {
                    // Si no es válido, mostramos un mensaje de error
                    Console.Write("Entrada no válida. Por favor ingrese un número entre 3 y 6: ");
                }
            }

            // Asignar el número al arreglo
            numeros[i] = x;

            // Añadir el número a la cadena de números ingresados
            numerosIngresados += x + " ";
        }

        // Mostrar los números ingresados en el orden de ingreso
        Console.WriteLine("Números ingresados:");
        Console.WriteLine(numerosIngresados.Trim()); // Trim para eliminar el espacio final

        // Impresión de números con potencias
        ContarRepeticionesYPotencias(numeros);
    }

    static void ContarRepeticionesYPotencias(int[] arreglo)
    {
        // Arreglo para contar repeticiones (solo para números entre 3 y 6)
        int[] contador = new int[4]; // Índices 0 a 3 corresponden a números 3 a 6

        // Contar las repeticiones
        for (int i = 0; i < arreglo.Length; i++)
        {
            // Aumentar el contador correspondiente
            contador[arreglo[i] - 3]++;
        }

        // Imprimir los resultados
        Console.WriteLine("Repeticiones y potencias de números en el arreglo:");
        for (int i = 0; i < contador.Length; i++)
        {
            if (contador[i] > 0)
            {
                int numero = i + 3; // Ajustar índice para obtener el número original
                int repeticiones = contador[i];
                // Calcular la potencia
                int potencia = (int)Math.Pow(numero, repeticiones);
                Console.WriteLine($"El número {numero} se repite {repeticiones} veces y su potencia es {potencia}.");
            }
        }
    }
}
