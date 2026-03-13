namespace Q2
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
            lbCotacao = new Label();
            txtCotacao = new TextBox();
            lbQuantidade = new Label();
            txtDolares = new TextBox();
            btnConverter = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lbCotacao
            // 
            lbCotacao.AutoSize = true;
            lbCotacao.Location = new Point(36, 42);
            lbCotacao.Name = "lbCotacao";
            lbCotacao.Size = new Size(104, 15);
            lbCotacao.TabIndex = 0;
            lbCotacao.Text = "Cotação em dolar:";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(175, 39);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(152, 23);
            txtCotacao.TabIndex = 1;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(36, 84);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(133, 15);
            lbQuantidade.TabIndex = 2;
            lbQuantidade.Text = "Quantidade em dolares:";
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(164, 81);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(152, 23);
            txtDolares.TabIndex = 3;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(36, 127);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(166, 23);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Firebrick;
            lblResultado.Location = new Point(222, 123);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 253);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtDolares);
            Controls.Add(lbQuantidade);
            Controls.Add(txtCotacao);
            Controls.Add(lbCotacao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCotacao;
        private TextBox txtCotacao;
        private Label lbQuantidade;
        private TextBox txtDolares;
        private Button btnConverter;
        private Label lblResultado;
    }
}
