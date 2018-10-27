namespace Calculadora
{
    partial class frmCalculadora
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
            this.btadicao = new System.Windows.Forms.Button();
            this.btsubtracao = new System.Windows.Forms.Button();
            this.btmultiplicacao = new System.Windows.Forms.Button();
            this.btdivisao = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btadicao
            // 
            this.btadicao.Location = new System.Drawing.Point(209, 27);
            this.btadicao.Name = "btadicao";
            this.btadicao.Size = new System.Drawing.Size(75, 23);
            this.btadicao.TabIndex = 0;
            this.btadicao.Text = "+";
            this.btadicao.UseVisualStyleBackColor = true;
            this.btadicao.Click += new System.EventHandler(this.btadicao_Click);
            // 
            // btsubtracao
            // 
            this.btsubtracao.Location = new System.Drawing.Point(209, 57);
            this.btsubtracao.Name = "btsubtracao";
            this.btsubtracao.Size = new System.Drawing.Size(75, 23);
            this.btsubtracao.TabIndex = 1;
            this.btsubtracao.Text = "-";
            this.btsubtracao.UseVisualStyleBackColor = true;
            this.btsubtracao.Click += new System.EventHandler(this.btsubtracao_Click);
            // 
            // btmultiplicacao
            // 
            this.btmultiplicacao.Location = new System.Drawing.Point(209, 87);
            this.btmultiplicacao.Name = "btmultiplicacao";
            this.btmultiplicacao.Size = new System.Drawing.Size(75, 23);
            this.btmultiplicacao.TabIndex = 2;
            this.btmultiplicacao.Text = "*";
            this.btmultiplicacao.UseVisualStyleBackColor = true;
            this.btmultiplicacao.Click += new System.EventHandler(this.btmultiplicacao_Click);
            // 
            // btdivisao
            // 
            this.btdivisao.Location = new System.Drawing.Point(209, 117);
            this.btdivisao.Name = "btdivisao";
            this.btdivisao.Size = new System.Drawing.Size(75, 23);
            this.btdivisao.TabIndex = 3;
            this.btdivisao.Text = "/";
            this.btdivisao.UseVisualStyleBackColor = true;
            this.btdivisao.Click += new System.EventHandler(this.btdivisao_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(42, 27);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(42, 70);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 5;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(42, 97);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 6;
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Location = new System.Drawing.Point(42, 9);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(40, 13);
            this.lblv1.TabIndex = 7;
            this.lblv1.Text = "Valor 1";
            this.lblv1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.Location = new System.Drawing.Point(42, 50);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(40, 13);
            this.lblv2.TabIndex = 8;
            this.lblv2.Text = "Valor 2";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 253);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btdivisao);
            this.Controls.Add(this.btmultiplicacao);
            this.Controls.Add(this.btsubtracao);
            this.Controls.Add(this.btadicao);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora v 1.0";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btadicao;
        private System.Windows.Forms.Button btsubtracao;
        private System.Windows.Forms.Button btmultiplicacao;
        private System.Windows.Forms.Button btdivisao;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
    }
}

