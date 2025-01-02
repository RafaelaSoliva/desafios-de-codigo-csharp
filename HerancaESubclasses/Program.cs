using System;

// Classe Personagem
class Personagem
{
    // Declaração de propriedades
    public string Nome { get; set; }
    public int Mana { get; set; }

    // Construção da classe
    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

// Classe especializada de Personagem (nome feito propositalmente, de acordo com o desafio)
class Subclasse : Personagem
{   
    // Declaração de propriedades
    public int DanoBase { get; set; }

    // Construção da classe
    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    // Método para calcular o dano
    public void CalcularDano()
    {
        Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
    }
}

// Runnable
class Program
{
    static void Main()
    {
        // Entrada de dados
        string nome = Console.ReadLine();
        int mana = int.Parse(Console.ReadLine());
        int danoBase = int.Parse(Console.ReadLine());

        // Cria o objeto personagem
        Subclasse personagem = new Subclasse(nome, mana, danoBase);

        // Retorna ao usuário o resultado da ação
        personagem.CalcularDano();
    }
}