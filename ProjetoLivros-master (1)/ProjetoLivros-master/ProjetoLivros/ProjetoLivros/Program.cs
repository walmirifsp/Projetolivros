using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Program
    {
        static Livros lvs = new Livros();
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine("|               Menu                 |");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| 0.Sair                             |");
                Console.WriteLine("| 1.Adicionar livro                  |");
                Console.WriteLine("| 2.Pesquisar livro(sintético)       |");
                Console.WriteLine("| 3.Pesquisar livro(analítico)       |");
                Console.WriteLine("| 4.Adicionar exemplar               |");
                Console.WriteLine("| 5.Registrar empréstimo             |");
                Console.WriteLine("| 6.Registrar devolução              |");
                Console.WriteLine("--------------------------------------");
                Console.Write("Selecione uma opcao: ");
                op = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (op)
                {
                    case 0:
                        Console.Write("Programa Finalizado ! ! ! ! ");
                        break;
                    case 1: // adicionar
                        adicionarLivro();
                        break;
                    case 2: // livro (sintético)*
                        listaSintetica();
                        break;

                    case 3: // Pesquisar livro(analítico)
                        listaAnalitica();
                        break;

                    case 4: // adicionar exemplar 
                        adicionarExemplar();
                        break;

                    case 5:// Registrar empréstimo
                        registrarEmprestimo();
                        break;

                    case 6: // Registrar Devolução
                        registrarDevolucao();
                        break;
                    default:
                        Console.Write("Opção Invalida. Digite Novamente ! ! ! !");
                        break;

                }//fim switch

            } while (op != 0);
            
            Console.ReadKey();
        }// fim man

        static void adicionarLivro()
        {
            int isbnA;
            string titulo;
            string autor;
            string editora;

            Console.WriteLine("\n Adicionar Livro . . .  ");
            Console.Write("Insira o Isbn do Livro:  ");
            isbnA = int.Parse(Console.ReadLine());
            ////////// pesquisar se ja existi algum produto com o mesmo cod/
            ////////// if sim -> nao continua,  else continua
            if (lvs.pesquisar(new Livro(isbnA)) != null) throw new Exception("Já existe um livro com esse ISBN");
            Console.Write("Insira a Titulo: ");
            titulo = Console.ReadLine();
            Console.Write("Insira a Autor:  ");
            autor = Console.ReadLine();
            Console.Write("Insira a Editora: ");
            editora = Console.ReadLine();
            lvs.adicionar(new Livro(isbnA, titulo, autor, editora));
            Console.WriteLine("Exemplar cadastrado com sucesso!");
        }

        static void listaSintetica()
        {
            Console.Write("informe o ISBN: ");
            int isbnB = int.Parse(Console.ReadLine());
            Livro livro = lvs.pesquisar(new Livro(isbnB));
            if (livro == null) throw new Exception("Livro não encontrado.");

            Console.WriteLine("Total de exemplares: " + livro.qtdeExemplares());
            Console.WriteLine("Total de exemplares disponíveis: " + livro.qtdeDisponivel());
            Console.WriteLine("Total de empréstimos: " + livro.qtdeEmprestimos());
            Console.WriteLine("Percentual de disponibilidade: " + livro.percDisponibilidade().ToString("0.00") + "%");
        }

        static void listaAnalitica()
        {
            Console.Write("\nDigite o ISBN: ");
            int isbn = Int32.Parse(Console.ReadLine());
            Livro livroB = lvs.pesquisar(new Livro(isbn));
            if (livroB == null) throw new Exception("Livro não encontrado.");

            Console.WriteLine("Total de exemplares: " + livroB.qtdeExemplares());
            Console.WriteLine("Total de exemplares disponíveis: " + livroB.qtdeDisponivel());
            Console.WriteLine("Total de empréstimos: " + livroB.qtdeEmprestimos());
            Console.WriteLine("Percentual de disponibilidade: " + livroB.percDisponibilidade().ToString("0.00") + "%");

            livroB.Exemplares.ForEach(i => {
                Console.WriteLine("=========================================================");
                Console.WriteLine("Tombo: " + i.Tombo);
                i.Emprestimos.ForEach(j => {
                    String devolucao = (j.DtDevolucao != DateTime.MinValue) ? j.DtDevolucao.ToString() : "-------------------";
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Data Empréstimo: " + j.DtEmprestimo);
                    Console.WriteLine("Data Devolução:  " + devolucao);
                });
            });
        }

        static void adicionarExemplar()
        {
            Console.Write("\nDigite o ISBN: ");
            int isbnC = Int32.Parse(Console.ReadLine());

            Livro livroC = lvs.pesquisar(new Livro(isbnC));
            if (livroC == null) { throw new Exception("Livro não encontrado."); Console.ReadKey(); }

            Console.Write("Digite o Tombo: ");
            int tombo = Int32.Parse(Console.ReadLine());
            livroC.adicionarExemplar(new Exemplar(tombo));
            Console.WriteLine("Exemplar cadastrado com sucesso!");
            Console.ReadKey();
        }
        static void registrarEmprestimo()
        {
            Console.Write("\nDigite o ISBN: ");
            int isbnD = Int32.Parse(Console.ReadLine());

            Livro livroD = lvs.pesquisar(new Livro(isbnD));
            if (livroD == null) throw new Exception("Livro não encontrado.");

            Exemplar exemplar = livroD.Exemplares.FirstOrDefault(i => i.emprestar());
            if (exemplar != null) Console.WriteLine("Exemplar " + exemplar.Tombo + " emprestado com sucesso!");
            else throw new Exception("Não há exemplares disponíveis.");


        }
        static void registrarDevolucao()
        {
            Console.Write("\nDigite o ISBN: "); 
            int isbnE = Int32.Parse(Console.ReadLine());

            Livro livroE = lvs.pesquisar(new Livro(isbnE));
            if (livroE == null) throw new Exception("Livro não encontrado.");

            Exemplar exemplarE = livroE.Exemplares.FirstOrDefault(i => i.devolver());
            if (exemplarE != null) Console.WriteLine("Exemplar " + exemplarE.Tombo + " devolvido com sucesso!");
            else Console.WriteLine("Não há exemplares emprestados.");

        }

    }//fim class
}
