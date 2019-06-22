namespace ProjAcervoForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.Button();
            this.btn_pesqSin = new System.Windows.Forms.Button();
            this.btn_pesqAnali = new System.Windows.Forms.Button();
            this.btn_addExem = new System.Windows.Forms.Button();
            this.btn_emprestimo = new System.Windows.Forms.Button();
            this.btn_devolucao = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_editora = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_an = new System.Windows.Forms.Button();
            this.btn_emprestar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_tombo = new System.Windows.Forms.TextBox();
            this.btn_addEx = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que deseja fazer?";
            // 
            // cv
            // 
            this.cv.Location = new System.Drawing.Point(24, 77);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(118, 23);
            this.cv.TabIndex = 1;
            this.cv.Text = "Adicionar livro";
            this.cv.UseVisualStyleBackColor = true;
            this.cv.Click += new System.EventHandler(this.cv_Click);
            // 
            // btn_pesqSin
            // 
            this.btn_pesqSin.Location = new System.Drawing.Point(24, 121);
            this.btn_pesqSin.Name = "btn_pesqSin";
            this.btn_pesqSin.Size = new System.Drawing.Size(118, 23);
            this.btn_pesqSin.TabIndex = 2;
            this.btn_pesqSin.Text = "Pesquisa sintética *";
            this.btn_pesqSin.UseVisualStyleBackColor = true;
            this.btn_pesqSin.Click += new System.EventHandler(this.btn_pesqSin_Click);
            // 
            // btn_pesqAnali
            // 
            this.btn_pesqAnali.Location = new System.Drawing.Point(24, 162);
            this.btn_pesqAnali.Name = "btn_pesqAnali";
            this.btn_pesqAnali.Size = new System.Drawing.Size(118, 23);
            this.btn_pesqAnali.TabIndex = 3;
            this.btn_pesqAnali.Text = "Pesquisa analitíca **";
            this.btn_pesqAnali.UseVisualStyleBackColor = true;
            this.btn_pesqAnali.Click += new System.EventHandler(this.btn_pesqAnali_Click);
            // 
            // btn_addExem
            // 
            this.btn_addExem.Location = new System.Drawing.Point(24, 202);
            this.btn_addExem.Name = "btn_addExem";
            this.btn_addExem.Size = new System.Drawing.Size(118, 23);
            this.btn_addExem.TabIndex = 4;
            this.btn_addExem.Text = "Adicionar exemplar";
            this.btn_addExem.UseVisualStyleBackColor = true;
            this.btn_addExem.Click += new System.EventHandler(this.btn_addExem_Click);
            // 
            // btn_emprestimo
            // 
            this.btn_emprestimo.Location = new System.Drawing.Point(24, 241);
            this.btn_emprestimo.Name = "btn_emprestimo";
            this.btn_emprestimo.Size = new System.Drawing.Size(118, 23);
            this.btn_emprestimo.TabIndex = 5;
            this.btn_emprestimo.Text = "Registrar empréstimo";
            this.btn_emprestimo.UseVisualStyleBackColor = true;
            this.btn_emprestimo.Click += new System.EventHandler(this.btn_emprestimo_Click);
            // 
            // btn_devolucao
            // 
            this.btn_devolucao.Location = new System.Drawing.Point(24, 283);
            this.btn_devolucao.Name = "btn_devolucao";
            this.btn_devolucao.Size = new System.Drawing.Size(118, 23);
            this.btn_devolucao.TabIndex = 6;
            this.btn_devolucao.Text = "Registrar devolução";
            this.btn_devolucao.UseVisualStyleBackColor = true;
            this.btn_devolucao.Click += new System.EventHandler(this.btn_devolucao_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(24, 320);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(118, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair do programa";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(234, 155);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(100, 20);
            this.txt_isbn.TabIndex = 8;
            this.txt_isbn.Visible = false;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(234, 211);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_titulo.TabIndex = 9;
            this.txt_titulo.Visible = false;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(234, 268);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(100, 20);
            this.txt_autor.TabIndex = 10;
            this.txt_autor.Visible = false;
            // 
            // txt_editora
            // 
            this.txt_editora.Location = new System.Drawing.Point(234, 320);
            this.txt_editora.Name = "txt_editora";
            this.txt_editora.Size = new System.Drawing.Size(100, 20);
            this.txt_editora.TabIndex = 11;
            this.txt_editora.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(389, 132);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(564, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 212);
            this.listBox1.TabIndex = 13;
            this.listBox1.Visible = false;
            // 
            // btn_sin
            // 
            this.btn_sin.Location = new System.Drawing.Point(389, 164);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(127, 23);
            this.btn_sin.TabIndex = 14;
            this.btn_sin.Text = "Pesquisar *";
            this.btn_sin.UseVisualStyleBackColor = true;
            this.btn_sin.Visible = false;
            this.btn_sin.Click += new System.EventHandler(this.btn_sin_Click);
            // 
            // btn_an
            // 
            this.btn_an.Location = new System.Drawing.Point(389, 193);
            this.btn_an.Name = "btn_an";
            this.btn_an.Size = new System.Drawing.Size(128, 23);
            this.btn_an.TabIndex = 15;
            this.btn_an.Text = "Pesquisar **";
            this.btn_an.UseVisualStyleBackColor = true;
            this.btn_an.Visible = false;
            this.btn_an.Click += new System.EventHandler(this.btn_an_Click);
            // 
            // btn_emprestar
            // 
            this.btn_emprestar.Location = new System.Drawing.Point(389, 252);
            this.btn_emprestar.Name = "btn_emprestar";
            this.btn_emprestar.Size = new System.Drawing.Size(127, 23);
            this.btn_emprestar.TabIndex = 16;
            this.btn_emprestar.Text = "Emprestar";
            this.btn_emprestar.UseVisualStyleBackColor = true;
            this.btn_emprestar.Visible = false;
            this.btn_emprestar.Click += new System.EventHandler(this.btn_emprestar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(700, 332);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 17;
            this.btn_limpar.Text = "OK";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Visible = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_tombo
            // 
            this.txt_tombo.Location = new System.Drawing.Point(234, 103);
            this.txt_tombo.Name = "txt_tombo";
            this.txt_tombo.Size = new System.Drawing.Size(100, 20);
            this.txt_tombo.TabIndex = 18;
            this.txt_tombo.Visible = false;
            // 
            // btn_addEx
            // 
            this.btn_addEx.Location = new System.Drawing.Point(389, 223);
            this.btn_addEx.Name = "btn_addEx";
            this.btn_addEx.Size = new System.Drawing.Size(127, 23);
            this.btn_addEx.TabIndex = 19;
            this.btn_addEx.Text = "Adicionar exemplar";
            this.btn_addEx.UseVisualStyleBackColor = true;
            this.btn_addEx.Visible = false;
            this.btn_addEx.Click += new System.EventHandler(this.btn_addEx_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ISBN:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tombo:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Titulo:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Autor:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Editora:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(389, 281);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(127, 23);
            this.btn_devolver.TabIndex = 26;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Visible = false;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addEx);
            this.Controls.Add(this.txt_tombo);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_emprestar);
            this.Controls.Add(this.btn_an);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_editora);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_devolucao);
            this.Controls.Add(this.btn_emprestimo);
            this.Controls.Add(this.btn_addExem);
            this.Controls.Add(this.btn_pesqAnali);
            this.Controls.Add(this.btn_pesqSin);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cv;
        private System.Windows.Forms.Button btn_pesqSin;
        private System.Windows.Forms.Button btn_pesqAnali;
        private System.Windows.Forms.Button btn_addExem;
        private System.Windows.Forms.Button btn_emprestimo;
        private System.Windows.Forms.Button btn_devolucao;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_editora;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_sin;
        private System.Windows.Forms.Button btn_an;
        private System.Windows.Forms.Button btn_emprestar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_tombo;
        private System.Windows.Forms.Button btn_addEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_devolver;
    }
}

