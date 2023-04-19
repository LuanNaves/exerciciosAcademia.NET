using System.ComponentModel.DataAnnotations;

namespace Exercicio09 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[10];
            int[] ordenado = new int[10];
            bool troca = false;
            int aux;

            for (int i = 0; i < numeros.Length; i++) {
                Console.Write($"Insira o {i + 1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            ordenado = numeros.OrderBy(x => x).ToArray();

            Console.WriteLine("Em ordem crescente:");
            Console.Write("| ");
            for (int i = 0; i < ordenado.Length; i++) {
                Console.Write(ordenado[i] + " | ");
            }
        }
    }
}