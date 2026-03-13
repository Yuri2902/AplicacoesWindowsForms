namespace Q5
{
    partial class Form1
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
            lbNome = new Label();
            lbIdade = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            btnAdicionar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(73, 47);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.Location = new Point(73, 89);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(39, 15);
            lbIdade.TabIndex = 1;
            lbIdade.Text = "Idade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(165, 23);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(113, 86);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(165, 23);
            txtIdade.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(86, 115);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(182, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(86, 144);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 169);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 450);
            Controls.Add(listBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lbIdade);
            Controls.Add(lbNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNome;
        private Label lbIdade;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button btnAdicionar;
        private ListBox listBox1;
    }
}
