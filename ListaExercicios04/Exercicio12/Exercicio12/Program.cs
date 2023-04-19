using System.Runtime.Serialization;

namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {
            int soma = 0;
            for (int i = 1; i <= 100 ; i++) {
                soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}