using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese la cantidad de elementos del arreglo A: ");
            int n = int.Parse(Console.ReadLine());

                int[] A = new int[n];
                int[] B = new int[n];
                int contadorB = 0;
                
                Random NumeroRandom = new Random();
                for (int i = 0; i < n; i++)
                {
                    A[i] = NumeroRandom.Next(1, 1001);
                    int sumaDigitos = sumadeDigitos(A[i]);

                    if (sumaDigitos == 7)
                    {
                        B[contadorB] = A[i];
                        contadorB++;
                    }
                }
                Console.WriteLine("\nArreglo A: ");

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == A[0])
                    {
                        Console.Write(A[i]);
                    }
                    else
                    {
                        Console.Write(", " + A[i]);
                    }
                }

                Console.WriteLine("\n\nArreglo B: ");

                for (int i = 0; i < contadorB; i++)
                {
                    if (B[i] == B[0])
                    {
                        Console.Write(B[i]);
                    }
                    else
                    {
                        Console.Write(", " + B[i]);
                    }
                }

                int sumab = 0;
                for (int i = 0; i < contadorB; i++)
                {
                    sumab += B[i];
                }

                int numeroMayor = B[0];
                for (int i = 1; i < contadorB; i++)
                {
                    if (B[i] > numeroMayor)
                    {
                        numeroMayor = B[i];
                    }
                }


                int numeroMenor = B[0];
                for (int i = 1; i < contadorB; i++)
                {
                    if (B[i] < numeroMenor)
                    {
                        numeroMenor = B[i];
                    }
                }

                int promedio = 0;
                for (int i = 0; i < contadorB; i++)
                {
                    promedio += B[i];

                }

                float promedio2 = (float)promedio / (float)contadorB;


                Console.WriteLine("\n\nLa suma es: " + sumab);
                Console.WriteLine("El promedio es: " + promedio2);
                Console.WriteLine("El numero mayor es: " + numeroMayor);
                Console.WriteLine("El numero menor es: " + numeroMenor);
                Console.ReadKey();
        }

        public static int sumadeDigitos(int numero)
        {
            int suma = 0;
            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }
            return suma;
        }

    }
}
