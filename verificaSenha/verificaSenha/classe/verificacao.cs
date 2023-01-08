using System;

public class verificacao
{
	private const string senha = "Aluno020";
	public string senhaDigitada;
	private int tentativas = 3;
    public bool tentativa;

    public int retornoSenha()
	{
        if ((senhaDigitada != senha) && (tentativa = true))
		{
			tentativas -= 1;
            if (tentativas == 0)
            {
                Console.WriteLine("Usuário Bloqueado!");
                for (int load = 1; load <= 3; load++)
                {
                    Console.Write(".");
                    Thread.Sleep(800);
                }
                Environment.Exit(1);
            }
            return 1;
		}

        return 2;    
	}	

    public int Tentativas
    {
        get { return tentativas; }
    }
}
