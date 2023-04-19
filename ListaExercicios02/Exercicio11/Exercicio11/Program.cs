namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite uma hora (HH:MM): ");
            string horario = Console.ReadLine();

            int horas = int.Parse(horario.ToString().Substring(0, 2));
            int minutos = int.Parse(horario.ToString().Substring(3, 2));

            if (horas > 23 || minutos > 59) {
                Console.WriteLine("Horário inválido");
            }
            else {
                Console.WriteLine("Horário válido");
            }

        }
    }
}