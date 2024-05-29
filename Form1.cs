using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_De_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTemp.Text == "") 
            {
                MessageBox.Show("Escreva a temperatura de entrada") ;
            } 

            Calculo calculo = new Calculo();

            if(rbCelcius1.Checked ) 
            {
                if(rbFahrenheit2.Checked) 
                {
                    calculo.CalculoF(txtTemp.Text);
                    lblResultado.Text = Convert.ToString(calculo.ResulF() + " " + "Fahrenheit");
                }

                else if (rbKelvin2.Checked)
                {
                    calculo.CalculoK(txtTemp.Text);
                    lblResultado.Text = Convert.ToString(calculo.ResulK() + " " + "Kelvin");
                }

                else
                {
                    {
                        lblResultado.Text = txtTemp.Text + "celcius";
                    }
                }

            }

            else if (rbFahrenheit1.Checked)
            {
                if (rbCelcius2.Checked)
                {
                    calculo.CalculoFC(txtTemp.Text);
                    lblResultado.Text = Convert.ToString(calculo.ResulC() + " " + "Celcius");
                }

                else if (rbKelvin2.Checked)
                {
                    calculo.CalculoFK(txtTemp.Text);
                    lblResultado.Text = Convert.ToString(calculo.ResulK() + " " + "Kelvin");
                }

                else
                {
                    lblResultado.Text = txtTemp.Text + "Fahrenheit";
                }
            }

            else if (rbKelvin1.Checked)
            {
                if (rbCelcius2.Checked)
                {
                    calculo.CalculoKC(txtTemp.Text);
                    lblResultado.Text = Convert.ToString(calculo.ResulC() + " " + "Celcius");
                }

                else if (rbFahrenheit2.Checked)
                {
                    calculo.CalculoKF(txtTemp.Text);
                    lblResultado.Text = Convert.ToString(calculo.ResulF() + " " + "Kelvin");
                }

                else
                {
                    lblResultado.Text = txtTemp.Text + "Kelvin";
                }
            }


        }

    }
}
