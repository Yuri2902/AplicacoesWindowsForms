namespace Q4
{
    partial class lstTabuada
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
            lbNumero = new Label();
            txtNumero = new TextBox();
            listBox1 = new ListBox();
            btnGerar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(24, 61);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(54, 15);
            lbNumero.TabIndex = 0;
            lbNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(76, 58);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 214);
            listBox1.TabIndex = 2;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(185, 57);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 3;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 23);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 4;
            label1.Text = "faça sua tabuada aqui";
            // 
            // lstTabuada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 389);
            Controls.Add(label1);
            Controls.Add(btnGerar);
            Controls.Add(listBox1);
            Controls.Add(txtNumero);
            Controls.Add(lbNumero);
            Name = "lstTabuada";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumero;
        private TextBox txtNumero;
        private ListBox listBox1;
        private Button btnGerar;
        private Label label1;
    }
}
