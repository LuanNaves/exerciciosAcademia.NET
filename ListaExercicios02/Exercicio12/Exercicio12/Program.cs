namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {

            int codigo, horasTrabalhadas;

            Console.Write("Código do operário: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Número de horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            double salario, extra;
            int horasExtra;

            if(horasTrabalhadas > 50) {
                horasExtra = horasTrabalhadas - 50;
                horasTrabalhadas -= horasExtra;
                salario = horasTrabalhadas * 10;
                extra = horasExtra * 20;
            }
            else {
                salario = horasTrabalhadas * 10;
                horasExtra = 0;
                extra = 0;
            }

            double salarioTotal = salario + extra;
            Console.WriteLine($"Salário total: {salarioTotal}");
            Console.WriteLine($"Valor excedente: {extra}");
        }
    }
}