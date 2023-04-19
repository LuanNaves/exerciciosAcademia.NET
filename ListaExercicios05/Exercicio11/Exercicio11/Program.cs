namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++) {
                Console.Write($"Insira o {i + 1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Ordem digitada:  | ");
            for (int i = 0; i < numeros.Length; i++) {
                Console.Write(numeros[i] + " | ");
            }
            Console.WriteLine();
            Console.Write("Ordem inversa: | ");
            for (int i = numeros.Length - 1; i >= 0; i--) {
                Console.Write(numeros[i] + " | ");
            }
        }
    }
}