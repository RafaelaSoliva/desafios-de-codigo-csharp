// O objetivo é criar um catálogo de jogos que permita ao usuário adicionar uma quantidade específica de jogos.

using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // Inicializa os arrays com base na quantidade informada pelo usuário:
        string[] nomesJogos = new string[quantidadeJogos];
       
        // Loop para adicionar jogos conforme a quantidade especificada:
        for (int indice = 0; indice < quantidadeJogos; indice ++) {
          AdicionarJogo(indice, nomesJogos);
        }

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }


    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        string saida = nomes[0];
        
        for (int indice = 1; indice < quantidadeJogos; indice ++) {
          saida = saida + ", " + nomes[indice];
        }

        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {saida} ao catalogo.");
    }
}