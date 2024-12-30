// O objetivo é calcular a soma dos números pares em um intervalo específico.

using System;

class Program
{
    static void Main()
    {
        // Recebe os limites inferiores e superiores
        int limiteInferior = int.Parse(Console.ReadLine());
        int limiteSuperior = int.Parse(Console.ReadLine());

        // Variável para acumular a soma dos números pares
        int somaPares = 0;

        // Loop para percorrer os números no intervalo e os somar
        for (int i = limiteInferior; i <= limiteSuperior; i++) {
          if (i % 2 == 0) {
          somaPares = somaPares + i;
          }
        }    
  
      // Retorna o resultado para o usuário
      Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}