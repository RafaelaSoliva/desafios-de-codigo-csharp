// O objetivo é desenvolver uma solução simulando o registro de usuário em uma aplicação. 

using System;

class Program
{
    static void Main(string[] args)
    {
      // Declaração de variáveis
      string email;
      string nomeUsuario;
      string senha;

      // Recebe o email e nome do usuário a partir da entrada do console
      email = Console.ReadLine();
      nomeUsuario = Console.ReadLine();

      // Retorno para o usuário
      Console.WriteLine($"{nomeUsuario}, verifique o email: {email} para ativar."); 
    } 
}