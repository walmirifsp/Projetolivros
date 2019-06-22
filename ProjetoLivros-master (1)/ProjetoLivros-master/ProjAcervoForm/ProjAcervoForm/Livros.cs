using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAcervoForm
{
    class Livros
    {
        #region Atributos
        private List<Livro> acervo;
        #endregion

        #region Propriedade
        public List<Livro> Acervo
        {
            get { return acervo; }
        }
        #endregion

        #region Construtor
        public Livros()
        {
            this.acervo = new List<Livro>();
        }
        #endregion

        #region Métodos
        public void adicionar(Livro livro)
        {
            this.acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            Livro livroAchado = new Livro();
            foreach (Livro l in this.Acervo)
                if (l.Isbn.Equals(livro.Isbn))
                    livroAchado = l;

            return livroAchado;
        }
        #endregion
    }
}
