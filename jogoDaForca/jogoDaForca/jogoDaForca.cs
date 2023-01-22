using System;
using System.Security.Cryptography.X509Certificates;

namespace atividade
{
    class jogoDaForca
    {
        static void Main(string[] args)
        {
            palavraMisteriosa game = new palavraMisteriosa();
            game.constructor();
            do
            {      
                Console.WriteLine($"Tentativas restantes: {game.condicaoErro}");
                Console.WriteLine("Insita a letra");
                string letra = Convert.ToString(Console.ReadLine());

                game.vazio(letra);

                Console.WriteLine("Precione enter para continuar");
                Console.ReadLine();
                Console.Clear();

                if (game.condicaoVitoria >= game.palavra.Length)
                {
                    Console.WriteLine("Parabéns, Palavra correta");
                    Environment.Exit(1);
                }
            } while (game.condicaoErro > 0);
            Console.WriteLine("Você perdeu");    
        }
    }
}