using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using c = System.Convert;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Double num;
        String operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmd0.Click += new EventHandler(numeros);
            cmd1.Click += new EventHandler(numeros);
            cmd2.Click += new EventHandler(numeros);
            cmd3.Click += new EventHandler(numeros);
            cmd4.Click += new EventHandler(numeros);
            cmd5.Click += new EventHandler(numeros);
            cmd6.Click += new EventHandler(numeros);
            cmd7.Click += new EventHandler(numeros);
            cmd8.Click += new EventHandler(numeros);
            cmd9.Click += new EventHandler(numeros);

            cmdSuma.Click += new EventHandler(operadores);
            cmdResta.Click += new EventHandler(operadores);
            cmdMult.Click += new EventHandler(operadores);
            cmdDiv.Click += new EventHandler(operadores);

        }

        private void numeros(object sender, EventArgs Rec)
        {
            if (lblResult.Text == "0") { lblResult.Text = ""; lblOper.Text = ""; }

            lblResult.Text += ((Button)sender).Text;
            lblOper.Text += ((Button)sender).Text;


        }

        private void operadores(object sender, EventArgs Rec)
        {
            if (operador != "") { Calcular(); }

            operador = ((Button)sender).Text;
            num = c.ToDouble(lblResult.Text);

            lblResult.Text = "";
            lblOper.Text += "" + operador + " ";

        }


        private void cmdIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void cmdLimp_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblOper.Text = "";
            num = 0;
            operador = "";
        }

        private void Calcular()
        {
            switch (operador)
            {
                case "+":
                    lblResult.Text = (num + c.ToDouble(lblResult.Text)).ToString();
                    lblOper.Text += " = " + lblResult.Text;
                    break;


                case "-":
                    lblResult.Text = (num - c.ToDouble(lblResult.Text)).ToString();
                    lblOper.Text += " = " + lblResult.Text;
                    break;

                case "*":
                    lblResult.Text = (num * c.ToDouble(lblResult.Text)).ToString();
                    lblOper.Text += " = " + lblResult.Text;
                    break;

                case "/":
                    lblResult.Text = (num / c.ToDouble(lblResult.Text)).ToString();
                    lblOper.Text += " = " + lblResult.Text;
                    break;
            }

            operador = "";
            num = 0;
            if (lblOper.Text.Length > 40) { lblOper.Text = lblResult.Text; }

        }

        private void cmdIgual_Click_1(object sender, EventArgs e)
        {
            Calcular();
        }

        private void cmdLimp_Click_1(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblOper.Text = "";
            num = 0;
            operador = "";
        }
    }
}
