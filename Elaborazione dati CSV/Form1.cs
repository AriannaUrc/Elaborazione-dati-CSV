using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Elaborazione_dati_CSV
{
    public partial class Form1 : Form
    {
        public string nomeFile = "UrciuoliArianna.csv";
        public struct dato
        {
            public string nome;
            public string link;
            public string latitudine;
            public string longitudine;
            public int miovalore;
            public bool cancellato;
        }


        public dato p;
        public string FileName;
        public string NomeTemp;
        public int recordLength;

        public Form1()
        {
            InitializeComponent();
            p = new dato();
            FileName = "UrciuoliArianna.csv";
            NomeTemp = "temp.csv";
            recordLength = 62;
            Aggiungi_campi();
        }



        //estraggo i valori di dato da una stringa
        public static dato FromString(string datiStringa, string sep = ";")
        {
            dato p =  new dato();
            String[] fields = datiStringa.Split(sep[0]);
            p.nome = fields[0];
            p.link = fields[1];
            p.latitudine = fields[2];
            p.longitudine = fields[3];
            p.miovalore = int.Parse(fields[4]);
            p.cancellato = bool.Parse(fields[5]);

            return p;
        }


        //format stringa dato "dato"
        public string FileString(dato p)
        {
            return (p.nome + ";" + p.link + ";" + p.latitudine + ";" + p.longitudine + ";" +p.miovalore + ";" + p.cancellato + ";").PadRight(60);
        }


        //scrittura in append
        public static void scriviAppend(string content, string filename)
        {
            var fStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fStream);
            sw.WriteLine(content);
            sw.Close();
        }

        public void Aggiungi_campi()
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter(NomeTemp, true);

            char limite = ';';
            string[] fields;

            string[] words = new string[6];

            line = reader.ReadLine();
            line = reader.ReadLine();

            while (line != null) 
            {
                

                fields = line.Split(limite);
                p.nome = fields[0];
                p.link = fields[1];
                p.latitudine = fields[2];
                p.longitudine = fields[3];
                p.miovalore = rand.Next(10, 21);
                p.cancellato = false;

                writer.WriteLine(FileString(p));

                line = reader.ReadLine();

            }

            writer.Close();
            reader.Close();

            File.Delete(FileName);
            File.Move(NomeTemp, FileName);
        }


        public int ConteggioMassimo()
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter(NomeTemp, true);
            int lenghtMax;

            line = reader.ReadLine();
            line = reader.ReadLine();
            lenghtMax = line.Length;

            while (line != null)
            {

                if (lenghtMax < line.Length)
                {
                    lenghtMax = line.Length;
                }
                

                writer.WriteLine(FileString(p));

                line = reader.ReadLine();

            }

            writer.Close();
            reader.Close();

            File.Delete(FileName);
            File.Move(NomeTemp, FileName);

            return lenghtMax;
        }

        private void LunghezzaMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la lunghezza massima è: " + ConteggioMassimo());
            
        }
    }
}
