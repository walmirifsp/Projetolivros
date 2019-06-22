using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public Exemplar()
        {
            //this.tombo = 0;
            this.emprestimos = new List<Emprestimo>();
        }

        public Exemplar(int a/*, List<Emprestimo> b*/)
        {
            this.tombo = a;
            this.emprestimos = new List<Emprestimo>();
        }

        public int Tombo
        {
            get { return this.tombo; }
            set { this.tombo = value; }
        }

        public List<Emprestimo> Emprestimos
        {
            get { return this.emprestimos; }
            set { this.emprestimos = value; }
        }


        public bool emprestar()
        {
            if (this.disponivel())
            {
                this.emprestimos.Add(new Emprestimo(DateTime.Now));
                return true;
            }
            return false;
        }

        public bool devolver()
        {
            if (!this.disponivel())
            {
                this.emprestimos[this.emprestimos.Count - 1].DtDevolucao = DateTime.Now;
                return true;
            }
            return false;
        }

        public bool disponivel()
        {
            if (this.emprestimos.Count > 0)
                if (this.emprestimos[this.emprestimos.Count - 1].DtDevolucao == DateTime.MinValue)
                    return false;
            return true;
        }

        public int qtdeEmprestimos()
        {
            return emprestimos.Count();
        }

        public override bool Equals(Object obj)
        {
            if (obj.GetType() == this.GetType())
                return this.tombo == ((Exemplar)obj).Tombo;
            return false;
        }




    }//fim class
}
