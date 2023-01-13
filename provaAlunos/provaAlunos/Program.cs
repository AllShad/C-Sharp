using System;
using System.Threading;

namespace atividade
{
    class ProvaAlunos 
    {
        static void matriz() 
        {
            PerguntasRespostas perguntasRespostas = new PerguntasRespostas();
            int incrementação = 0;
            int acertoAluno = 0;
            int contPerguntas = 0;
            

            for (int cont = 0; cont < 5 ; cont++)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do aluno");
                perguntasRespostas.matriz[cont, 0] = Convert.ToString(Console.ReadLine());

                for (int cont1 = 1; cont1 < 10 ; cont1++ )
                {
                   
                    Console.WriteLine(perguntasRespostas.perguntas[contPerguntas]);
                    perguntasRespostas.matriz[cont, cont1] = Convert.ToString(Console.ReadLine());

                    if (perguntasRespostas.matriz[cont, cont1].Equals(perguntasRespostas.respostas[contPerguntas]))
                    {
                        acertoAluno++;
                    }
                    contPerguntas++;
                }
                Console.WriteLine("");
                perguntasRespostas.notaAluno[cont] = acertoAluno;
                incrementação++;
                acertoAluno = 0;
                contPerguntas = 0;
            }
            Menu(perguntasRespostas);
        }

        static void VizualizarRespostas(PerguntasRespostas perguntasRespostas)
        {
            Console.Clear();
            for (int cont = 0; cont < 5; cont++)
            {
                Console.WriteLine(perguntasRespostas.matriz[cont, 0]);
                for (int cont1 = 1; cont1 < 10; cont1++)
                {
                    Console.WriteLine(perguntasRespostas.matriz[cont, cont1]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Digite algo para continuar");
            Console.ReadLine();
            Menu(perguntasRespostas);
        }

        static void VizualizarResultado(PerguntasRespostas perguntasRespostas)
        {
            Console.Clear();
            for (int cont = 0; cont < 5; cont++)
            {
                Console.Write($"{perguntasRespostas.matriz[cont, 0]}   {perguntasRespostas.notaAluno[cont]}\n");
            }
            Console.WriteLine("Digite algo para continuar");
            Console.ReadLine();
            Menu(perguntasRespostas);
        }

        static void Menu(PerguntasRespostas perguntasRespostas)
        {
            Console.Clear();
            int escolhaMenu;
            Console.WriteLine("[1]Vizualizar notas\n" +
                              "[2]Vizualizar respostas dos alunos\n" +
                              "[3]Sair");
            escolhaMenu = Convert.ToInt32(Console.ReadLine());

            switch (escolhaMenu)
            {
                case 1:
                    VizualizarResultado(perguntasRespostas);
                    break;
                case 2:
                    VizualizarRespostas(perguntasRespostas);
                    break;
                case 3:
                    Environment.Exit(1);
                    break;
                default:
                    Menu(perguntasRespostas);
                    break;
            }

        }
        static void Main (string[] args)
        {
            matriz();
        }
    }
}
