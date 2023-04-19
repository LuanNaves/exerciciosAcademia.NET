namespace Exercicio14 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[50];
            int codigo;

            Console.Write("Digite um código (0 - terminar o programa, 1 - ordem de entrada, 2 - ordem inversa): ");
            codigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros.Length; i++) {
                Console.Write($"Insira o {i + 1}º valor do vetor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            switch (codigo) {
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;
                case 1:
                    Console.Write("Ordem digitada:  | ");
                    for (int i = 0; i < numeros.Length; i++) {
                        Console.Write(numeros[i] + " | ");
                    }
                    break;
                case 2:
                    Console.Write("Ordem inversa: | ");
                    for (int i = numeros.Length - 1; i >= 0; i--) {
                        Console.Write(numeros[i] + " | ");
                    }
                    break;

            }
        }
    }
}