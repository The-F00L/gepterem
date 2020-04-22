using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepteremProjekt
{
    public partial class Form1 : Form
    {

        PetrikLajosSzg petrikLajosSzg = new PetrikLajosSzg("petrikgepek.txt");
        readonly int buttonSize = 50;
        int aktTerem = 0;
        List<Image> ert = new List<Image>();

        public Form1()
        {
            InitializeComponent();

        }

        private void button_Balra_Click(object sender, EventArgs e)
        {
            aktTerem--;
            if (aktTerem <= 0)
            {
                aktTerem = 3;
            }
           
            PanelUpdate();

        }

        private void button_Jobbra_Click(object sender, EventArgs e)
        {
            aktTerem++;
            if (aktTerem>=4)
            {
                aktTerem = 0;
            }
            
            PanelUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ert.Add(Image.FromFile(@"Kepek\Pont0.jpg"));
            ert.Add(Image.FromFile(@"Kepek\Pont1.jpg"));
            ert.Add(Image.FromFile(@"Kepek\Pont2.jpg"));
            ert.Add(Image.FromFile(@"Kepek\Pont3.jpg"));
            PanelUpdate();
        }

        void PanelUpdate()
        {
            
            this.Text = petrikLajosSzg.Geptermek[aktTerem].Nev+"("+petrikLajosSzg.Geptermek[aktTerem].atlag()+")";
            if (aktTerem == 0)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Neumann.jpg");
                button_Balra.Enabled = true;
                button_Balra.Show();
                button_Jobbra.Enabled = true;
                button_Jobbra.Show();

            }
            if (aktTerem == petrikLajosSzg.Geptermek.Count-3)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Gordon.jpg");
                button_Balra.Enabled = true;
                button_Balra.Show();
                button_Jobbra.Enabled = true;
                button_Jobbra.Show();
            }
            if (aktTerem == petrikLajosSzg.Geptermek.Count-2)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Steve.jpg");
                button_Balra.Enabled = true;
                button_Balra.Show();
                button_Jobbra.Enabled = true;
                button_Jobbra.Show();
            }
            if (aktTerem == petrikLajosSzg.Geptermek.Count-1)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"Kepek\Bill.jpg");
                button_Balra.Enabled = true;
                button_Balra.Show();
                button_Jobbra.Enabled = true;
                button_Jobbra.Show();
            }


            
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Utcakep.Controls.Clear();
            for (int i = 0; i < petrikLajosSzg.Geptermek[aktTerem].Ertekeles.GetLength(1); i++)
            {
                for (int j = 0; j < petrikLajosSzg.Geptermek[aktTerem].Ertekeles.GetLength(0); j++)
                {
                    //-- Létrehozás ----------------------------------
                    Button g = new Button();
                    g.BackgroundImage = ert[petrikLajosSzg.Geptermek[aktTerem].Ertekeles[j, i]];
                    g.BackgroundImageLayout = ImageLayout.Stretch;
                    g.SetBounds(i * buttonSize, j * buttonSize, buttonSize, buttonSize);
                    //-- eseménykezelés ------------------------------
                    int utca = j;
                    int haz = i;
                    g.Click += (o, e) =>
                    {
                        petrikLajosSzg.Geptermek[aktTerem].UjErt(utca, haz);
                        PanelUpdate();
                    };
                    panel_Utcakep.Controls.Add(g);
                }
            }
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            if (petrikLajosSzg.Mentes())
            {
                MessageBox.Show("Sikeres Mentés");
            }
            else
            {
                MessageBox.Show("Adatok mentése nem sikerült!");
            }
        }
    }
}
