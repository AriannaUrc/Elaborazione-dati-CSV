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
            return (p.nome + ";" + p.link + ";" + p.latitudine + ";" + p.longitudine + ";" + p.cancellato + ";").PadRight(60);
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
            byte[] br;

            Random rand = new Random();
            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);

            char limite = ';';

            string[] words = new string[6];

            br = reader.ReadBytes(74);

            while (f.Position < f.Length - 2) 
            {
                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                String[] fields = line.Split(limite);
                p.nome = fields[0];
                p.link = fields[1];
                p.latitudine = fields[2];
                p.longitudine = fields[3];
                p.miovalore = rand.Next(10, 21);
                p.cancellato = false;

                f.Seek(-recordLength, SeekOrigin.Current);
                writer.Write(Encoding.UTF8.GetBytes(FileString(p)));

            }

            writer.Close();
            reader.Close();
            f.Close();
        }
    }
}
