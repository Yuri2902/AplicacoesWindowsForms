namespace Hamburguer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbNomeProduto = new Label();
            lbNomeCliente = new Label();
            lbCadastro = new Label();
            lbSair = new Label();
            cbClientes = new ComboBox();
            cbItens = new ComboBox();
            numQuantidade = new NumericUpDown();
            btnSalvarPedido = new Button();
            btnRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(293, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // lbNomeProduto
            // 
            lbNomeProduto.AutoSize = true;
            lbNomeProduto.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNomeProduto.ForeColor = Color.FromArgb(255, 163, 0);
            lbNomeProduto.Location = new Point(242, 97);
            lbNomeProduto.Name = "lbNomeProduto";
            lbNomeProduto.Size = new Size(150, 29);
            lbNomeProduto.TabIndex = 23;
            lbNomeProduto.Text = "Nome do Produto";
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNomeCliente.ForeColor = Color.FromArgb(255, 163, 0);
            lbNomeCliente.Location = new Point(24, 97);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(142, 29);
            lbNomeCliente.TabIndex = 22;
            lbNomeCliente.Text = "Nome do Cliente";
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.BackColor = Color.FromArgb(254, 254, 254);
            lbCadastro.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold);
            lbCadastro.ForeColor = Color.FromArgb(62, 24, 2);
            lbCadastro.Location = new Point(143, 10);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(144, 51);
            lbCadastro.TabIndex = 21;
            lbCadastro.Text = "PEDIDOS";
            // 
            // lbSair
            // 
            lbSair.AutoSize = true;
            lbSair.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSair.ForeColor = Color.FromArgb(40, 39, 40);
            lbSair.Location = new Point(399, 9);
            lbSair.Name = "lbSair";
            lbSair.Size = new Size(41, 51);
            lbSair.TabIndex = 20;
            lbSair.Text = "X";
            lbSair.Click += lbSair_Click;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(33, 147);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(142, 23);
            cbClientes.TabIndex = 26;
            // 
            // cbItens
            // 
            cbItens.FormattingEnabled = true;
            cbItens.Location = new Point(220, 147);
            cbItens.Name = "cbItens";
            cbItens.Size = new Size(135, 23);
            cbItens.TabIndex = 27;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(371, 147);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(50, 23);
            numQuantidade.TabIndex = 28;
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarPedido.ForeColor = Color.FromArgb(40, 39, 40);
            btnSalvarPedido.Location = new Point(24, 209);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(154, 24);
            btnSalvarPedido.TabIndex = 29;
            btnSalvarPedido.Text = "Salvar";
            btnSalvarPedido.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.ForeColor = Color.FromArgb(40, 39, 40);
            btnRelatorio.Location = new Point(220, 209);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(154, 24);
            btnRelatorio.TabIndex = 30;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            ClientSize = new Size(452, 281);
            Controls.Add(btnRelatorio);
            Controls.Add(btnSalvarPedido);
            Controls.Add(numQuantidade);
            Controls.Add(cbItens);
            Controls.Add(cbClientes);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbNomeProduto);
            Controls.Add(lbNomeCliente);
            Controls.Add(lbCadastro);
            Controls.Add(lbSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbNomeProduto;
        private Label lbNomeCliente;
        private Label lbCadastro;
        private Label lbSair;
        private ComboBox cbClientes;
        private ComboBox cbItens;
        private NumericUpDown numQuantidade;
        private Button btnSalvarPedido;
        private Button btnRelatorio;
    }
}