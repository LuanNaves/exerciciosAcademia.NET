namespace Exercicio15 {
    internal class Program {
        static void Main(string[] args) {
            double nota, peso = 0, soma = 0, media, notaPonderada;
            for (int i = 0; i < 4; i++) {
                Console.WriteLine($"{i + 1}ª Nota: ");
                nota = double.Parse(Console.ReadLine());

                switch (i) {
                    case 0:
                        peso = 2;
                        break;
                    case 1:
                        peso = 1;
                        break;
                    case 2:
                        peso = 2;
                        break;
                    case 3:
                        peso = 4;
                        break;
                }
                notaPonderada = nota * peso;
                soma += notaPonderada;
            }
            media = soma / 9;
            Console.WriteLine($"Média: {media:F2}");
            if (media >= 7.0) {
                Console.WriteLine("Aprovado.");
            }
            else {
                Console.WriteLine("Reprovado.");
                Console.WriteLine("Média mínima para aprovação é 7.0");
            }
        }
    }
}