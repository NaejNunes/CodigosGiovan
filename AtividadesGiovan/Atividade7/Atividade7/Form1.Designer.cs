namespace Atividade7
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.btnGerarNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(33, 9);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(62, 13);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "NUMEROS\r";
            // 
            // btnGerarNumeros
            // 
            this.btnGerarNumeros.Location = new System.Drawing.Point(143, 29);
            this.btnGerarNumeros.Name = "btnGerarNumeros";
            this.btnGerarNumeros.Size = new System.Drawing.Size(135, 68);
            this.btnGerarNumeros.TabIndex = 1;
            this.btnGerarNumeros.Text = "GERAR NUMEROS";
            this.btnGerarNumeros.UseVisualStyleBackColor = true;
            this.btnGerarNumeros.Click += new System.EventHandler(this.btnGerarNumeros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarNumeros);
            this.Controls.Add(this.lblNumeros);
            this.Name = "Form1";
            this.Text = "GERAR NUMEROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Button btnGerarNumeros;
    }
}

