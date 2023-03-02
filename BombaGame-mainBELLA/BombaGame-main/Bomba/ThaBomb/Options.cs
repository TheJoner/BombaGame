using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaBomb
{
    public partial class Options : Form
    {
        //valori
        int valoreVolume;
        Menu menu;

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
    {
        volume.Value = 10;
        trackBar1_ValueChanged(sender, e);

        // Inizializza l'oggetto "menu"
        menu = new Menu();
    }

        private void volume_Scroll(object sender, EventArgs e)
        {
            trackBar1_ValueChanged(sender, e);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Calcola il valore numerico corrispondente alla posizione corrente della TrackBar

            int valore_minimo = 0;
            int valore_massimo = 10;
            int posizione_minima = volume.Minimum;
            int posizione_massima = volume.Maximum;
            int posizione_corrente = volume.Value;
            int valore_numerico = valore_minimo + (valore_massimo - valore_minimo) * (posizione_corrente - posizione_minima) / (posizione_massima - posizione_minima);

            // Imposta il testo dell'etichetta sul valore numerico corrispondente
            switch (valore_numerico)
            {
                case 0:
                    label1.Text = "0%";
                    break;
                case 1:
                    label1.Text = "10%";
                    break;
                case 2:
                    label1.Text = "20%";
                    break;
                case 3:
                    label1.Text = "30%";
                    break;
                case 4:
                    label1.Text = "40%";
                    break;
                case 5:
                    label1.Text = "50%";
                    break;
                case 6:
                    label1.Text = "60%";
                    break;
                case 7:
                    label1.Text = "70%";
                    break;
                case 8:
                    label1.Text = "80%";
                    break;
                case 9:
                    label1.Text = "90%";
                    break;
                case 10:
                    label1.Text = "100%";
                    break;
            }
            //label1.Text = valore_numerico.ToString();
            valoreVolume = valore_numerico;
            
        }

        private void confirmOptions_Click(object sender, EventArgs e)
        {
            menu.valoreVolume = valoreVolume;
            this.Hide();
        }

        // Metodo per passare la referenza alla classe "Menu" alla classe "Options"
        public void SetMenuReference(Menu menu)
        {
            menu.valoreVolume = valoreVolume;
            this.menu = menu;
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
