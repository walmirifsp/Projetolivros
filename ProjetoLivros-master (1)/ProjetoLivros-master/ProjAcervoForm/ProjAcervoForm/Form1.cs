using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjAcervoForm
{
    public partial class Form1 : Form
    {
        Livros livros;
        public Form1()
        {
            InitializeComponent();
            livros = new Livros();
        }

        private Livro pesquisar()
        {
            Livro lv = new Livro();
            lv.Isbn = int.Parse(txt_isbn.Text);
            lv = livros.pesquisar(lv);
            if (lv.Isbn > 0)
            {
                listBox1.Items.Add("Total de exemplares:" + lv.Exemplares.Count);
                listBox1.Items.Add("Total de exemplares disponíveis: " + lv.qtdeDisponiveis());
                listBox1.Items.Add("Total de emprestimo: " + lv.qtdeEmprestimos());
                listBox1.Items.Add("Percentual de disponibilidade: " + lv.percDisponibilidade());
            }
            else
            {
                listBox1.Items.Add("Livro não encontrado!");
            }
            return lv;
        } 

        private void Limpar()
        {
            txt_isbn.Visible = false;
            txt_isbn.Text = "";
            txt_autor.Visible = false;
            txt_autor.Text = "";
            txt_titulo.Visible = false;
            txt_titulo.Text = "";
            txt_editora.Visible = false;
            txt_editora.Text = "";
            txt_tombo.Text = "";
            txt_tombo.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;


            btn_add.Visible = false;
            btn_limpar.Visible = false;
            btn_sin.Visible = false;
            btn_an.Visible = false;
            btn_addEx.Visible = false;
            btn_emprestar.Visible = false;

            listBox1.Visible = false;
            listBox1.Items.Clear();
        
        }

        private void cv_Click(object sender, EventArgs e)
        {
            txt_isbn.Visible = true;
            label2.Visible = true;
            txt_autor.Visible = true;
            label5.Visible = true;
            txt_titulo.Visible = true;
            label4.Visible = true;
            txt_editora.Visible = true;
            label6.Visible = true;
            btn_add.Visible = true;
            label7.Text = "Informe o livro:";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            livros.adicionar(new Livro(Convert.ToInt16(txt_isbn.Text), 
                            txt_titulo.Text, txt_autor.Text, txt_editora.Text));

            MessageBox.Show("Livro adicionado com sucesso!");

            Limpar();
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            Livro li = pesquisar();
            listBox1.Items.Add("Tombo de exemplares: ");
            int x = 1;
            foreach (Exemplar exemp in li.Exemplares)
            {
              listBox1.Items.Add(x++ +"    "+ exemp.Tombo);
                foreach (Emprestimo emp in exemp.Emprestimos)
                {
                    listBox1.Items.Add($"Emprestado:  {emp.DtEmprestimo} | Devolvido: {emp.DtEmprestimo}");
                }
            }                 
            

        }

        private void btn_emprestar_Click(object sender, EventArgs e)
        {
            Livro lv = new Livro();
            lv.Isbn = int.Parse(txt_isbn.Text);

            Exemplar exemp = new Exemplar();

            if (lv.Isbn > 0)
            {
                if (exemp.Tombo > 0)
                {
                    if (exemp.emprestar() == true)
                    {
                        exemp.emprestar();
                        MessageBox.Show("emprestado");
                    }
                    else
                    {
                        MessageBox.Show("não emprestado");
                    }
                }
                else
                {
                    MessageBox.Show("tombo não encontrado");
                }
            }
            else
            {
                MessageBox.Show("livro não encontrado");
            }

            Limpar();
        }

        private void btn_pesqSin_Click(object sender, EventArgs e)
        {
            txt_isbn.Visible = true;
            label2.Visible = true;
            btn_sin.Visible = true;
            listBox1.Visible = true;
            btn_limpar.Visible = true;
            label7.Text = "Informe o livro:";

        }

        private void btn_pesqAnali_Click(object sender, EventArgs e)
        {
            txt_isbn.Visible = true;
            label2.Visible = true;
            btn_an.Visible = true;
            listBox1.Visible = true;
            btn_limpar.Visible = true;
            label7.Text = "Informe o livro:";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_addExem_Click(object sender, EventArgs e)
        {
            txt_isbn.Visible = true;
            label2.Visible = true;
            btn_addEx.Visible = true;
            txt_tombo.Visible = true;
            label3.Visible = true;
            label7.Text = "Adicionar exemplar de qual livro:";
        }

        private void btn_emprestimo_Click(object sender, EventArgs e)
        {
            txt_isbn.Visible = true;
            label2.Visible = true;
            txt_tombo.Visible = true;
            label3.Visible = true;
            btn_emprestar.Visible = true;
            txt_tombo.Visible = true;
            label7.Text = "Registrar emprestimo de qual livro:";
        }

        private void btn_addEx_Click(object sender, EventArgs e)
        {
            Livro livroPesquisado = new Livro();
            livroPesquisado.Isbn = int.Parse(txt_isbn.Text);
            livroPesquisado = livros.pesquisar(livroPesquisado);
            if (livroPesquisado.Isbn > 0)
            {
                Exemplar exemplar = new Exemplar();
                
                exemplar.Tombo = int.Parse(txt_tombo.Text);
                livroPesquisado.adicionarExemplar(exemplar);
                MessageBox.Show("Exemplar adicionado!");
            }
            else
            {
                MessageBox.Show("Livro não encontrado!");
            }

            Limpar();
        }

        private void btn_devolucao_Click(object sender, EventArgs e)
        {
            txt_isbn.Visible = true;
            label2.Visible = true;
            txt_tombo.Visible = true;
            label3.Visible = true;
            btn_emprestar.Visible = true;
            txt_tombo.Visible = true;
            label7.Text = "Registrar devolução de qual livro:";

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            Livro livroPesquisado = new Livro();

            livroPesquisado.Isbn = int.Parse(Console.ReadLine());
            livroPesquisado = livros.pesquisar(livroPesquisado);
            if (livroPesquisado.Isbn > 0)
            {
                Exemplar exemplarPesquisado = new Exemplar();
                exemplarPesquisado.Tombo = int.Parse(txt_tombo.Text);
                exemplarPesquisado = livroPesquisado.pesquisarExemplar(exemplarPesquisado);
                if (exemplarPesquisado.Tombo > 0)
                {
                    if (exemplarPesquisado.devolver())
                        MessageBox.Show("Devolução realizada com sucesso");
                    else
                        MessageBox.Show("Devolução não foi realizada");
                }
                else
                    MessageBox.Show("Exemplar não encontrado");
            }
            else
                MessageBox.Show("Livro não encontrado");
        }
    }
}
