using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

namespace atividade
{
    class principal
    {
        static void menuPrincipal(verificacao verificarSenha)
        {
            
            Console.WriteLine("Seja bem vindo!\n" +
                              "Estamos carregando algumas informações, aguarde um instante");

            for(int load = 1; load <= 3; load++)
            {
                Console.Write(".");
                Thread.Sleep(800);
            }

            Console.Clear();

            digitacao(verificarSenha);
        }

        static void digitacao(verificacao verificarSenha)
        {
            int retorno;
            verificarSenha.tentativa = false;

            Console.WriteLine("Para ter acesso, digite a senha");
            verificarSenha.senhaDigitada = Convert.ToString(Console.ReadLine());

            if (verificarSenha.senhaDigitada.Length < 8)
            {
                verificarSenha.tentativa = false;
                Console.WriteLine("Senha inferior a 8 caracteres, tente novamente");
                digitacao(verificarSenha);
            }

            retorno = verificarSenha.retornoSenha();

            if (retorno == 1)
            {
                Console.WriteLine($"Senha incorreta, tentativas restantes: {verificarSenha.Tentativas}");
                digitacao(verificarSenha);
            }
            else if(retorno == 2)
            {
                Console.Clear();
                Console.WriteLine("Acesso Concedido");
                for (int load = 1; load <= 3; load++)
                {
                    Console.Write(".");
                    Thread.Sleep(800);
                }
            }
        }

        static void Main(string[] args)
        {
            verificacao verificarSenha = new verificacao();
            menuPrincipal(verificarSenha);
        }
    }
}
