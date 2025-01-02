using System;

// Classe Personagem
class Personagem
{
    // Declaração de propriedades
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    // Construção da classe
    public Personagem(string nome, string raca, string classe)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }
    
    // Método para exibir os dados do personagem
    public void ExibirStatus()
    {
        Console.WriteLine("Status:");
        Console.WriteLine("Nome:" + Nome);
        Console.WriteLine("Raça:" + Raca);
        Console.WriteLine("Classe:" + Classe);
        Console.WriteLine("Nível:" + Nivel);
        Console.WriteLine("Vida:" + Vida);
    }
}

// Runnable
class Program
{
    static void Main()
    {   
        // Entrada de dados
        string nome = Console.ReadLine();
        string raca = Console.ReadLine();
        string classe = Console.ReadLine();

        // Cria o objeto personagem
        Personagem personagem = new Personagem(nome, raca, classe);

        // Retorna os dados do personagem para o usuário
        personagem.ExibirStatus();
    }
}