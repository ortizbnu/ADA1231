namespace Listas
{
    partial class FormLista
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
            this.TamanhoListaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.IniciarButton = new System.Windows.Forms.Button();
            this.ValorFilaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoListaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TamanhoListaNumericUpDown
            // 
            this.TamanhoListaNumericUpDown.Location = new System.Drawing.Point(71, 43);
            this.TamanhoListaNumericUpDown.Name = "TamanhoListaNumericUpDown";
            this.TamanhoListaNumericUpDown.Size = new System.Drawing.Size(100, 27);
            this.TamanhoListaNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamanho Lista";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // IniciarButton
            // 
            this.IniciarButton.Location = new System.Drawing.Point(177, 41);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(94, 29);
            this.IniciarButton.TabIndex = 2;
            this.IniciarButton.Text = "&Iniciar";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // ValorFilaTextBox
            // 
            this.ValorFilaTextBox.Location = new System.Drawing.Point(71, 136);
            this.ValorFilaTextBox.Name = "ValorFilaTextBox";
            this.ValorFilaTextBox.Size = new System.Drawing.Size(100, 27);
            this.ValorFilaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira Valor";
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.Location = new System.Drawing.Point(177, 134);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(94, 29);
            this.AdicionarButton.TabIndex = 5;
            this.AdicionarButton.Text = "&Adicionar";
            this.AdicionarButton.UseVisualStyleBackColor = true;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(346, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 6;
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(502, 41);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(94, 29);
            this.removerButton.TabIndex = 7;
            this.removerButton.Text = "&Remover";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insira Valor de Busca";
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(572, 134);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(100, 27);
            this.BuscarTextBox.TabIndex = 8;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(678, 132);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 29);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "&Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 197);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AdicionarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValorFilaTextBox);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TamanhoListaNumericUpDown);
            this.Name = "FormLista";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.TamanhoListaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown TamanhoListaNumericUpDown;
        private Label label1;
        private ImageList imageList1;
        private Button IniciarButton;
        private TextBox ValorFilaTextBox;
        private Label label2;
        private Button AdicionarButton;
        private ListBox listBox1;
        private Button removerButton;
        private Label label3;
        private TextBox BuscarTextBox;
        private Button BuscarButton;
    }
}