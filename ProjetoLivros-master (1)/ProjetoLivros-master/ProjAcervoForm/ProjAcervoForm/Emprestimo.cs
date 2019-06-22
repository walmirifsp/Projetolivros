using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAcervoForm
{
    class Emprestimo
    {
        #region Atributos
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;
        #endregion

        #region Propriedades
        public DateTime DtEmprestimo
        {
            get { return dtEmprestimo; }
            set { dtEmprestimo = value; }
        }

        public DateTime DtDevolucao
        {
            get { return dtDevolucao; }
            set { dtDevolucao = value; }
        }
        #endregion

        #region Construtores
        public Emprestimo(DateTime dtEmprestimo, DateTime dtDevolucao)
        {
            this.dtEmprestimo = dtEmprestimo;
            this.dtDevolucao = dtDevolucao;
        }

        public Emprestimo()
            : this(new DateTime(), new DateTime())
        { }
        #endregion
    }
}
