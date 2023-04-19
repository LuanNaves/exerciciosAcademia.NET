namespace Exercicio19 {
    internal class Program {
        static void Main(string[] args) {
            double salario, somaSalario = 0, somaFilhos = 0, mediaSalario, maiorSalario = 0, mediaFilhos, porcSalarioAte100;
            int filhos, totalPessoas = 0, salarioAte100 = 0;
            do {
                Console.WriteLine("Informe seus dados");
                Console.Write("Salário: R$");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0) {
                    break;
                }
                Console.Write("Número de filhos: ");
                filhos = int.Parse(Console.ReadLine());

                somaSalario += salario;
                somaFilhos += filhos;


                if (salario > maiorSalario) {
                    maiorSalario = salario;
                }
                if (salario <= 100) {
                    salarioAte100++;
                }

                totalPessoas++;
            } while (true);

            mediaFilhos = somaFilhos / totalPessoas;
            mediaSalario = somaSalario / totalPessoas;
            porcSalarioAte100 = salarioAte100 * 100 / totalPessoas;

            Console.WriteLine("Dados coletado: ");
            Console.WriteLine($"Média do salário da população: R${mediaSalario:F2}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos}");
            Console.WriteLine($"Maior salário: R${maiorSalario:F2}");
            Console.WriteLine($"Percentual de pessoas com salário até R$ 100,00: {porcSalarioAte100}%");

        }
    }
}