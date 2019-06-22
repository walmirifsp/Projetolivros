using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public List<Exemplar> Exemplares { get { return this.exemplares; } }

        public Livro(int i) { this.isbn = i; }
        //public Livro()
        //{
        //    this.isbn = 0;
        //    this.titulo = "";
        //    this.autor = "";
        //    this.editora = "";
        //    this.exemplares = new List<Exemplar>();
        //}

        public Livro(int a, string b, string c, string d/*, List<Exemplar> e*/)
        {
            this.isbn = a;
            this.titulo = b;
            this.autor = c;
            this.editora = d;
            this.exemplares = new List<Exemplar>();
        }
/*
        public int Isbn {   get { return this.isbn; }   set { this.isbn = value; } }
        public string Titulo {  get { return this.titulo; }     set { this.titulo = value; } }
        public String Autor {get { return this.autor; }set { this.autor = value; }}
        public String Editora{get { return this.editora; }set { this.editora = value; } }
        public List<Exemplar> Exemplares {get { return this.exemplares; }set { this.exemplares = value; } }
*/
        public void adicionarExemplar(Exemplar p){

            //foreach (Exemplar exemp in this.exemplares)
            //    if (exemp.Equals(exemplar)) throw new Exception("Já existe um exemplar com este tombo.");
            //this.exemplares.Add(exemplar);

            // Exemplares é uma lista de Exemplar
            this.exemplares.Add(p);
        }

        public int qtdeExemplares()
        {
            return this.exemplares.Count();
        }

        public int qtdeDisponivel()
        {
            // desenvolver a logica que verifica qntos Exemplares da List<Exemplar> tem o atributo Emprestimo.dtDevolução;
            // e retornar a qntidade total de livros que nao tem
           // return
            int disponiveis = 0;
            this.exemplares.ForEach(item => { if (item.disponivel()) disponiveis++; });
            return disponiveis;
        }

        public int qtdeEmprestimos()
        {
            //    // desenvolver a logica que verifica qntos Exemplares da List<Exemplar> tem o atributo Emprestimo.dtEmprestimo;
            //    // e retornar a qntidade total de livros que tem
            //    return 
            int emprestados = 0;
            this.exemplares.ForEach(item => emprestados += item.qtdeEmprestimos());
            return emprestados;
        }

        public double percDisponibilidade()
        {
            //desenvolver uma logica que 
            double exemp = this.qtdeExemplares();
            double disp = this.qtdeDisponivel();
            return (exemp == 0 || disp == 0) ? 0 : (disp / exemp) * 100;

          //  return //qtdeExemplares() / qtdeDisponivel();
    }

        public override bool Equals(object obj)
        {
            //   return this.isbn == ((Livro)obj).isbn;
            if (obj.GetType() == this.GetType())
                return this.isbn.Equals(((Livro)obj).isbn);
            return false;
        }

    }
}
