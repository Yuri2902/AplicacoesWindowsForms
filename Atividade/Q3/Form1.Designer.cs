namespace Q3
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
            lbKm = new Label();
            lbResultado = new Label();
            txtDistancia = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lbKm
            // 
            lbKm.AutoSize = true;
            lbKm.Location = new Point(41, 38);
            lbKm.Name = "lbKm";
            lbKm.Size = new Size(99, 15);
            lbKm.TabIndex = 0;
            lbKm.Text = "Distância em Km:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResultado.ForeColor = Color.DarkRed;
            lbResultado.Location = new Point(172, 104);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(94, 25);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(31, 65);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(118, 23);
            txtDistancia.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(31, 106);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 27);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 292);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistancia);
            Controls.Add(lbResultado);
            Controls.Add(lbKm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbKm;
        private Label lbResultado;
        private TextBox txtDistancia;
        private Button btnCalcular;
    }
}
