
namespace Calculadora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPerdaPeso = new System.Windows.Forms.Button();
            this.txtPesoNascimento = new System.Windows.Forms.TextBox();
            this.txtUltimaPesagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIntervaloConsulta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGanhoPeso = new System.Windows.Forms.Button();
            this.txtPesoAnterior = new System.Windows.Forms.TextBox();
            this.txtPesoAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIMC = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnPerdaPeso);
            this.groupBox1.Controls.Add(this.txtPesoNascimento);
            this.groupBox1.Controls.Add(this.txtUltimaPesagem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perda de Peso ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(91, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Em quilo (ex. 15,4)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(91, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Em quilo (ex. 15,4)";
            // 
            // btnPerdaPeso
            // 
            this.btnPerdaPeso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPerdaPeso.Location = new System.Drawing.Point(274, 254);
            this.btnPerdaPeso.Name = "btnPerdaPeso";
            this.btnPerdaPeso.Size = new System.Drawing.Size(150, 45);
            this.btnPerdaPeso.TabIndex = 5;
            this.btnPerdaPeso.Text = "Calcular";
            this.btnPerdaPeso.UseVisualStyleBackColor = true;
            this.btnPerdaPeso.Click += new System.EventHandler(this.btnPerdaPeso_Click);
            // 
            // txtPesoNascimento
            // 
            this.txtPesoNascimento.Location = new System.Drawing.Point(274, 145);
            this.txtPesoNascimento.Name = "txtPesoNascimento";
            this.txtPesoNascimento.Size = new System.Drawing.Size(150, 32);
            this.txtPesoNascimento.TabIndex = 3;
            this.txtPesoNascimento.TextChanged += new System.EventHandler(this.validaTexto);
            // 
            // txtUltimaPesagem
            // 
            this.txtUltimaPesagem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUltimaPesagem.Location = new System.Drawing.Point(274, 61);
            this.txtUltimaPesagem.Name = "txtUltimaPesagem";
            this.txtUltimaPesagem.Size = new System.Drawing.Size(150, 32);
            this.txtUltimaPesagem.TabIndex = 2;
            this.txtUltimaPesagem.TextChanged += new System.EventHandler(this.validaTexto);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(91, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(91, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Última Pesagem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIntervaloConsulta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnGanhoPeso);
            this.groupBox2.Controls.Add(this.txtPesoAnterior);
            this.groupBox2.Controls.Add(this.txtPesoAtual);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ganho de Peso";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(91, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "Em dias (ex. 28)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(91, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Em quilo (ex. 15,4)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(91, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Em quilo (ex. 15,4)";
            // 
            // txtIntervaloConsulta
            // 
            this.txtIntervaloConsulta.Location = new System.Drawing.Point(274, 203);
            this.txtIntervaloConsulta.Name = "txtIntervaloConsulta";
            this.txtIntervaloConsulta.Size = new System.Drawing.Size(150, 32);
            this.txtIntervaloConsulta.TabIndex = 6;
            this.txtIntervaloConsulta.TextChanged += new System.EventHandler(this.validaTexto);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(91, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Intervalo Consulta";
            // 
            // btnGanhoPeso
            // 
            this.btnGanhoPeso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGanhoPeso.Location = new System.Drawing.Point(274, 267);
            this.btnGanhoPeso.Name = "btnGanhoPeso";
            this.btnGanhoPeso.Size = new System.Drawing.Size(150, 45);
            this.btnGanhoPeso.TabIndex = 4;
            this.btnGanhoPeso.Text = "Calcular";
            this.btnGanhoPeso.UseVisualStyleBackColor = true;
            this.btnGanhoPeso.Click += new System.EventHandler(this.btnGanhoPeso_Click);
            // 
            // txtPesoAnterior
            // 
            this.txtPesoAnterior.Location = new System.Drawing.Point(274, 137);
            this.txtPesoAnterior.Name = "txtPesoAnterior";
            this.txtPesoAnterior.Size = new System.Drawing.Size(150, 32);
            this.txtPesoAnterior.TabIndex = 3;
            this.txtPesoAnterior.TextChanged += new System.EventHandler(this.validaTexto);
            // 
            // txtPesoAtual
            // 
            this.txtPesoAtual.Location = new System.Drawing.Point(274, 69);
            this.txtPesoAtual.Name = "txtPesoAtual";
            this.txtPesoAtual.Size = new System.Drawing.Size(150, 32);
            this.txtPesoAtual.TabIndex = 2;
            this.txtPesoAtual.TextChanged += new System.EventHandler(this.validaTexto);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(91, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Peso Anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(91, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peso Atual";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnIMC);
            this.groupBox3.Controls.Add(this.txtAltura);
            this.groupBox3.Controls.Add(this.txtPeso);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 704);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 340);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IMC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(91, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "Em metros (ex. 0,98)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(91, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Em quilo (ex. 15,4)";
            // 
            // btnIMC
            // 
            this.btnIMC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIMC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnIMC.Location = new System.Drawing.Point(274, 257);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(150, 45);
            this.btnIMC.TabIndex = 6;
            this.btnIMC.Text = "Calcular";
            this.btnIMC.UseVisualStyleBackColor = false;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(274, 145);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(150, 32);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.validaTexto);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(274, 67);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(150, 32);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.TextChanged += new System.EventHandler(this.validaTexto);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(91, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(91, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(530, 1061);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora Peso Infantil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPerdaPeso;
        private System.Windows.Forms.TextBox txtPesoNascimento;
        private System.Windows.Forms.TextBox txtUltimaPesagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGanhoPeso;
        private System.Windows.Forms.TextBox txtPesoAnterior;
        private System.Windows.Forms.TextBox txtPesoAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIntervaloConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}

