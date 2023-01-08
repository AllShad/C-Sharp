using mediaFilme;
using System;

public class opiniao
{
    public int idadeTotal,entrevistados, escolhaOpiniao, escolhaMenu,caso1,caso2,caso3;
    public double porcentagem;
    public string nome;

    public string result(opiniao dados)
    {
        Console.Clear();

        string resultado;
     
        if (idadeTotal != 0)
        {
            idadeTotal = idadeTotal / caso1;
        }

        porcentagem = (caso3 * 100) / entrevistados;

        resultado =
            ($"A média de idade de telespectadores que responderam exlente é {idadeTotal}\n" +
             $"A quantidade de telespectadores que respondeu regular é {caso2}\n"            +
             $"A porcentagem de telespectadores que respondeu bom é de {porcentagem}%"       );

        return resultado;
    }
}
