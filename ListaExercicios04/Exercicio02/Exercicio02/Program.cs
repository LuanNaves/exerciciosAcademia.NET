namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {
            int num;
            char escolha;

            for (; ; ) {

                for (; ; ) {
                    Console.Write("Digite um número inteiro positivo: ");
                    num = int.Parse(Console.ReadLine());

                    if (num < 1) {
                        Console.WriteLine("Valor inválido.");
                    }
                    else {
                        break;
                    }
                }
                Console.Write($"Números inteiros pares entre 1 e {num}: ");
                for (int i = 1; i < num; i++) {
                    if (i % 2 == 0) {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Deseja informar mais um número? (S/N)");
                escolha = char.Parse(Console.ReadLine().ToUpper());
                if (escolha == 'S') {
                    continue;
                }
                else if (escolha == 'N') {
                    break;
                }
                else {
                    Console.WriteLine("Valor inválido");
                    break;
                }
            }
        }
    }
}