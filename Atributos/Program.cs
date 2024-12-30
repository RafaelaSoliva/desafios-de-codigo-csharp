// O objetivo é criar um programa que contenha o objeto jogador e o retorne para o usuário

using System;

class Jogador
{
    // Declaração de propriedades
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    // Construção da classe com retorno para o usuário
    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;

        Console.WriteLine("Jogador criado!");
        Console.WriteLine(Nome);
        Console.WriteLine(Nacionalidade);
        Console.WriteLine(Idade);
        Console.WriteLine($"Posição: {Posicao}");
    }
}

// Runnable
class Program
{
    static void Main()
    {
        // Entrada de dados
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        string posicao = Console.ReadLine();

        // Instancia a classe Jogador
        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);
    }
}