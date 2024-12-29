// O objetivo é a simulação de um Sistema de Gerenciamento de Tarefas.
// O programa deve receber o título e a descrição de uma tarefa e, caso a descrição não ultrapasse 50 caracteres,
// deve retornar a descrição e a data de vencimento da tarefa.

using System;

class Program
{
    static void Main()
    {

      // Declaração de variáveis
      string titulo;
      string descricao;
      string dataVencimento;
        
      // Obtém o titulo e a descricao a partir da entrada do console  
      titulo = Console.ReadLine();
      descricao = Console.ReadLine();

      // Estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres
      if (descricao.Length <= 50) {
        dataVencimento = Console.ReadLine();
        Console.WriteLine($"{descricao} ate {dataVencimento}");
        } else {
        Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        }
        
    }
}