using System;
using System.Security.Cryptography.X509Certificates;

namespace mediaFilme
{
    class atividade
    {
        public int data;
        public static void menu()
        {
            opiniao classe = new opiniao();
      
            Console.WriteLine("Coletor de opnião");
            Console.WriteLine("[1]Dar opnião");
            Console.WriteLine("[2]Sair");
            classe.escolhaMenu = Convert.ToInt32(Console.ReadLine());

            switch (classe.escolhaMenu)
            {
                case 1:
                    coletaOpniao();
                    break;
                case 2:
                    Environment.Exit(1);
                    break;
                default:
                    menu();
                    break;
            }

        }

        static void coletaOpniao()
        {
            opiniao dados = new opiniao();
            int idade;
            
            for(int i = 1; i <= 10; i++)
            {
                Console.Clear();

                Console.WriteLine("Digite seu nome");
                dados.nome = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Agora digite sua idade");
                idade = Convert.ToInt32(Console.ReadLine());

                dados.entrevistados += 1;

                Console.Clear();

                Console.WriteLine($"{dados.nome}, nos diga sua opinião a respeito do filme");
                Console.WriteLine("[1]Regular");
                Console.WriteLine("[2]Bom");
                Console.WriteLine("[3]Exelente");
                dados.escolhaOpiniao = Convert.ToInt32(Console.ReadLine());

                switch (dados.escolhaOpiniao)
                {
                    case 1:
                        dados.caso1 += 1;
                        dados.idadeTotal += idade;
                        break;
                    case 2:
                        dados.caso2 += 1;
                        break;
                    case 3:
                        dados.caso3 += 1;
                        break;
                }
            }

            string result = dados.result(dados);
            resultado(result);
        }
        static void resultado(string result)
        {
            Console.WriteLine(result);   
        }
        static void Main(string[] args)
        {   
            menu();
        }
    }
}