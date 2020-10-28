using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, respuesta;
        bool banderaNumero1 = false;
        bool banderaOperacion = false;
        string operacionSeleccionada;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "8";
        }
        private void btn_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = tbPantalla.Text + "9";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (banderaOperacion)
            {
                numero2 = Convert.ToDouble(tbPantalla.Text);

                respuesta = Operacion(operacionSeleccionada);
                tbPantalla.Text = respuesta.ToString();
                limpiar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbPantalla.Text = "";
            limpiar();
        }

      

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "suma";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "multi";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "resta";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!banderaNumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbPantalla.Text);
                tbPantalla.Text = "";
                banderaNumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "div";
            }
        }

        private double Operacion(string operacion)
        {
            double resultado = 0.0;
            switch (operacion)
            {
                case "suma":
                    resultado = numero1 + numero2;
                    break;
                case "resta":
                    resultado = numero1 - numero2;
                    break;
                case "multi":
                    resultado = numero1 * numero2;
                    break;
                case "div":
                    resultado = numero1 / numero2;
                    break;
            }

            return resultado;
        }

        private void limpiar()
        {
            banderaNumero1 = false;
            banderaOperacion = false;
        }
    }
}
