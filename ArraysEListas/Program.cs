// O objetivo é criar um catálogo de jogos que permita ao usuário adicionar uma quantidade específica de jogos.

using System;

class Program
{
    static void Main()
    {
        // Recebe a quantidade de jogos a ser adicionada
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // Inicializa os arrays com base na quantidade informada pelo usuário
        string[] nomesJogos = new string[quantidadeJogos];
       
        // Loop para adicionar jogos conforme a quantidade especificada
        for (int indice = 0; indice < quantidadeJogos; indice ++) {
          AdicionarJogo(indice, nomesJogos);
        }

        // Retorna para o usuário o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    // Métodos
    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Recebe os nomes dos jogos
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        // String auxiliar para a saida de dados
        string saida = nomes[0];
        
        // Loop para adicionar os nomes dos jogos a string de saída
        for (int indice = 1; indice < quantidadeJogos; indice ++) {
          saida = saida + ", " + nomes[indice];
        }

        // Retorna para o usuário a operação realizada
        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {saida} ao catalogo.");
    }
}