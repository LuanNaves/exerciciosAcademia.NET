using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivoPOO {
    internal class Crud {
        public static bool validaNome(string nome) {
            return true;
        }
        public static void cadastrar(List<Pessoa> lista, string nomeArquivo) {
            string nome;
            string dataNascimento;
            Pessoa pessoa;

            do {
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();
            } while (!validaNome(nome));

            Console.Write("Data de Nascimento: ");
            dataNascimento = Console.ReadLine();

            pessoa = new Pessoa(nome, dataNascimento);

            if (!lista.Contains(pessoa)) { 
                lista.Add(pessoa);
                Persistencia.atualizarPessoaArquivo(pessoa, nomeArquivo);
            }
            else {
                Console.WriteLine("Pessoa com este email já na base de dados");
            }

        }
        public static void exibirLista(List<Pessoa> lista) {
            foreach (var item in lista) {
                Console.WriteLine(item);
            }
        }
        public static void pesquisar(List<Pessoa> lista) {
            string email;
            Console.Write("Digite o email da pessoa que deseja pesquisar:");
            email = Console.ReadLine();
            foreach (var item in lista) {
                if (email == item.Email) {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
