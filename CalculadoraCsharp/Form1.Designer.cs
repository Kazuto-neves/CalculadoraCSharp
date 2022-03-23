
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.ForeColor = System.Drawing.Color.Chocolate;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.tBresultado);
            this.panel1.Controls.Add(this.tBoperacao);
            this.panel1.Controls.Add(this.tBvalor);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tBresultado
            // 
            this.tBresultado.BackColor = System.Drawing.Color.DarkGreen;
            this.tBresultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tBresultado, "tBresultado");
            this.tBresultado.ForeColor = System.Drawing.Color.Lime;
            this.tBresultado.Name = "tBresultado";
            // 
            // tBoperacao
            // 
            this.tBoperacao.BackColor = System.Drawing.Color.DarkGreen;
            this.tBoperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tBoperacao, "tBoperacao");
            this.tBoperacao.ForeColor = System.Drawing.Color.Lime;
            this.tBoperacao.Name = "tBoperacao";
            this.tBoperacao.ReadOnly = true;
            // 
            // tBvalor
            // 
            this.tBvalor.BackColor = System.Drawing.Color.DarkGreen;
            this.tBvalor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tBvalor, "tBvalor");
            this.tBvalor.ForeColor = System.Drawing.Color.Lime;
            this.tBvalor.Name = "tBvalor";
            // 
            // bPow2
            // 
            this.bPow2.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bPow2, "bPow2");
            this.bPow2.ForeColor = System.Drawing.Color.Lavender;
            this.bPow2.Name = "bPow2";
            this.bPow2.UseVisualStyleBackColor = false;
            this.bPow2.Click += new System.EventHandler(this.bPow2_Click);
            // 
            // bRaiz
            // 
            this.bRaiz.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bRaiz, "bRaiz");
            this.bRaiz.ForeColor = System.Drawing.Color.Lavender;
            this.bRaiz.Name = "bRaiz";
            this.bRaiz.UseVisualStyleBackColor = false;
            this.bRaiz.Click += new System.EventHandler(this.bRaiz_Click);
            // 
            // bFatorial
            // 
            this.bFatorial.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bFatorial, "bFatorial");
            this.bFatorial.ForeColor = System.Drawing.Color.Lavender;
            this.bFatorial.Name = "bFatorial";
            this.bFatorial.UseVisualStyleBackColor = false;
            this.bFatorial.Click += new System.EventHandler(this.bFatorial_Click);
            // 
            // bPowY
            // 
            this.bPowY.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bPowY, "bPowY");
            this.bPowY.ForeColor = System.Drawing.Color.Lavender;
            this.bPowY.Name = "bPowY";
            this.bPowY.UseVisualStyleBackColor = false;
            this.bPowY.Click += new System.EventHandler(this.bPowY_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bClear, "bClear");
            this.bClear.ForeColor = System.Drawing.Color.Lavender;
            this.bClear.Name = "bClear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button7, "button7");
            this.button7.ForeColor = System.Drawing.Color.DarkBlue;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button9, "button9");
            this.button9.ForeColor = System.Drawing.Color.DarkBlue;
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button8, "button8");
            this.button8.ForeColor = System.Drawing.Color.DarkBlue;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bDiv, "bDiv");
            this.bDiv.ForeColor = System.Drawing.Color.Lavender;
            this.bDiv.Name = "bDiv";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.Color.DarkBlue;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bMut
            // 
            this.bMut.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bMut, "bMut");
            this.bMut.ForeColor = System.Drawing.Color.Lavender;
            this.bMut.Name = "bMut";
            this.bMut.UseVisualStyleBackColor = false;
            this.bMut.Click += new System.EventHandler(this.bMut_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button17, "button17");
            this.button17.ForeColor = System.Drawing.Color.DarkBlue;
            this.button17.Name = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button1_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button18, "button18");
            this.button18.ForeColor = System.Drawing.Color.DarkBlue;
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button3_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button19, "button19");
            this.button19.ForeColor = System.Drawing.Color.DarkBlue;
            this.button19.Name = "button19";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button2_Click);
            // 
            // bSubitrair
            // 
            this.bSubitrair.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bSubitrair, "bSubitrair");
            this.bSubitrair.ForeColor = System.Drawing.Color.Lavender;
            this.bSubitrair.Name = "bSubitrair";
            this.bSubitrair.UseVisualStyleBackColor = false;
            this.bSubitrair.Click += new System.EventHandler(this.bSubitrair_Click);
            // 
            // bInverter
            // 
            this.bInverter.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bInverter, "bInverter");
            this.bInverter.ForeColor = System.Drawing.Color.DarkBlue;
            this.bInverter.Name = "bInverter";
            this.bInverter.UseVisualStyleBackColor = false;
            this.bInverter.Click += new System.EventHandler(this.bInverter_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonP, "buttonP");
            this.buttonP.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonP.Name = "buttonP";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button0, "button0");
            this.button0.ForeColor = System.Drawing.Color.DarkBlue;
            this.button0.Name = "button0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // bSomar
            // 
            this.bSomar.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.bSomar, "bSomar");
            this.bSomar.ForeColor = System.Drawing.Color.Lavender;
            this.bSomar.Name = "bSomar";
            this.bSomar.UseVisualStyleBackColor = false;
            this.bSomar.Click += new System.EventHandler(this.bSomar_Click);
            // 
            // bIgual
            // 
            this.bIgual.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.bIgual, "bIgual");
            this.bIgual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bIgual.Name = "bIgual";
            this.bIgual.UseVisualStyleBackColor = false;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximizeBox = false;
            this.Name = "Form1";
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

