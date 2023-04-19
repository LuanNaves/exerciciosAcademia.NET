namespace Exercicio21 {
    internal class Program {
        static void Main(string[] args) {
            int medidaEntrada, medidaSaida;
            double valorEntrada, valorSaida;
            Console.WriteLine("Digite a unidade de medida de entrada: ");
            Console.WriteLine("1 - para metros\n" +
                "2 - para centimetros\n" +
                "3 - para polegadas\n" +
                "4 - para pés");
            medidaEntrada = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a unidade de medida de saida: ");
            Console.WriteLine("1 - para metros\n" +
                "2 - para centimetros\n" +
                "3 - para polegadas\n" +
                "4 - para pés");
            medidaSaida = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor para conversão: ");
            valorEntrada = double.Parse(Console.ReadLine());
            valorSaida = 0;
            switch (medidaEntrada) {
                case 1:
                    switch (medidaSaida) {
                        case 1:
                            valorSaida = valorEntrada;
                            break;
                        case 2:
                            valorSaida = valorEntrada * 100;
                            break;
                        case 3:
                            valorSaida = valorEntrada * 39.37;
                            break;
                        case 4:
                            valorSaida = valorEntrada * 3.281;
                            break;
                        default:
                            Console.WriteLine("Valor de saída inválido.");
                            break;
                    }
                    break;
                case 2:
                    switch (medidaSaida) {
                        case 1:
                            valorSaida = valorEntrada / 100;
                            break;
                        case 2:
                            valorSaida = valorEntrada;
                            break;
                        case 3:
                            valorSaida = valorEntrada * 0.3937;
                            break;
                        case 4:
                            valorSaida = valorEntrada * 0.03281;
                            break;
                        default:
                            Console.WriteLine("Valor de saída inválido.");
                            break;
                    }
                    break;
                case 3:
                    switch (medidaSaida) {
                        case 1:
                            valorSaida = valorEntrada / 39.37;
                            break;
                        case 2:
                            valorSaida = valorEntrada / 0.3937;
                            break;
                        case 3:
                            valorSaida = valorEntrada;
                            break;
                        case 4:
                            valorSaida = valorEntrada / 0.08333;
                            break;
                        default:
                            Console.WriteLine("Valor de saída inválido.");
                            break;
                    }
                    break;
                case 4:
                    switch (medidaSaida) {
                        case 1:
                            valorSaida = valorEntrada / 3.281;
                            break;
                        case 2:
                            valorSaida = valorEntrada / 0.03281;
                            break;
                        case 3:
                            valorSaida = valorEntrada / 0.08333;
                            break;
                        case 4:
                            valorSaida = valorEntrada;
                            break;
                        default:
                            Console.WriteLine("Valor de saída inválido.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Valor de entrada inválido.");
                    break;
            }
            Console.WriteLine("Resultado: " + valorSaida);
        }
    }
}