namespace Hamburguer
{
    partial class Relatorio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            dgvRelatorio = new DataGridView();
            lbSair = new Label();
            pictureBox2 = new PictureBox();
            lbCadastro = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AllowUserToAddRows = false;
            dgvRelatorio.BackgroundColor = Color.FromArgb(219, 203, 179);
            dgvRelatorio.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRelatorio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Myanmar Text", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 39, 40);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRelatorio.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatorio.EnableHeadersVisualStyles = false;
            dgvRelatorio.GridColor = SystemColors.WindowText;
            dgvRelatorio.Location = new Point(22, 115);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.RowHeadersVisible = false;
            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRelatorio.Size = new Size(393, 212);
            dgvRelatorio.TabIndex = 7;
            dgvRelatorio.CellContentClick += dgvClientes_CellContentClick;
            // 
            // lbSair
            // 
            lbSair.AutoSize = true;
            lbSair.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSair.ForeColor = Color.FromArgb(40, 39, 40);
            lbSair.Location = new Point(383, 9);
            lbSair.Name = "lbSair";
            lbSair.Size = new Size(41, 51);
            lbSair.TabIndex = 8;
            lbSair.Text = "X";
            lbSair.Click += lbSair_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(314, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.Font = new Font("Myanmar Text", 21.75F, FontStyle.Bold);
            lbCadastro.ForeColor = Color.FromArgb(62, 24, 2);
            lbCadastro.Location = new Point(129, 45);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(180, 51);
            lbCadastro.TabIndex = 13;
            lbCadastro.Text = "RELATÓRIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            ClientSize = new Size(436, 352);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbCadastro);
            Controls.Add(lbSair);
            Controls.Add(dgvRelatorio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Relatorio";
            Text = "Relatorio";
            Load += Relatorio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRelatorio;
        private Label lbSair;
        private PictureBox pictureBox2;
        private Label lbCadastro;
        private Label lbNome;
        private Label lbCPF;
        private TextBox txtNome;
        private TextBox txtCPF;
        private PictureBox pictureBox1;
    }
}