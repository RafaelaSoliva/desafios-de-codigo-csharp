// O objetivo é receber dados em um objeto e os retornar ao usuário.

using System;

class Pessoa
{
    
    // Declaração de propriedades
    public string nome { get; set; }
    public int idade { get; set; }

    // Construção da classe
    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    // Métodos para obter o nome e a idade
    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}


// Runnable
class Program
{
    static void Main()
    {


        // Obtém o nome e a idade do usuário.
        string nome = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());

        // Instancia a classe pessoa
        Pessoa pessoa = new Pessoa(nome, idade);

        // Retorna ao usuário
        Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
    }
}