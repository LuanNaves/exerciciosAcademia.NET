namespace Exercicio09 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira os valores de glicemia em jejum");
            Console.Write("Primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());
            if (primeiroValor < 65) {
                Console.WriteLine("Risco de hipoglicemia.");
            }
            else if (primeiroValor > 250) {
                Console.WriteLine("Risco de hiperglicemia.");
            }
            else {
                Console.WriteLine("Glicemia dentro do valor aceitavel.");
            }
            Console.Write("Segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());
            if (segundoValor < 65) {
                Console.WriteLine("Risco de hipoglicemia.");
            }
            else if (segundoValor > 250) {
                Console.WriteLine("Risco de hiperglicemia.");
            }
            else {
                Console.WriteLine("Glicemia dentro do valor aceitavel.");
            }
            Console.Write("Terceiro valor: ");
            double terceiroValor = double.Parse(Console.ReadLine());
            if (terceiroValor < 65) {
                Console.WriteLine("Risco de hipoglicemia.");
            }
            else if (terceiroValor > 250) {
                Console.WriteLine("Risco de hiperglicemia.");
            }
            else {
                Console.WriteLine("Glicemia dentro do valor aceitavel.");
            }
            Console.WriteLine();

            double media = (primeiroValor + segundoValor + terceiroValor) / 3;
            Console.WriteLine($"Media de glicemia: {media:F2}");

            if (media < 80) {
                Console.WriteLine("Diminuir 2 unidades de insulina.");
            }
            else if (media > 150) {
                Console.WriteLine("Adicionar 2 unidades de insulina.");
            }
            else {
                Console.WriteLine("Não há necessidade de alterar a medicação.");
            }

        }
    }
}