
namespace CalculadoraCsharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBresultado = new System.Windows.Forms.TextBox();
            this.tBoperacao = new System.Windows.Forms.TextBox();
            this.tBvalor = new System.Windows.Forms.TextBox();
            this.bPow2 = new System.Windows.Forms.Button();
            this.bRaiz = new System.Windows.Forms.Button();
            this.bFatorial = new System.Windows.Forms.Button();
            this.bPowY = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bMut = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.bSubitrair = new System.Windows.Forms.Button();
            this.bInverter = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.bSomar = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.textBox1.Location = new System.Drawing.Point(352, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "|          |          |          |";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.tBresultado);
            this.panel1.Controls.Add(this.tBoperacao);
            this.panel1.Controls.Add(this.tBvalor);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 74);
            this.panel1.TabIndex = 2;
            // 
            // tBresultado
            // 
            this.tBresultado.BackColor = System.Drawing.Color.DarkGreen;
            this.tBresultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBresultado.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBresultado.ForeColor = System.Drawing.Color.Lime;
            this.tBresultado.Location = new System.Drawing.Point(226, 3);
            this.tBresultado.Name = "tBresultado";
            this.tBresultado.ReadOnly = true;
            this.tBresultado.Size = new System.Drawing.Size(211, 31);
            this.tBresultado.TabIndex = 2;
            // 
            // tBoperacao
            // 
            this.tBoperacao.BackColor = System.Drawing.Color.DarkGreen;
            this.tBoperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoperacao.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoperacao.ForeColor = System.Drawing.Color.Lime;
            this.tBoperacao.Location = new System.Drawing.Point(3, 40);
            this.tBoperacao.Name = "tBoperacao";
            this.tBoperacao.ReadOnly = true;
            this.tBoperacao.Size = new System.Drawing.Size(220, 31);
            this.tBoperacao.TabIndex = 1;
            // 
            // tBvalor
            // 
            this.tBvalor.BackColor = System.Drawing.Color.DarkGreen;
            this.tBvalor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBvalor.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBvalor.ForeColor = System.Drawing.Color.Lime;
            this.tBvalor.Location = new System.Drawing.Point(3, 3);
            this.tBvalor.Name = "tBvalor";
            this.tBvalor.Size = new System.Drawing.Size(220, 31);
            this.tBvalor.TabIndex = 0;
            // 
            // bPow2
            // 
            this.bPow2.BackColor = System.Drawing.Color.DarkBlue;
            this.bPow2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPow2.ForeColor = System.Drawing.Color.Lavender;
            this.bPow2.Location = new System.Drawing.Point(12, 132);
            this.bPow2.Name = "bPow2";
            this.bPow2.Size = new System.Drawing.Size(83, 46);
            this.bPow2.TabIndex = 3;
            this.bPow2.Text = "X²";
            this.bPow2.UseVisualStyleBackColor = false;
            this.bPow2.Click += new System.EventHandler(this.bPow2_Click);
            // 
            // bRaiz
            // 
            this.bRaiz.BackColor = System.Drawing.Color.DarkBlue;
            this.bRaiz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRaiz.ForeColor = System.Drawing.Color.Lavender;
            this.bRaiz.Location = new System.Drawing.Point(190, 132);
            this.bRaiz.Name = "bRaiz";
            this.bRaiz.Size = new System.Drawing.Size(83, 46);
            this.bRaiz.TabIndex = 4;
            this.bRaiz.Text = "√";
            this.bRaiz.UseVisualStyleBackColor = false;
            this.bRaiz.Click += new System.EventHandler(this.bRaiz_Click);
            // 
            // bFatorial
            // 
            this.bFatorial.BackColor = System.Drawing.Color.DarkBlue;
            this.bFatorial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bFatorial.ForeColor = System.Drawing.Color.Lavender;
            this.bFatorial.Location = new System.Drawing.Point(279, 132);
            this.bFatorial.Name = "bFatorial";
            this.bFatorial.Size = new System.Drawing.Size(83, 46);
            this.bFatorial.TabIndex = 5;
            this.bFatorial.Text = "n!";
            this.bFatorial.UseVisualStyleBackColor = false;
            this.bFatorial.Click += new System.EventHandler(this.bFatorial_Click);
            // 
            // bPowY
            // 
            this.bPowY.BackColor = System.Drawing.Color.DarkBlue;
            this.bPowY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPowY.ForeColor = System.Drawing.Color.Lavender;
            this.bPowY.Location = new System.Drawing.Point(101, 132);
            this.bPowY.Name = "bPowY";
            this.bPowY.Size = new System.Drawing.Size(83, 46);
            this.bPowY.TabIndex = 6;
            this.bPowY.Text = "X^y";
            this.bPowY.UseVisualStyleBackColor = false;
            this.bPowY.Click += new System.EventHandler(this.bPowY_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.DarkBlue;
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bClear.ForeColor = System.Drawing.Color.Lavender;
            this.bClear.Location = new System.Drawing.Point(366, 132);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(86, 46);
            this.bClear.TabIndex = 7;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.DarkBlue;
            this.button7.Location = new System.Drawing.Point(101, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 46);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.DarkBlue;
            this.button9.Location = new System.Drawing.Point(279, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 46);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.DarkBlue;
            this.button8.Location = new System.Drawing.Point(190, 184);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 46);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.Color.DarkBlue;
            this.bDiv.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDiv.ForeColor = System.Drawing.Color.Lavender;
            this.bDiv.Location = new System.Drawing.Point(12, 184);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(83, 46);
            this.bDiv.TabIndex = 8;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(101, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 46);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.DarkBlue;
            this.button6.Location = new System.Drawing.Point(279, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 46);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Location = new System.Drawing.Point(190, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bMut
            // 
            this.bMut.BackColor = System.Drawing.Color.DarkBlue;
            this.bMut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMut.ForeColor = System.Drawing.Color.Lavender;
            this.bMut.Location = new System.Drawing.Point(12, 236);
            this.bMut.Name = "bMut";
            this.bMut.Size = new System.Drawing.Size(83, 46);
            this.bMut.TabIndex = 13;
            this.bMut.Text = "*";
            this.bMut.UseVisualStyleBackColor = false;
            this.bMut.Click += new System.EventHandler(this.bMut_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.DarkBlue;
            this.button17.Location = new System.Drawing.Point(101, 288);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(83, 46);
            this.button17.TabIndex = 21;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button1_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.DarkBlue;
            this.button18.Location = new System.Drawing.Point(279, 288);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(83, 46);
            this.button18.TabIndex = 20;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button3_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.Color.DarkBlue;
            this.button19.Location = new System.Drawing.Point(190, 288);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(83, 46);
            this.button19.TabIndex = 19;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button2_Click);
            // 
            // bSubitrair
            // 
            this.bSubitrair.BackColor = System.Drawing.Color.DarkBlue;
            this.bSubitrair.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSubitrair.ForeColor = System.Drawing.Color.Lavender;
            this.bSubitrair.Location = new System.Drawing.Point(12, 288);
            this.bSubitrair.Name = "bSubitrair";
            this.bSubitrair.Size = new System.Drawing.Size(83, 46);
            this.bSubitrair.TabIndex = 18;
            this.bSubitrair.Text = "-";
            this.bSubitrair.UseVisualStyleBackColor = false;
            this.bSubitrair.Click += new System.EventHandler(this.bSubitrair_Click);
            // 
            // bInverter
            // 
            this.bInverter.BackColor = System.Drawing.Color.White;
            this.bInverter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bInverter.ForeColor = System.Drawing.Color.DarkBlue;
            this.bInverter.Location = new System.Drawing.Point(101, 340);
            this.bInverter.Name = "bInverter";
            this.bInverter.Size = new System.Drawing.Size(83, 46);
            this.bInverter.TabIndex = 26;
            this.bInverter.Text = "+/-";
            this.bInverter.UseVisualStyleBackColor = false;
            this.bInverter.Click += new System.EventHandler(this.bInverter_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.White;
            this.buttonP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonP.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonP.Location = new System.Drawing.Point(279, 340);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(83, 46);
            this.buttonP.TabIndex = 25;
            this.buttonP.Text = ",";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.White;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.ForeColor = System.Drawing.Color.DarkBlue;
            this.button0.Location = new System.Drawing.Point(190, 340);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(83, 46);
            this.button0.TabIndex = 24;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // bSomar
            // 
            this.bSomar.BackColor = System.Drawing.Color.DarkBlue;
            this.bSomar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSomar.ForeColor = System.Drawing.Color.Lavender;
            this.bSomar.Location = new System.Drawing.Point(12, 340);
            this.bSomar.Name = "bSomar";
            this.bSomar.Size = new System.Drawing.Size(83, 46);
            this.bSomar.TabIndex = 23;
            this.bSomar.Text = "+";
            this.bSomar.UseVisualStyleBackColor = false;
            this.bSomar.Click += new System.EventHandler(this.bSomar_Click);
            // 
            // bIgual
            // 
            this.bIgual.BackColor = System.Drawing.Color.Red;
            this.bIgual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIgual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bIgual.Location = new System.Drawing.Point(366, 184);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(86, 202);
            this.bIgual.TabIndex = 27;
            this.bIgual.Text = "=";
            this.bIgual.UseVisualStyleBackColor = false;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.bIgual);
            this.Controls.Add(this.bInverter);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.bSomar);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.bSubitrair);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bMut);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bPowY);
            this.Controls.Add(this.bFatorial);
            this.Controls.Add(this.bRaiz);
            this.Controls.Add(this.bPow2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBresultado;
        private System.Windows.Forms.TextBox tBoperacao;
        private System.Windows.Forms.TextBox tBvalor;
        private System.Windows.Forms.Button bPow2;
        private System.Windows.Forms.Button bRaiz;
        private System.Windows.Forms.Button bFatorial;
        private System.Windows.Forms.Button bPowY;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bMut;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button bSubitrair;
        private System.Windows.Forms.Button bInverter;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button bSomar;
        private System.Windows.Forms.Button bIgual;
    }
}

