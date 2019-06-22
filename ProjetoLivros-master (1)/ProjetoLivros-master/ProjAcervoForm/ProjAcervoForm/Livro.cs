using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAcervoForm
{
    class Livro
    {
        #region Atributos
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;
        #endregion

        #region Propriedades
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public List<Exemplar> Exemplares
        {
            get { return exemplares; }
        }
        #endregion

        #region Construtores
        public Livro(int isbn, string titulo,
            string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = new List<Exemplar>();
        }

        public Livro() : this(0, "", "", "")
        {
        }
        #endregion

        #region Métodos
        public void adicionarExemplar(Exemplar exemplar)
        {
            this.exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return this.exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int qtde = 0;
            foreach (Exemplar e in this.exemplares)
                if (e.disponivel())
                    qtde++;
            return qtde;
        }

        public int qtdeEmprestimos()
        {
            int qtde = 0;
            foreach (Exemplar e in this.exemplares)
                qtde += e.qtdeEmprestimos();
            return qtde;
        }

        public double percDisponibilidade()
        {
            if (this.qtdeExemplares() > 0)
                return (this.qtdeDisponiveis() * 100) / this.qtdeExemplares();
            else
                return 0;
        }

        public Exemplar pesquisarExemplar(Exemplar exemplar)
        {
            Exemplar exemplarAchado = new Exemplar();
            foreach (Exemplar e in this.exemplares)
                if (e.Tombo.Equals(exemplar.Tombo))
                    exemplarAchado = e;

            return exemplarAchado;
        }


        public override bool Equals(object obj)
        {
            return (this.isbn == ((Livro)obj).Isbn);
        }
        #endregion
    }
}
