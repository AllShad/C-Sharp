using System;

namespace atividade
{
    class cartelaBingo
    {
        static void menu(geracartela cartela)
        {
            int escolha = 0;
            Console.Clear();
            Console.WriteLine("Opções:\n" +
                              "[1]Grar Cartela\n" +
                              "[2]Sair");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    cartela.cartela();
                    menu(cartela);
                    break;
                case 2:
                    Environment.Exit(1);
                    break;
                default:
                    menu(cartela);
                    break;
            }
        }
        static void Main(string[] args)
        {
            geracartela cartela = new geracartela();
            menu(cartela);           
        }
    }
}