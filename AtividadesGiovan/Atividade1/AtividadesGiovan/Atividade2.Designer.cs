namespace AtividadesGiovan
{
    partial class Atividade2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnome = new System.Windows.Forms.Label();
            this.txtInsirirNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.AutoSize = true;
            this.txtnome.Location = new System.Drawing.Point(27, 32);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(103, 13);
            this.txtnome.TabIndex = 0;
            this.txtnome.Text = "INSIRA SEU NOME";
            // 
            // txtInsirirNome
            // 
            this.txtInsirirNome.Location = new System.Drawing.Point(30, 48);
            this.txtInsirirNome.Name = "txtInsirirNome";
            this.txtInsirirNome.Size = new System.Drawing.Size(258, 20);
            this.txtInsirirNome.TabIndex = 1;
            this.txtInsirirNome.TextChanged += new System.EventHandler(this.txtInsirirNome_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Atividade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInsirirNome);
            this.Controls.Add(this.txtnome);
            this.Name = "Atividade2";
            this.Text = "Atividade2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.TextBox txtInsirirNome;
        private System.Windows.Forms.Button button1;
    }
}