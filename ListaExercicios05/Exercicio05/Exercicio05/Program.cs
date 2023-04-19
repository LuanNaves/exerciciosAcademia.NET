namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[80];
            int menorNumero = 0, posicaoMenor = 0;

            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++) {
                if (i == 0) {
                    menorNumero = vetor[i];
                    posicaoMenor = i;
                }
                else if (vetor[i] < menorNumero) {
                    menorNumero = vetor[i];
                    posicaoMenor = i;
                }
            }
            Console.WriteLine($"Menor elemento digitado: {menorNumero}");
            Console.WriteLine($"Posição do menor elemento no vetor: {posicaoMenor}");

        }
    }
}