using System;
using System.Threading;

public class geracartela
{
	public void cartela()
	{
		int[,] cartelaBingo = new int[3, 3];
		Random numeroAleatorio = new Random();

        for (int cont = 0; cont < 3; cont++)
		{
			cartelaBingo[cont, 0] = numeroAleatorio.Next(1, 99);
			for (int cont1 = 1; cont1 < 3; cont1++)
			{
				cartelaBingo[cont, cont1] = numeroAleatorio.Next(1, 99);
            }
			Console.WriteLine("");
		}

		for(int cont = 0; cont < 3; cont++)
		{
			for(int cont1 = 0; cont1 < 3; cont1++)
			{
				if (cartelaBingo[cont, 0].Equals(cartelaBingo[cont, cont1]))
				{
					cartelaBingo[cont, 0] = numeroAleatorio.Next(1,99);
				}

                if (cartelaBingo[0, cont1].Equals(cartelaBingo[cont, cont1]))
                {
                    cartelaBingo[0, cont1] = numeroAleatorio.Next(1, 99);
                }
            }
		}

        for (int cont = 0; cont < 3; cont++)
        {
            Console.Write($" | {cartelaBingo[cont, 0]} |");
            Thread.Sleep(100);
            for (int cont1 = 1; cont1 < 3; cont1++)
            {              
                Console.Write($" | {cartelaBingo[cont, cont1]} |");
                Thread.Sleep(100);
            }
            Console.WriteLine("");
        }
		Console.WriteLine("Digite algo para continuar");
		Console.ReadLine();
    }
}
