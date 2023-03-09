namespace Listas
{
    partial class MenuPrincipalForm
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
            this.ListaButton = new System.Windows.Forms.Button();
            this.EncadeadaButton = new System.Windows.Forms.Button();
            this.PilhaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaButton
            // 
            this.ListaButton.Location = new System.Drawing.Point(50, 55);
            this.ListaButton.Name = "ListaButton";
            this.ListaButton.Size = new System.Drawing.Size(94, 29);
            this.ListaButton.TabIndex = 0;
            this.ListaButton.Text = "Lista";
            this.ListaButton.UseVisualStyleBackColor = true;
            this.ListaButton.Click += new System.EventHandler(this.ListaButton_Click);
            // 
            // EncadeadaButton
            // 
            this.EncadeadaButton.Location = new System.Drawing.Point(161, 55);
            this.EncadeadaButton.Name = "EncadeadaButton";
            this.EncadeadaButton.Size = new System.Drawing.Size(94, 29);
            this.EncadeadaButton.TabIndex = 1;
            this.EncadeadaButton.Text = "Fila";
            this.EncadeadaButton.UseVisualStyleBackColor = true;
            this.EncadeadaButton.Click += new System.EventHandler(this.EncadeadaButton_Click);
            // 
            // PilhaButton
            // 
            this.PilhaButton.Location = new System.Drawing.Point(276, 55);
            this.PilhaButton.Name = "PilhaButton";
            this.PilhaButton.Size = new System.Drawing.Size(94, 29);
            this.PilhaButton.TabIndex = 2;
            this.PilhaButton.Text = "Pilha";
            this.PilhaButton.UseVisualStyleBackColor = true;
            this.PilhaButton.Click += new System.EventHandler(this.PilhaButton_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 202);
            this.Controls.Add(this.PilhaButton);
            this.Controls.Add(this.EncadeadaButton);
            this.Controls.Add(this.ListaButton);
            this.Name = "MenuPrincipalForm";
            this.Text = "Estrutura de Dados";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ListaButton;
        private Button EncadeadaButton;
        private Button PilhaButton;
    }
}