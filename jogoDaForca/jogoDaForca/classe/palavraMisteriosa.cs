using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Xml.Serialization;

public class palavraMisteriosa
{
	public string palavra = "programacao";
    public char auxiliar = 'a';
    public char letra;
    public int condicaoErro = 5, condicaoVitoria = 0;
    public char[] testeChar;

   
    public void constructor()
    {
        testeChar = new char[palavra.Length];
        for (int cont = 0; cont < palavra.Length; cont++)
        {
            testeChar[cont] = '_';
        }

        Console.WriteLine($"A palavra possui {palavra.Length} caracteres");

        for (int cont = 0; cont < palavra.Length; cont++)
        {
            Console.Write(testeChar[cont]);
        }

        Console.WriteLine("O jogo começará em:");
        for (int cont = 3; cont > 0; cont--)
        {
            Console.WriteLine(cont);
            Thread.Sleep(500);
        }
        Console.Clear();
    }
    public void vazio(string palavraUsuario)
	{
        int contaux = 0;
        condicaoErro--; 

        if (verificarLetra(palavraUsuario, palavra, contaux))
        {
            condicaoErro++;  
            for (int cont = 0; cont < palavra.Length; cont++) 
			{
                auxiliar = palavra[cont];
               
                if (auxiliar.Equals(letra))
                {
                    testeChar[cont] = letra;
                    condicaoVitoria++;
                    continue;
                }
            }
            for (int cont = 0; cont < palavra.Length; cont++)
            {
                Console.Write(testeChar[cont]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int cont = 0; cont < palavra.Length; cont++)
            {
                Console.Write(testeChar[cont]);
            }
            Console.WriteLine();
        }
	}

	bool verificarLetra(string palavraUsuario, string palavraCorreta, int cont)
	{
		bool verificarcao = false;
			
		for(int cont1 = 0; cont1 < palavraCorreta.Length; cont1++)
		{
			auxiliar = palavraCorreta[cont1];
            if (palavraUsuario[cont].Equals(auxiliar))
            {
               letra = palavraCorreta[cont1];
                verificarcao = true;
            }
        }
		return verificarcao;
	}
}

