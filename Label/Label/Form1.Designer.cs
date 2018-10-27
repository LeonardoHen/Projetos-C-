namespace Label
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
            this.lbltext = new System.Windows.Forms.Label();
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltext.Location = new System.Drawing.Point(220, 143);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(124, 15);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Nenhum botao apertado";
            // 
            // botao1
            // 
            this.botao1.Location = new System.Drawing.Point(159, 44);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(75, 23);
            this.botao1.TabIndex = 1;
            this.botao1.Text = "botao1";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botao2
            // 
            this.botao2.Enabled = false;
            this.botao2.Location = new System.Drawing.Point(346, 44);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(75, 23);
            this.botao2.TabIndex = 2;
            this.botao2.Text = "botao2";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(246, 90);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 23);
            this.apagar.TabIndex = 3;
            this.apagar.Text = "apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Visible = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.lbltext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button apagar;
    }
}

