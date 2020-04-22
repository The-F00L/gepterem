using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepteremProjekt
{
    class PetrikLajosSzg
    {
        List<Gepterem> geptermek = new List<Gepterem>();

        public PetrikLajosSzg(string filenev)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filenev))
                {
                    while (!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int sorokSzama = int.Parse(sor[0]);
                        int helyekSzama = int.Parse(sor[1]);
                        int[,] sorok = new int[sorokSzama, helyekSzama];
                        string ujSor = string.Empty;
                        int temp = 0;
                        while ((ujSor = sr.ReadLine()) != "")
                        {
                            sor = ujSor.Split(';');
                            for (int i = 0; i < helyekSzama; i++)
                            {
                                sorok[temp, i] = int.Parse(sor[i]);
                            }
                            temp++;

                        }
                        Geptermek.Add(new Gepterem(nev, sorokSzama, helyekSzama, sorok));
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }


        }

        internal List<Gepterem> Geptermek { get => geptermek; set => geptermek = value; }

        public bool Mentes()
        {
           
            if (File.Exists(@"petrikgepek.bak"))
            {
                File.Delete(@"petrikgepek.bak");
            }
            else
            {
                File.Copy("petrikgepek.txt", "petrikgepek.bak");
            }

            if (File.Exists(@"petrikgepek.txt"))
            {
                File.Delete(@"petrikgepek.txt");
            }
            bool sikeres = false;
            try
            {
                
                using (StreamWriter sw = new StreamWriter("petrikgepek.txt"))
                {
                    foreach (var item in geptermek)
                    {
                        sw.WriteLine(item.Nev+"\n");
                        sw.WriteLine(string.Join(";", item.SorDb, item.HelyDb)+"\n");

                        /*for (int i = 0; i < item.Ertekeles.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.Ertekeles.GetLength(1); j++)
                            {
                                sw.WriteLine(string.Join(";",item.Ertekeles[i, j]));
                            }
                            
                        }*/
                        for (int i = 0; i < item.SorDb; i++)
                        {
                            
                            for (int j = 0; j < item.HelyDb; j++)
                            {
                                
                                if (j+1==item.HelyDb)
                                {
                                    sw.Write(item.Ertekeles[i, j]);
                                }
                                else
                                {
                                    sw.Write(item.Ertekeles[i, j] + ";");
                                }
                                
                            }
                            sw.WriteLine("\n");
                        }

                        sw.WriteLine();
                    }
                    sw.Close();
                }
                sikeres = true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return sikeres;
        }




    }


}

