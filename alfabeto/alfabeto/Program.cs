using System;

namespace alfabeto
{
    class atividade
    {
        static void Main(string[] args)
        {
            char[] alfabeto = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char letra;

            Console.WriteLine("Insira uma letra");
            letra = Convert.ToChar(Console.ReadLine());

            letra = char.ToUpper(letra);
            
            for(int i = 0; i < alfabeto.Length; i++)
             {
                if(letra == alfabeto[i])
                {
                    Console.Clear();
                    for(int a = i; a < alfabeto.Length; a++)
                    {
                        Console.WriteLine(alfabeto[a]);
                    }
                }
             }
       
        }
    }
}
