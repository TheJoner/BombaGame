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
    public partial class Menu : Form
    {
        //inizializzo le form
        Options Options;
        Guoco Guoco;
        int difficolta = -1; //medio
        int opzioniAperto = 0;
        //resto delle variabili che mi servono
        //Opzioni:
        public int valoreVolume { get; set; }
        //lingua?


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Options = new Options();
            Options.SetMenuReference(this);
            
        }

        private void options_Click(object sender, EventArgs e)
        {
            Options.Show();
            opzioniAperto++;
        }

        private void play_Click(object sender, EventArgs e)
        {
            if(difficolta == -1)
            {
                MessageBox.Show("Insert difficulty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (opzioniAperto == 0)
            {
                Options.SetMenuReference(this);
                Guoco = new Guoco(difficolta, 10, 0/* INGLESE*/);
                Guoco.Show();
            }
            else
            {
                Options.SetMenuReference(this);
                Guoco = new Guoco(difficolta, valoreVolume, 0/* INGLESE*/);
                Guoco.Show();
            }
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            difficolta = difficulty.SelectedIndex;
            //MessageBox.Show(difficolta.ToString());

        }

        //per la difficoltà
        private void haiClicccato(object sender, EventArgs e)
        {
            difficulty.DroppedDown = true;
        }

        private void difficulty_MouseDown(object sender, MouseEventArgs e)
        {
            difficulty.Capture = false;
        }

        private void difficulty_Enter(object sender, EventArgs e)
        {
            difficulty.DroppedDown = true;
            difficulty.Capture = false;
        }

        private void difficulty_DropDown(object sender, EventArgs e)
        {
            difficulty.DroppedDown = false;
        }
    }
}
