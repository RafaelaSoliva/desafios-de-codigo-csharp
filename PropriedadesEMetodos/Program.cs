// O objetivo é controlar a velocidade de um robô, respeitando os seus limites de velocidade.

using System;

// Classe Robo
class Robo {
    // Declaração de propriedades
    public int VelocidadeMinima { get; set; }
    public int VelocidadeMaxima { get; set; }
    public int VelocidadeAtual { get; set; }

    // Construção da classe
    public Robo(int min, int max) {
        VelocidadeMinima = min;
        VelocidadeMaxima = max;
        VelocidadeAtual = min;
    }

    // Métodos para controlar a velocidade
    public void Acelerar() {
        if (VelocidadeAtual < VelocidadeMaxima) {
            VelocidadeAtual ++;
        }
    }

    public void Desacelerar() {
        if (VelocidadeAtual > VelocidadeMinima) {
            VelocidadeAtual --;
        }
    }

    public int Controlar (string comandos) {
        foreach (char comando in comandos) {
            if (comando == 'A') {
                Acelerar();
            } else if (comando == 'D') {
                Desacelerar();
            }
        }

        return VelocidadeAtual;
    }
}

// Runnable
class Program {
    static void Main() {
        // Entrada de dados
        int velocidadeMinima = int.Parse(Console.ReadLine());
        int velocidadeMaxima = int.Parse(Console.ReadLine());
        string comandos = Console.ReadLine();

        // Cria o objeto Robo
        Robo robo = new Robo(velocidadeMinima, velocidadeMaxima);
        
        // Controla a velocidade do robo
        int velocidadeAtual = robo.Controlar(comandos);

        // Retorna ao usuário
        Console.WriteLine(velocidadeAtual);
    }
}