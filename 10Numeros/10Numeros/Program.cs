using System;

namespace Numeros
{
    class atividade
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];         
            int auxiliar = 0;

            for (int cont = 0; cont < numeros.Length; cont++)
            {
                Console.WriteLine("Digite um numero");
                numeros[cont] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }


            for (int cont = 0; cont < numeros.Length; cont++)
            {
                for(int cont1 = 0; cont1 < numeros.Length - 1; cont1++)
                {
                    if (numeros[cont1] > numeros[cont1 + 1])
                    {
                        auxiliar = numeros[cont1];
                        numeros[cont1] = numeros[cont1 + 1];
                        numeros[cont1 + 1] = auxiliar;
                                                  
                    }
                }
                
            }

            for (int cont = 0; cont < numeros.Length; cont++)
            {
                Console.WriteLine(numeros[cont]);
            }

        }

    }
}