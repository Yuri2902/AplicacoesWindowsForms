namespace Q1
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
            btnConverter = new Button();
            lblResultado = new Label();
            txtCelsius = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(147, 157);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(188, 27);
            btnConverter.TabIndex = 0;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.DarkRed;
            lblResultado.Location = new Point(147, 112);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(182, 21);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado em Fahrenheit";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(188, 40);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(203, 23);
            txtCelsius.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 43);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 3;
            label2.Text = "Temperatura em Celsius(°C):";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 257);
            Controls.Add(label2);
            Controls.Add(txtCelsius);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConverter;
        private Label lblResultado;
        private TextBox txtCelsius;
        private Label label2;
    }
}
