namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {
            double[] numeros = new double[10];
            double[] posicaoMenor0 = new double[10];
            int i, aux = 0;

            for (i = 0; i < numeros.Length; i++) {
                Console.Write($"Insira o {i + 1}º valor: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i < numeros.Length;i++) {
                if (numeros[i] < 0) {
                    posicaoMenor0[aux] = i + 1;
                    aux++;
                }
            }
            Console.Write("| ");
            for (i = 0; i < posicaoMenor0.Length; i++) {
                if (posicaoMenor0[i] != 0) {
                    Console.Write(posicaoMenor0[i] + " | ");
                }
            }
        }
    }
}