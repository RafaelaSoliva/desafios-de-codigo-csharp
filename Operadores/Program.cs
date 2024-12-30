// O objetivo é a simulação de um Sistema de Gerenciamento de Tarefas.

using System;

class Program
{
    static void Main()
    {
      // Declaração de variáveis
      string titulo;
      string descricao;
      string dataVencimento;
        
      // Recebe o titulo e a descrição da tarefa
      titulo = Console.ReadLine();
      descricao = Console.ReadLine();

      // Estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres
      if (descricao.Length <= 50) {
        // Recebe a data de vencimento da tarefa
        dataVencimento = Console.ReadLine();
        // Retorna para o usuário a tarefa e sua data de vencimento
        Console.WriteLine($"{descricao} ate {dataVencimento}");
        } else {
        Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        }
    }
}