namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {
            char repetir;
            string input;
            int num;
            while (true) {
                Console.Write("Digite um número inteiro: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out num)) {
                    if (num % 2 == 0) {
                        Console.WriteLine("O número digitado é par.");
                    }
                    else {
                        Console.WriteLine("O número digitado é impar.");
                    }
                }
                else {
                    Console.WriteLine("O valor digitado não é um número inteiro.");
                    continue;
                }
                while (true) {
                    Console.Write("Deseja repetir o programa (S/N)? ");
                    repetir = char.Parse(Console.ReadLine().ToUpper());
                    if (repetir != 'S' && repetir != 'N') {
                        Console.WriteLine("Valor inválido.");
                    }
                    else {
                        break;
                    }
                }
                if (repetir == 'S') {
                    continue;
                }
                else {
                    break;
                }
            }
        }
    }
}