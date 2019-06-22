using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

      //  private DateTime dtHj = DateTime.Now.Date;
      //  private string dtAgora = DateTime.Now.Date.ToString();

        public Emprestimo(DateTime a)
        {
            this.dtEmprestimo = a;           
        }


        public DateTime DtEmprestimo
        {
            get {return  this.dtEmprestimo; }
            set { this.dtEmprestimo = value; }  
        }

        public DateTime DtDevolucao
        {
            get { return this.dtDevolucao; }
            set { this.dtDevolucao = value; }
        }

    }// fim class
}
