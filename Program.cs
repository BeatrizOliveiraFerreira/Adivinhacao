using System.Diagnostics.Metrics;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(0, 1000);
            
            int tentativas = 0;
            Console.WriteLine($"Digite um número entre 0 e 1000");
            int chute = int.Parse(Console.ReadLine());

            while (tentativas < 15 && chute != numeroSecreto) {
                chute = int.Parse(Console.ReadLine());
                if (chute == numeroSecreto) {
                    Console.WriteLine("Acertou");
                    break;
                }
                else if (chute > numeroSecreto) {
                    Console.WriteLine("Errou ... o número secreto é menor do que " + chute);
                }
                else if (chute < numeroSecreto) {
                    Console.WriteLine("Errou... o número secreto é maior" + chute);
                }
                tentativas++;
            }

            if (tentativas == 15) {
                Console.WriteLine($"Você perdeu! O número secreto era {numeroSecreto}");
            }

        }
    }
}