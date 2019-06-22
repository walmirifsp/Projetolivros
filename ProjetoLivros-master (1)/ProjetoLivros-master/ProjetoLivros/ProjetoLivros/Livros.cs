using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Livros
    {
        private List<Livro> acervo;

        public List<Livro> Acervo { get { return this.acervo; } }

        public Livros()
        {
            this.acervo = new List<Livro>();
        }

        public void adicionar(Livro a)
        {
            this.acervo.Add(a);
            //            if (this.pesquisar(livro) != null) throw new Exception("Já existe um livro com esse ISBN.");
            //this.acervo.Add(livro);
        }

        public Livro pesquisar(Livro a)
        {
            // return this.acervo.FirstOrDefault(item => item.Equals(livro));

            // desenvolver a logica para buscar um livro no Acervo( List<Livro>)
            //foreach (Livro livro in this.acervo)
            //{
            //    if (livro.Equals(a))
            //        return livro;
            //}
            //return new Livro();

            return this.acervo.FirstOrDefault(item => item.Equals(a));

        }

    }// fim class
}
