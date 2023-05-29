namespace Classificação_imc
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
            this.tx_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_Altura = new System.Windows.Forms.NumericUpDown();
            this.tx_Peso = new System.Windows.Forms.NumericUpDown();
            this.tx_Sexo = new System.Windows.Forms.ComboBox();
            this.tx_Idade = new System.Windows.Forms.NumericUpDown();
            this.tx_Calcular = new System.Windows.Forms.Button();
            this.tx_CPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Idade)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_Nome
            // 
            this.tx_Nome.Location = new System.Drawing.Point(231, 92);
            this.tx_Nome.Name = "tx_Nome";
            this.tx_Nome.Size = new System.Drawing.Size(357, 27);
            this.tx_Nome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(160, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(315, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(160, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(390, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(160, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(160, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Altura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(160, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(366, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "IMC";
            // 
            // tx_Altura
            // 
            this.tx_Altura.DecimalPlaces = 2;
            this.tx_Altura.Location = new System.Drawing.Point(231, 268);
            this.tx_Altura.Name = "tx_Altura";
            this.tx_Altura.Size = new System.Drawing.Size(357, 27);
            this.tx_Altura.TabIndex = 19;
            // 
            // tx_Peso
            // 
            this.tx_Peso.DecimalPlaces = 2;
            this.tx_Peso.Location = new System.Drawing.Point(231, 224);
            this.tx_Peso.Name = "tx_Peso";
            this.tx_Peso.Size = new System.Drawing.Size(357, 27);
            this.tx_Peso.TabIndex = 20;
            // 
            // tx_Sexo
            // 
            this.tx_Sexo.FormattingEnabled = true;
            this.tx_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.tx_Sexo.Location = new System.Drawing.Point(437, 178);
            this.tx_Sexo.Name = "tx_Sexo";
            this.tx_Sexo.Size = new System.Drawing.Size(151, 28);
            this.tx_Sexo.TabIndex = 21;
            this.tx_Sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tx_Idade
            // 
            this.tx_Idade.Location = new System.Drawing.Point(231, 178);
            this.tx_Idade.Name = "tx_Idade";
            this.tx_Idade.Size = new System.Drawing.Size(135, 27);
            this.tx_Idade.TabIndex = 22;
            this.tx_Idade.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // tx_Calcular
            // 
            this.tx_Calcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tx_Calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tx_Calcular.Location = new System.Drawing.Point(230, 318);
            this.tx_Calcular.Name = "tx_Calcular";
            this.tx_Calcular.Size = new System.Drawing.Size(181, 87);
            this.tx_Calcular.TabIndex = 23;
            this.tx_Calcular.Text = "Calcular";
            this.tx_Calcular.UseVisualStyleBackColor = false;
            this.tx_Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_CPF
            // 
            this.tx_CPF.Location = new System.Drawing.Point(231, 137);
            this.tx_CPF.Mask = "000,000,000-00";
            this.tx_CPF.Name = "tx_CPF";
            this.tx_CPF.Size = new System.Drawing.Size(357, 27);
            this.tx_CPF.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.tx_CPF);
            this.Controls.Add(this.tx_Calcular);
            this.Controls.Add(this.tx_Idade);
            this.Controls.Add(this.tx_Sexo);
            this.Controls.Add(this.tx_Peso);
            this.Controls.Add(this.tx_Altura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_Nome);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "Form1";
            this.Text = "imc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx_Altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tx_Nome;
        private Label label5;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        private NumericUpDown tx_Altura;
        private NumericUpDown tx_Peso;
        private ComboBox tx_Sexo;
        private NumericUpDown tx_Idade;
        private Button tx_Calcular;
        private MaskedTextBox tx_CPF;
    }
}