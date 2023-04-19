namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {
            int[] vet1 = new int[20];
            int[] vet2 = new int[20];
            int[] soma = new int[20];

            for (int i = 0; i < vet1.Length; i++) {
                Console.Write($"Valor da posição {i} do vetor 1: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vet1.Length; i++) {
                Console.Write($"Valor da posição {i} do vetor 2: ");
                vet2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet1.Length; i++) {
                soma[i] = vet1[i] + vet2[i];
            }
            
            for (int i = 0; i < soma.Length; i++) {
                Console.Write(soma[i] + " ");
            }
        }
    }
}