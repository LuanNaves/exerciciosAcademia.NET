namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            int qtdPar = 0, qtdImpar = 0;
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++) {
                Console.Write($"Digite o valor da posição {i} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0 ) {
                    qtdPar++;
                }
                else {
                    qtdImpar++;
                }
            }
            Console.WriteLine("Dos números digitados: ");
            Console.WriteLine($"{qtdPar} são pares");
            Console.WriteLine($"{qtdImpar} são impares");
        }
    }
}