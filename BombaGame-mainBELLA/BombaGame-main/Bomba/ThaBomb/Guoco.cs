using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ThaBomb
{
    public partial class Guoco : Form
    {
        //variabili
        int difficolta;
        int volume;
        int lingua;
        Hashtable indo = new Hashtable();
        /*
            // Creare una nuova Hashtable
            Hashtable hashtable = new Hashtable();

            // Inserire alcune stringhe nella Hashtable utilizzando chiavi intere
            hashtable.Add(0, "valore0");
            hashtable.Add(1, "valore1");
            hashtable.Add(2, "valore2");
            hashtable.Add(3, "valore3");

            // Accedere ai valori nella Hashtable utilizzando le chiavi
            string valore0 = (string)hashtable[0];
            string valore1 = (string)hashtable[1];
            string valore2 = (string)hashtable[2];
            string valore3 = (string)hashtable[3];
         */

        /*
        String[] facile = {
                "primo indovinello facile",
                "secondo indovinello facile",
                "terzo indovinello facile",
                "quarto indovinello facile"
            };

        String[] medio = {
                "primo indovinello medio",
                "secondo indovinello medio",
                "terzo indovinello medio"
            };

        String[] difficilie =
        {
                "primo indovinello difficile",
                "secondo indovinello difficile",
                "terzo indovinello difficile"
        };
        */
        public Guoco()
        {
            InitializeComponent();
        }

        public Guoco(int diff, int vol, int lin)
        {
            InitializeComponent();
            difficolta = diff;
            volume = vol;
            lingua = lin;
            //inserisco gli indovinelli
            //facili 0
            indo.Add(0, "Qual è il colore del cielo di giorno?");                       //Azzurro
            indo.Add(1, "Di che colore sono le banane mature?");                        //Giallo
            indo.Add(2, "Qual è il colore delle foglie degli alberi in primavera?");    //Verde
            indo.Add(3, "Qual è il colore delle fragole mature?");                      //Rosso
            indo.Add(4, "Di che colore è il cavallo bianco di Napoleone?");             //Bianco
            //indo.Add(0, "Qual è il colore delle palle da tennis?");                     //Lime
            indo.Add(5, "Di che colore sono le carote mature?");                        //Arancio
            indo.Add(6, "Qual è il colore dei funghi porcini?");

            //indo.Add(0, "");
        }

        private void Guoco_Load(object sender, EventArgs e)
        {
            //
            
            label1.Text = difficolta.ToString();
            label2.Text = volume.ToString();
            label3.Text = lingua.ToString();
            switch (difficolta)
            {
                case 0:
                    for (int i = 1; i <= 4; i++)
                    {
                        // Creare una nuova pagina
                        TabPage tabPage = new TabPage("Riddle " + i.ToString());

                        // Aggiungere un controllo alla pagina
                        Label label = new Label();
                        label.Text = "Contenuto della pagina " + i.ToString();
                        label.AutoSize = true;
                        tabPage.Controls.Add(label);

                        // Aggiungere la pagina al controllo TabControl
                        indovinelli.TabPages.Add(tabPage);
                    }
                    //difficoltaEasyLoad();
                    break;
                case 1:
                    for (int i = 1; i <= 7; i++)
                    {
                        // Creare una nuova pagina
                        TabPage tabPage = new TabPage("Riddle " + i.ToString());

                        // Aggiungere un controllo alla pagina
                        Label label = new Label();
                        label.Text = "Contenuto della pagina " + i.ToString();
                        label.AutoSize = true;
                        tabPage.Controls.Add(label);

                        // Aggiungere la pagina al controllo TabControl
                        indovinelli.TabPages.Add(tabPage);
                    }
                    //difficoltaMediumLoad();
                    break;
                case 2:
                    for (int i = 1; i <= 10; i++)
                    {
                        // Creare una nuova pagina
                        TabPage tabPage = new TabPage("Riddle " + i.ToString());

                        // Aggiungere un controllo alla pagina
                        Label label = new Label();
                        label.Text = "Contenuto della pagina " + i.ToString();
                        label.AutoSize = true;
                        tabPage.Controls.Add(label);

                        // Aggiungere la pagina al controllo TabControl
                        indovinelli.TabPages.Add(tabPage);
                    }
                    //difficoltaHardLoad();
                    break ;
                case 3:
                    break;

            }
        }
    }
}
