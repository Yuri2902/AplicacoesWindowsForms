namespace Hamburguer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lbSair = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnFazerPedidoProduto = new Button();
            txtPrecoProduto = new TextBox();
            txtNomeProduto = new TextBox();
            lbPrecoProduto = new Label();
            lbNomeProduto = new Label();
            lbCadastro = new Label();
            btnSalvarProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbSair
            // 
            lbSair.AutoSize = true;
            lbSair.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSair.ForeColor = Color.FromArgb(40, 39, 40);
            lbSair.Location = new Point(346, -1);
            lbSair.Name = "lbSair";
            lbSair.Size = new Size(41, 51);
            lbSair.TabIndex = 1;
            lbSair.Text = "X";
            lbSair.Click += lbSair_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(243, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnFazerPedidoProduto
            // 
            btnFazerPedidoProduto.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFazerPedidoProduto.ForeColor = Color.FromArgb(40, 39, 40);
            btnFazerPedidoProduto.Location = new Point(210, 191);
            btnFazerPedidoProduto.Name = "btnFazerPedidoProduto";
            btnFazerPedidoProduto.Size = new Size(154, 24);
            btnFazerPedidoProduto.TabIndex = 17;
            btnFazerPedidoProduto.Text = "Fazer Pedido";
            btnFazerPedidoProduto.UseVisualStyleBackColor = true;
            btnFazerPedidoProduto.Click += btnFazerPedidoProduto_Click;
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.Location = new Point(228, 130);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(136, 23);
            txtPrecoProduto.TabIndex = 16;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(8, 130);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(199, 23);
            txtNomeProduto.TabIndex = 15;
            // 
            // lbPrecoProduto
            // 
            lbPrecoProduto.AutoSize = true;
            lbPrecoProduto.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrecoProduto.ForeColor = Color.FromArgb(255, 163, 0);
            lbPrecoProduto.Location = new Point(228, 98);
            lbPrecoProduto.Name = "lbPrecoProduto";
            lbPrecoProduto.Size = new Size(146, 29);
            lbPrecoProduto.TabIndex = 14;
            lbPrecoProduto.Text = "Preço do Produto";
            // 
            // lbNomeProduto
            // 
            lbNomeProduto.AutoSize = true;
            lbNomeProduto.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNomeProduto.ForeColor = Color.FromArgb(255, 163, 0);
            lbNomeProduto.Location = new Point(8, 98);
            lbNomeProduto.Name = "lbNomeProduto";
            lbNomeProduto.Size = new Size(150, 29);
            lbNomeProduto.TabIndex = 13;
            lbNomeProduto.Text = "Nome do Produto";
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.BackColor = Color.FromArgb(254, 254, 254);
            lbCadastro.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold);
            lbCadastro.ForeColor = Color.FromArgb(62, 24, 2);
            lbCadastro.Location = new Point(135, 23);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(102, 51);
            lbCadastro.TabIndex = 12;
            lbCadastro.Text = "ITENS";
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarProduto.ForeColor = Color.FromArgb(40, 39, 40);
            btnSalvarProduto.Location = new Point(12, 191);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(163, 24);
            btnSalvarProduto.TabIndex = 20;
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            btnSalvarProduto.Click += btnSalvarProduto_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            ClientSize = new Size(387, 250);
            Controls.Add(btnSalvarProduto);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnFazerPedidoProduto);
            Controls.Add(txtPrecoProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lbPrecoProduto);
            Controls.Add(lbNomeProduto);
            Controls.Add(lbCadastro);
            Controls.Add(lbSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSair;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnFazerPedidoProduto;
        private TextBox txtPrecoProduto;
        private TextBox txtNomeProduto;
        private Label lbPrecoProduto;
        private Label lbNomeProduto;
        private Label lbCadastro;
        private Button btnSalvarProduto;
    }
}