namespace Listas
{
    partial class FormPilha
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SenhaGeradaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.removerButton = new System.Windows.Forms.Button();
            this.UltimaSenhaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garagem Profunda";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SenhaGeradaTextBox
            // 
            this.SenhaGeradaTextBox.Location = new System.Drawing.Point(71, 136);
            this.SenhaGeradaTextBox.Name = "SenhaGeradaTextBox";
            this.SenhaGeradaTextBox.ReadOnly = true;
            this.SenhaGeradaTextBox.Size = new System.Drawing.Size(165, 27);
            this.SenhaGeradaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ultima Veiculo Gerada:";
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.Location = new System.Drawing.Point(68, 81);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(168, 29);
            this.AdicionarButton.TabIndex = 5;
            this.AdicionarButton.Text = "&Estacionar";
            this.AdicionarButton.UseVisualStyleBackColor = true;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(509, 81);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(145, 29);
            this.removerButton.TabIndex = 7;
            this.removerButton.Text = "&Remover Ultimo";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // UltimaSenhaTextBox
            // 
            this.UltimaSenhaTextBox.Location = new System.Drawing.Point(509, 136);
            this.UltimaSenhaTextBox.Name = "UltimaSenhaTextBox";
            this.UltimaSenhaTextBox.ReadOnly = true;
            this.UltimaSenhaTextBox.Size = new System.Drawing.Size(165, 27);
            this.UltimaSenhaTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ultimo veiculo a sair";
            // 
            // FormPilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 233);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UltimaSenhaTextBox);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.AdicionarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SenhaGeradaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormPilha";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private ImageList imageList1;
        private TextBox SenhaGeradaTextBox;
        private Label label2;
        private Button AdicionarButton;
        private Button removerButton;
        private TextBox UltimaSenhaTextBox;
        private Label label4;
    }
}