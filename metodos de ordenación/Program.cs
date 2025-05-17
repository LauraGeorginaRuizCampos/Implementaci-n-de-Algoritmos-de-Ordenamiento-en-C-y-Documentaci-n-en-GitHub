using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_de_ordenación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenación ord = new Ordenación();
            int[] original = { 9, 3, 5, 1, 4 };
            int opcion;

            do
            {
                Console.WriteLine("===== MÉTODOS DE ORDENACIÓN =====");
                Console.WriteLine("1. Burbuja Menor");
                Console.WriteLine("2. Burbuja Mayor");
                Console.WriteLine("3. Burbuja con Señal");
                Console.WriteLine("4. Sacudida");
                Console.WriteLine("5. Inserción");
                Console.WriteLine("6. Inserción Binaria");
                Console.WriteLine("7. Selección");
                Console.WriteLine("8. Shell");
                Console.WriteLine("9. QuickSort");
                Console.WriteLine("10. HeapSort");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("❌ Entrada no válida.\n");
                    continue;
                }

                Console.WriteLine();

                int[] copia;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Burbuja Menor:");
                        copia = (int[])original.Clone();
                        ord.BurbujaMenor(copia);
                        break;
                    case 2:
                        Console.WriteLine("Burbuja Mayor:");
                        copia = (int[])original.Clone();
                        ord.BurbujaMayor(copia);
                        break;
                    case 3:
                        Console.WriteLine("Burbuja con Señal:");
                        copia = (int[])original.Clone();
                        ord.BurbujaSeñal(copia);
                        break;
                    case 4:
                        Console.WriteLine("Sacudida:");
                        copia = (int[])original.Clone();
                        ord.Sacudida(copia);
                        break;
                    case 5:
                        Console.WriteLine("Inserción:");
                        copia = (int[])original.Clone();
                        ord.Inserción(copia);
                        break;
                    case 6:
                        Console.WriteLine("Inserción Binaria:");
                        copia = (int[])original.Clone();
                        ord.InserciónBinaria(copia);
                        break;
                    case 7:
                        Console.WriteLine("Selección:");
                        copia = (int[])original.Clone();
                        ord.Selección(copia);
                        break;
                    case 8:
                        Console.WriteLine("Shell:");
                        copia = (int[])original.Clone();
                        ord.Shell(copia);
                        break;
                    case 9:
                        Console.WriteLine("QuickSort:");
                        copia = (int[])original.Clone();
                        ord.QuickSort(copia, 0, copia.Length - 1);
                        break;
                    case 10:
                        Console.WriteLine("HeapSort:");
                        copia = (int[])original.Clone();
                        ord.HeapSort(copia);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresiona ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (opcion != 0);
        }
    }
}


