using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivoPOO {
    internal class Persistencia {
        public static void lerArquivoParaTela(string nomeArquivo) {
            try {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do {
                    Console.WriteLine(leitor.ReadLine());
                } while (!leitor.EndOfStream);
                leitor.Close();
            } catch (Exception) {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void lerArquivosExibeNomes(string nomeArquivo) {
            try {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                do {
                    vetorLinha = leitor.ReadLine().Split(";");
                    Console.WriteLine(vetorLinha[0]);
                } while (!leitor.EndOfStream);
                leitor.Close();
            } catch(Exception) {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista) {
            try {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                do {
                    vetorLinha = leitor.ReadLine().Split(";");
                    lista.Add(new Pessoa(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            } catch(Exception) {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void exibirLista(List<Pessoa> lista) {
            foreach (var item in lista) {
                Console.WriteLine(item);
            }
        }

        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo) {
            try {
                StreamWriter escritor = new StreamWriter(nomeArquivo);

                foreach (var item in lista) {
                    escritor.WriteLine(item.Nome + ";" + item.Email + ";" + item.DataNascimento);
                    escritor.Flush();
                }

                escritor.Close();
            } catch (Exception) {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void atualizarPessoaArquivo(Pessoa pessoa, string nomeArquivo) {
            try {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email + ";" + pessoa.DataNascimento);

                escritor.Close();
            } catch(Exception) {
                Console.WriteLine("Problemas com arquivo");
            }

        }
    }
}
