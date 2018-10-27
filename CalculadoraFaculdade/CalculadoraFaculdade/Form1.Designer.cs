namespace CalculadoraFaculdade
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.adicao = new System.Windows.Forms.Button();
            this.mutiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(126, 39);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 3;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(126, 66);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 4;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(126, 95);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 5;
            // 
            // adicao
            // 
            this.adicao.Location = new System.Drawing.Point(457, 10);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(75, 23);
            this.adicao.TabIndex = 6;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // mutiplicacao
            // 
            this.mutiplicacao.Location = new System.Drawing.Point(418, 39);
            this.mutiplicacao.Name = "mutiplicacao";
            this.mutiplicacao.Size = new System.Drawing.Size(75, 23);
            this.mutiplicacao.TabIndex = 7;
            this.mutiplicacao.Text = "*";
            this.mutiplicacao.UseVisualStyleBackColor = true;
            this.mutiplicacao.Click += new System.EventHandler(this.mutiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(499, 39);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(75, 23);
            this.divisao.TabIndex = 8;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(457, 69);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(75, 23);
            this.subtracao.TabIndex = 9;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(550, 98);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 23);
            this.limpar.TabIndex = 10;
            this.limpar.Text = "limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.mutiplicacao);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button mutiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button limpar;
    }
}

