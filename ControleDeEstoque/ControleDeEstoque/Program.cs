using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace atividade
{
    class principal
    {

        static void menu( List<produtos> listaProdutos)
        {
            Console.Clear();
            int escolha = 0;
            Console.WriteLine("O que deseja fazer?\n" + 
                "[1]Cadastrar Produto\n" + 
                "[2]Consultar Estoque\n" +
                "[3]Valor total em mercadorias\n" +
                "[4]Excluir mercadorias\n" + 
                "[5]Sair");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    cadastro(listaProdutos);
                    break;
                case 2:
                    estoque(listaProdutos);
                    break;
                case 3:
                    Console.WriteLine($"O valor tota é: ${valorTotal(listaProdutos)}\nPrecione qualquer tecla para continuar");
                    Console.ReadLine();
                    menu(listaProdutos);
                    break;
                case 4:
                    excluirProduto(listaProdutos);
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    menu( listaProdutos);
                    break;
            }
        }

        static void excluirProduto(List<produtos> listaproduto)
        {
            int indiceLista = 0;
            int indiceExclusao;
            foreach(produtos produto in listaproduto)
            {
                Console.WriteLine($"Indice:{indiceLista} Nome:{produto.nomeProduto} Quantidade: {produto.quantidadeProduto}");
                indiceLista += 1;
            }

            Console.WriteLine("De qual produto deseja excluir?");
            indiceLista = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantos itens deseja excluir?");
            indiceExclusao = Convert.ToInt32(Console.ReadLine());

            if(indiceExclusao >= listaproduto[indiceLista].quantidadeProduto)
            {
                listaproduto.RemoveAt(indiceLista);
            }
            else
            {
                listaproduto[indiceLista].quantidadeProduto -= indiceExclusao; 
            }

            Console.WriteLine("Item removido com sucesso");

            Thread.Sleep(2000);

            menu(listaproduto);
        }

        static void cadastro(List<produtos> listaProdutos)
        {
            produtos produtos = new produtos();
            Console.WriteLine("Digite as informações do produto\n" +
                              "Nome:");
            produtos.nomeProduto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Preço:");
            produtos.precoProduto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade");
            produtos.quantidadeProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Produto cadastrado");

            Thread.Sleep(500);

            listaProdutos.Add(produtos);

            menu(listaProdutos);
        }

        static double valorTotal(List<produtos> listaProdutos)
        {
            double valorTotal = 0;

            foreach (produtos produto in listaProdutos)
            {
                valorTotal += produto.precoProduto;
            }
            return valorTotal;
        }
        

        static void estoque(List<produtos> listaProdutos)
        {
            foreach(produtos produto in listaProdutos)
            {
                Console.WriteLine($"Nome: {produto.nomeProduto}, Quantidade: {produto.quantidadeProduto}, Preço R${produto.precoProduto}");
            }
            Console.WriteLine("Precione qualquer tecla para continuar");
            Console.ReadLine();
            menu(listaProdutos);
        }
        static void Main(string[] args)
        {
            List<produtos> listaProdutos = new List<produtos>();
            menu(listaProdutos);
        }
    }
}
