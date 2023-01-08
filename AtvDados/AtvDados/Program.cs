using System;

namespace dados
{
    class atividade
    {
        static void pergunta()
        {
            int escolha = 0;
            Console.WriteLine("Deseja jogar novamente?");
            Console.WriteLine("[1]SIM");
            Console.WriteLine("[2]NÃO");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    resultado();//chamar o main
                    break;
                case 2:
                    Environment.Exit(1);
                    break;
                default:
                    pergunta();
                    break;
            }
        }

        static string comparador(int dado1, int dado2)
        {
            string comp;
           
            if (dado1 > dado2)
            {
                comp = ("O primeiro dado alcançou um resultado maior ");
            }
            else if(dado1 < dado2)
            {
                comp = ("O segundo alcançou um resultado maior ");
            }
            else
            {
                comp = ("Ambos os dados são iguais");
            }

            return comp;
        }
        static void resultado()
        {
            Console.Clear();
            Random alearorio = new Random();
            int dado1 = alearorio.Next(1, 6);
            int dado2 = alearorio.Next(1, 6);
            string result = ($"O valor do primeiro dado é {dado1}.\nO valor do segundo dado é {dado2}.");
            Console.WriteLine(result);
            Console.WriteLine(comparador(dado1,dado2));
            pergunta();
        }
        static void Main(string[] args)
        {
            resultado();
        }
    }
}