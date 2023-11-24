using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5_ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // Telegrama urgente?
            if (cbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }

            else
            {
                tipoTelegrama = 'o';
            }


            // Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split().Length;

            // Calcular el coste del telegrama
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            // Mostrar el coste en el campo txtPrecio
            //txtPrecio.Text = coste.ToString("C [ABB]"); // "C" formatea el número como moneda
            txtPrecio.Text = coste.ToString("C");

        }
    }
}
