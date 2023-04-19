namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Qual a sua altura? (em metros) ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Qual é o seu peso? (em kg) ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Olá {nome}");
            Console.Write($"Seu IMC é de {imc:F2}, você está com ");
            if (imc < 18 ) {
                Console.WriteLine("baixo peso.");
            }
            else if (imc >= 18 && imc < 25 ) {
                Console.WriteLine("peso normal.");
            }
            else if (imc >= 25 && imc < 30) {
                Console.WriteLine("sobrepeso.");
            }
            else if (imc >= 30 && imc < 35) {
                Console.WriteLine("obesidade.");
            }
            else {
                Console.WriteLine("obesidade grau sério.");
            }
        }
    }
}