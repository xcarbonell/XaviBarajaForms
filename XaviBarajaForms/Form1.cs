using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XaviBarajaForms
{
    public partial class Form1 : Form
    {

        Baraja baraja = new Baraja();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearBaraja_Click(object sender, EventArgs e)
        {
            listCartas.Items.Clear();
            foreach (Carta carta in baraja.ResetearBaraja())
            {
                listCartas.Items.Add(carta.ToString());
            }
        }

        private void btnNumCartas_Click(object sender, EventArgs e)
        {
            txtNumCartas.Text = "";
            txtNumCartas.Text = baraja.NumeroCartas().ToString();
        }

        private void btnMezclarBaraja_Click(object sender, EventArgs e)
        {
            listCartas.Items.Clear();
            foreach (Carta carta in baraja.Barajar())
            {
                listCartas.Items.Add(carta.ToString());
            }
        }

        private void btnCartaAzar_Click(object sender, EventArgs e)
        {
            listCartas.Items.Clear();
            listCartas.Items.Add(baraja.CogeCartaAlAzar().ToString());
        }

        private void btnCogerCarta_Click(object sender, EventArgs e)
        {
            int nCarta = (int)numCogerCarta.Value;
            MessageBox.Show(baraja.CogeCarta(nCarta).ToString());
        }

        private void btnRobarCarta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.RobaCarta().ToString());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listCartas.Items.Clear();
            foreach (Carta carta in baraja.baraja)
            {
                listCartas.Items.Add(carta.ToString());
            }
        }
    }
}
