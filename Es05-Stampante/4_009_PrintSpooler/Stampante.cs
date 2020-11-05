using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_009_PrintSpooler
{
    class Stampante
    {
        public File file;
        public Queue<File> coda=new Queue<File>();
        private static Stampante istanza = null;

        private Stampante()
        {
        }

        public Stampante(File fileStampa)
        {
            this.file = fileStampa;
        }

        public static Stampante InviaStampante(File fileStampa)
        {
            if (istanza == null)
            {
                istanza = new Stampante(fileStampa);
            }
            istanza.coda.Enqueue(fileStampa);
            mostraSuDgv();
            return istanza;
        }

        private static void mostraSuDgv()
        {
            Form1.dataGV.Rows.Clear();
            for (int i = 0; i < istanza.coda.Count; i++)
            {
                Form1.dataGV.Rows.Add();
                Form1.dataGV.Rows[i].Cells[0].Value = (i+1).ToString();
                Form1.dataGV.Rows[i].Cells[1].Value = istanza.coda.ElementAt(i).titolo;
                Form1.dataGV.Rows[i].Cells[2].Value = istanza.coda.ElementAt(i).autore;
                Form1.dataGV.Rows[i].Cells[3].Value = istanza.coda.ElementAt(i).prezzo.ToString();
                
            }
            
        }
        

        public static void StampaCoda()
        {
            File fileDaStampare;
            while (istanza.coda.Count!=0)
            {
                fileDaStampare = istanza.coda.Peek();
                System.Windows.Forms.MessageBox.Show("Stampa in corso di "+fileDaStampare.titolo+" di "+fileDaStampare.autore +". Prezzo: "+fileDaStampare.prezzo.ToString()+"€");
                istanza.coda.Dequeue();
                mostraSuDgv();
            }
        }
    }
}
