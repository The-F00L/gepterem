using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepteremProjekt
{
    class Gepterem
    {

        private int[,] ertekeles;
        private int helyDb;
        private string nev;
        private int sorDb;

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles)
        {
            this.Ertekeles = ertekeles;
            this.HelyDb = helyDb;
            this.Nev = nev;
            this.SorDb = sorDb;

        }

        public double atlag() {
            double nullaDB = 0,egyesDB=0,kettesDB=0,harmasDB=0;
            for (int i = 0; i < sorDb; i++)
            {
                for (int j = 0; j < helyDb; j++)
                {
                    if (ertekeles[i,j]==0)
                    {
                        nullaDB++;
                    }
                    if (ertekeles[i, j] == 1)
                    {
                        egyesDB++;
                    }
                    if (ertekeles[i, j] == 2)
                    {
                        kettesDB++;
                    }
                    if (ertekeles[i, j] == 3)
                    {
                        harmasDB++;
                    }
                }
            }

            return Math.Round(   (egyesDB * 1 + kettesDB * 2 + harmasDB * 3)/(ertekeles.Length - nullaDB) , 1);

        }

        public void UjErt(int utca, int haz)
        {
            ertekeles[utca, haz] = (ertekeles[utca, haz] == 3) ? 0 : ++ertekeles[utca, haz];
        }

        

        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }
        public int HelyDb { get => helyDb; set => helyDb = value; }
        public string Nev { get => nev; set => nev = value; }
        public int SorDb { get => sorDb; set => sorDb = value; }

        
    }
}
