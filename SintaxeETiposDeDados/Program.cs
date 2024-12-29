// O objetivo é desenvolver uma solução simulando o registro de usuário em uma aplicação. 
// O usuário deve informar o email e o nome de usuário e a aplicação deve retornar uma mensagem de confirmação.

using System;

class Program
{
    static void Main(string[] args)
    {

      // Declaração de variáveis
      string email;
      string nomeUsuario;
      string senha;

      // Obtém o email e nome do usuário a partir da entrada do console
      email = Console.ReadLine();
      nomeUsuario = Console.ReadLine();

      // Retorno para o usuário
      Console.WriteLine($"{nomeUsuario}, verifique o email: {email} para ativar.");
      
    } 
}