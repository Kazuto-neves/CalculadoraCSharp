using Funcons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCsharp
{
    public partial class Form1 : Form
    {
        private Operacons operacons;
        double valor1 = 0, valor2 = 0;
        String op;

        public void setV(String s){tBresultado.Text += s;}

        public void setO(String s,String s2)
        {
            valor1 = double.Parse(tBresultado.Text);
            tBvalor.Text = Convert.ToString(valor1);
            op = s;
            tBoperacao.Text = s2;
            tBresultado.Text = "";
        }

        public void clear()
        {
            tBresultado.Text = "";
            tBoperacao.Text = "";
            tBvalor.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        public Form1()
        {
            operacons = new Operacons();
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setV("8");
        }

        private void bInverter_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(tBresultado.Text);
            tBresultado.Text = Convert.ToString(operacons.Inver(valor1));
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            setV(".");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            setV("0");
        }

        private void bSomar_Click(object sender, EventArgs e)
        {
            setO("soma", "+");
        }

        private void bSubitrair_Click(object sender, EventArgs e)
        {
            setO("sub", "-");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setV("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setV("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setV("5");
        }

        private void bMut_Click(object sender, EventArgs e)
        {
            setO("mut", "*");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setV("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setV("9");
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            if (tBresultado.Text != "")
            {
                valor2 = double.Parse(tBresultado.Text);
                if (op == "soma")
                {
                    tBresultado.Text = operacons.Somar(valor1, valor2).ToString("F");
                    tBoperacao.Text = "";
                    tBvalor.Text = "";
                }else if (op == "sub")
                {
                    tBresultado.Text = operacons.Sub(valor1, valor2).ToString("F");
                    tBoperacao.Text = "";
                    tBvalor.Text = "";
                }
                else if (op == "div")
                {
                    tBresultado.Text = operacons.Div(valor1, valor2).ToString("F");
                    tBoperacao.Text = "";
                    tBvalor.Text = "";
                }
                else if (op == "pow")
                {
                    tBresultado.Text = operacons.PowY(valor1, valor2).ToString("F");
                    tBoperacao.Text = "";
                    tBvalor.Text = "";
                }
                else if (op == "mult")
                {
                    tBresultado.Text = operacons.Mult(valor1, valor2).ToString("F");
                    tBoperacao.Text = "";
                    tBvalor.Text = "";
                }
            }
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            setO("div", "/");
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bPowY_Click(object sender, EventArgs e)
        {
            setO("pow", "^");
        }

        private void bFatorial_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(tBresultado.Text);
            tBresultado.Text = operacons.Fator(valor1).ToString("F");
        }

        private void bRaiz_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(tBresultado.Text);
            tBresultado.Text = operacons.Raiz(valor1).ToString("F");
        }

        private void bPow2_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(tBresultado.Text);
            tBresultado.Text = operacons.Pow2(valor1).ToString("F");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setV("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setV("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setV("1");
        }
    }
}
