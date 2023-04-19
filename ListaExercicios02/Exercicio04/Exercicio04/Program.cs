namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {

            int horasPrimeiro, horasSegundo, valorHoraPrimeiro, valorHoraSegundo;

            Console.Write("Quantidade de horas de aula dadas pelo primeiro professor: ");
            horasPrimeiro = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora: R$");
            valorHoraPrimeiro = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de horas de aula dadas pelo segundo professor: ");
            horasSegundo = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora: R$");
            valorHoraSegundo = int.Parse(Console.ReadLine());

            double salarioPrimeiro, salarioSegundo;

            salarioPrimeiro = horasPrimeiro * valorHoraPrimeiro;
            salarioSegundo = horasSegundo * valorHoraSegundo;

            if (salarioPrimeiro > salarioSegundo) {
                Console.WriteLine("O primeiro professor tem o salário maior.");
            }
            else if (salarioPrimeiro < salarioSegundo) {
                Console.WriteLine("O segundo professor tem o salário maior.");
            }
            else {
                Console.WriteLine("Os dois professores tem salários iguais.");
            }
        }
    }
}