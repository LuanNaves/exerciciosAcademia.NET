namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)) {
                    Console.WriteLine("Valor invalido");
                    break;
                }
                else if (int.TryParse(nome, out int numero)) {
                    Console.WriteLine("Valor invalido");
                    break;
                }
                Console.Write("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade <= 0) {
                    Console.WriteLine("Valor invalido");
                    break;
                }
                Console.Write("Digite seu salário: R$");
                double salario = double.Parse(Console.ReadLine());
                if(salario <= 0) {
                    Console.WriteLine("Valor invalido");
                    break;
                }
                Console.WriteLine($"Valores informados: {nome}, {idade} anos, R${salario:F2}");

            }
        }
    }
}