namespace Hamburguer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbSair = new Label();
            lbCadastro = new Label();
            lbNome = new Label();
            lbCPF = new Label();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            dgvClientes = new DataGridView();
            btnSalvar = new Button();
            btnFazerPedido = new Button();
            btnCadastrarItens = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbSair
            // 
            lbSair.AutoSize = true;
            lbSair.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSair.ForeColor = Color.FromArgb(40, 39, 40);
            lbSair.Location = new Point(360, 9);
            lbSair.Name = "lbSair";
            lbSair.Size = new Size(41, 51);
            lbSair.TabIndex = 0;
            lbSair.Text = "X";
            lbSair.Click += lbSair_Click;
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold);
            lbCadastro.ForeColor = Color.FromArgb(62, 24, 2);
            lbCadastro.Location = new Point(118, 21);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(150, 51);
            lbCadastro.TabIndex = 1;
            lbCadastro.Text = "CLIENTES";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNome.ForeColor = Color.FromArgb(255, 163, 0);
            lbNome.Location = new Point(12, 96);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(60, 29);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCPF.ForeColor = Color.FromArgb(255, 163, 0);
            lbCPF.Location = new Point(232, 96);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(41, 29);
            lbCPF.TabIndex = 3;
            lbCPF.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 128);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(199, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(232, 128);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(136, 23);
            txtCPF.TabIndex = 5;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.BackgroundColor = Color.FromArgb(219, 203, 179);
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 39, 40);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = SystemColors.WindowText;
            dgvClientes.Location = new Point(12, 212);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvClientes.Size = new Size(356, 180);
            dgvClientes.TabIndex = 6;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.FromArgb(40, 39, 40);
            btnSalvar.Location = new Point(253, 182);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 24);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFazerPedido
            // 
            btnFazerPedido.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            btnFazerPedido.ForeColor = Color.FromArgb(40, 39, 40);
            btnFazerPedido.Location = new Point(226, 408);
            btnFazerPedido.Name = "btnFazerPedido";
            btnFazerPedido.Size = new Size(142, 30);
            btnFazerPedido.TabIndex = 8;
            btnFazerPedido.Text = "Fazer Pedido";
            btnFazerPedido.UseVisualStyleBackColor = true;
            btnFazerPedido.Click += btnFazerPedido_Click;
            // 
            // btnCadastrarItens
            // 
            btnCadastrarItens.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold);
            btnCadastrarItens.ForeColor = Color.FromArgb(40, 39, 40);
            btnCadastrarItens.Location = new Point(12, 408);
            btnCadastrarItens.Name = "btnCadastrarItens";
            btnCadastrarItens.Size = new Size(142, 30);
            btnCadastrarItens.TabIndex = 9;
            btnCadastrarItens.Text = "Cadastrar Itens";
            btnCadastrarItens.UseVisualStyleBackColor = true;
            btnCadastrarItens.Click += btnCadastrarItens_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(274, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            ClientSize = new Size(403, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCadastrarItens);
            Controls.Add(btnFazerPedido);
            Controls.Add(btnSalvar);
            Controls.Add(dgvClientes);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(lbCPF);
            Controls.Add(lbNome);
            Controls.Add(lbCadastro);
            Controls.Add(lbSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSair;
        private Label lbCadastro;
        private Label lbNome;
        private Label lbCPF;
        private TextBox txtNome;
        private TextBox txtCPF;
        private DataGridView dgvClientes;
        private Button btnSalvar;
        private Button btnFazerPedido;
        private Button btnCadastrarItens;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
