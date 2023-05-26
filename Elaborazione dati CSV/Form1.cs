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


/*Aggiungere, in coda ad ogni record, un campo chiamato "miovalore", contenente un numero casuale compreso tra 10<=X<=20 ed un campo per marcare la cancellazione logica; fatto
contare il numero dei campi che compongono il record. fatto
calcolare la lunghezza massima dei record presenti (avanzato: indicando anche la lunghezza massima di ogni campo); fatto
inserire in ogni record un numero di spazi necessari a rendere fissa la dimensione di tutti i record, senza perdere informazioni. fatto
Aggiungere un record in coda; fatto
Visualizzare dei dati mostrando tre campi significativi a scelta; 
Ricercare un record per campo chiave a scelta (se esiste, utilizzare il campo che contiene dati univoci); fatto
Modificare un record; fatto
Cancellare logicamente un record; fatto
*/


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
            visualizza();
        }


        public void visualizza()
        {
            output.Items.Clear();


            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);


            line = reader.ReadLine();
            line = reader.ReadLine();

            while (line != null)
            {


                p = FromString(line);

                if (p.cancellato == false)
                output.Items.Add(p.nome + ";" + p.latitudine + ";" + p.longitudine + ";");


                line = reader.ReadLine();

            }

            reader.Close();

        }



        //estraggo i valori di dato da una stringa
        public static dato FromString(string datiStringa, string sep = ";")
        {
            dato p = new dato();
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
            return (p.nome + ";" + p.link + ";" + p.latitudine + ";" + p.longitudine + ";" + p.miovalore + ";" + p.cancellato + ";").PadRight(60);
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
            writer.WriteLine(line);
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

        public int NumeroCampi()
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);


            line = reader.ReadLine();
            line = reader.ReadLine();

            int NumeroCampi = line.Split(';').Length - 1; //il meno 1 tiene in conto del ; finale

            reader.Close();

            return NumeroCampi;
        }


        public int ConteggioMassimo()
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);
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

                line = reader.ReadLine();

            }


            reader.Close();


            return lenghtMax;
        }


        public void Canc(string titolo)
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter(NomeTemp, true);
            int lenghtMax;

            line = reader.ReadLine();

            writer.WriteLine(line);

            line = reader.ReadLine();
            lenghtMax = line.Length;

            while (line != null)
            {
                p = FromString(line);

                if (titolo == p.nome)
                {
                    p.cancellato = true;
                }


                writer.WriteLine(FileString(p));

                line = reader.ReadLine();

            }

            writer.Close();
            reader.Close();

            File.Delete(FileName);
            File.Move(NomeTemp, FileName);

        }

        public void Mod(string titolo, string link, string lat, string longi, string miovalore)
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter(NomeTemp, true);
            int lenghtMax;

            line = reader.ReadLine();

            writer.WriteLine(line);

            line = reader.ReadLine();
            lenghtMax = line.Length;

            while (line != null)
            {
                p = FromString(line);

                if (titolo == p.nome)
                {
                    p.link = link;
                    p.latitudine = lat;
                    p.longitudine = longi;
                    p.miovalore = int.Parse(miovalore);
                }


                writer.WriteLine(FileString(p));

                line = reader.ReadLine();

            }

            writer.Close();
            reader.Close();

            File.Delete(FileName);
            File.Move(NomeTemp, FileName);

        }

        public void Padding()
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter(NomeTemp, true);

            line = reader.ReadLine();

            writer.WriteLine(line);

            line = reader.ReadLine();

            while (line != null)
            {

                writer.WriteLine(line.PadRight(130));

                line = reader.ReadLine();
            }

            writer.Close();
            reader.Close();

            File.Delete(FileName);
            File.Move(NomeTemp, FileName);

        }


        public String Ricerca(string nome)
        {
            String line;

            Random rand = new Random();
            StreamReader reader = new StreamReader(FileName);


            line = reader.ReadLine();
            line = reader.ReadLine();

            while (line != null)
            {


                p = FromString(line);
                if (p.nome == nome && p.cancellato == false)
                {
                    return line;
                }

                line = reader.ReadLine();

            }

            reader.Close();



            return "Not Found";
        }


        public void Aggiungi(string titolo, string link, string lat, string longi, string miovalore, bool canc = false)
        {
            string content = titolo + ";" + link + ";" + lat + ";" + longi + ";" + miovalore + ";" + canc + ";";
            scriviAppend(content, FileName);
        }

        private void LunghezzaMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("la lunghezza massima è: " + ConteggioMassimo());

        }

        private void Padding_button_Click(object sender, EventArgs e)
        {
            Padding();
            visualizza();
        }

        private void Cerca_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ricerca(nome_textbox.Text));
        }

        private void CountFields_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il num. di campi è: " + NumeroCampi());

        }

        private void Append_Click(object sender, EventArgs e)
        {
            Aggiungi(titolo_textbox.Text, link_textbox.Text, latitudine_textbox.Text, longitudine_textbox.Text, miovalore_textbox.Text);
            visualizza();
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            Mod(Titolo_mod_textbox.Text, link_mod_textbox.Text, latitudine_mod_textbox.Text, longitudine_mod_textbox.Text, miovalore_mod_textbox.Text);
            visualizza();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cancellazioneLog_Click(object sender, EventArgs e)
        {
            Canc(titolo_canc_textbox.Text);
            visualizza();
        }
    }
}
