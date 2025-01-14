﻿// O objetivo é calcular a pegada de carbono de um usuário com base em informações fornecidas.

using System;

class Program
{
    static void Main()
    {
        // Recebe o nome do usuário, quilômetros percorridos por dia, 
        // horas de uso de eletrônicos por dia e o número de refeições com carne:
        string nome = Console.ReadLine();
        double quilometrosPorDia = double.Parse(Console.ReadLine());
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // Retorna o resultado para o usuário
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa
        Console.ReadLine();
    }

        // Função para calcular a pegada de carbono com base nos parâmetros fornecidos
        static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne) {
            // Recebe os dados do usuário
            double transporte = quilometrosPorDia * 365 * 0.2;
            double eletronicos = horasDeEletronicos * 0.1;
            double consumoDeCarne = refeicoesComCarne * 0.5;

            // Calcula a pegada de carbono
            double pegadaDeCarbono = transporte + eletronicos + consumoDeCarne;
            return pegadaDeCarbono;
    }
}