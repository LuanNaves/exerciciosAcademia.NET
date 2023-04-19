namespace Exercicio13 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Qual é o seu sexo (M/F) ? ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Qual é a sua altura? (em metros) ");
            double altura = double.Parse(Console.ReadLine());

            double pesoIdeal;

            switch (sexo) {
                case 'M':
                    pesoIdeal = (72.7 * altura) - 58;
                    Console.WriteLine($"Seu peso ideal é {pesoIdeal}Kg");
                    break;
                case 'F':
                    pesoIdeal = (62.1 * altura) - 44.7;
                    Console.WriteLine($"Seu peso ideal é {pesoIdeal}Kg");
                    break;
                default:
                    Console.WriteLine("Sexo informado é inválido");
                    break;
            }

        }
    }
}