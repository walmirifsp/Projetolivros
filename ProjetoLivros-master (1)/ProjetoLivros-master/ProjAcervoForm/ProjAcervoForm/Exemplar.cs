using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAcervoForm
{
    class Exemplar
    {
        #region Atributos
        private int tombo;
        private List<Emprestimo> emprestimos;
        #endregion

        #region Propriedades
        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }

        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
        }
        #endregion

        #region Construtores
        public Exemplar(int tombo)
        {
            this.tombo = tombo;
            this.emprestimos = new List<Emprestimo>();
        }

        public Exemplar()
            : this(0)
        {
        }
        #endregion

        #region Métodos
        public bool emprestar()
        {
            bool podeEmprestar;
            podeEmprestar = this.disponivel();
            if (podeEmprestar)
                this.emprestimos.Add(new Emprestimo(DateTime.Now, new DateTime()));
            return podeEmprestar;
        }

        public bool devolver()
        {
            bool podeDevolver;
            podeDevolver = !this.disponivel();
            if (podeDevolver)
                this.emprestimos[this.qtdeEmprestimos() - 1].DtDevolucao = DateTime.Now;
            return podeDevolver;
        }

        public bool disponivel()
        {
            return (this.qtdeEmprestimos() == 0 ||
                this.emprestimos[this.qtdeEmprestimos() - 1].DtDevolucao > DateTime.MinValue);
        }

        public int qtdeEmprestimos()
        {
            return this.emprestimos.Count;
        }

        public override bool Equals(object obj)
        {
            return (this.tombo.Equals(((Exemplar)obj).Tombo));
        }

        #endregion
    }
}
