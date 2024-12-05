using ceTe.DynamicPDF.Merger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace startlista
{
    public partial class Form1 : Form
    {
        private string folderName;

        private MergeDocument document = null;

        public Form1()
        {
            InitializeComponent();
            fbd_mappa.SelectedPath = @"c:\sius\competitions";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * A generálás elindítása
         */
        private void btn_generalas_Click(object sender, EventArgs e)
        {
            DirectoryInfo dinfo = new DirectoryInfo(textBox1.Text + @"\Exports");
            DirectoryInfo[] folders = dinfo.GetDirectories();
            /* A versenyhelyszíneken való végiglépkedés */
            foreach (DirectoryInfo di in folders)
            {
                if (di.Name != "_froSius")
                    felderit(di);
            }
            if (document != null)
                document.Draw(textBox1.Text + @"\startlista.pdf");
            document = null;
            MessageBox.Show("Generálás elkészült");


        }

        private void felderit(DirectoryInfo di)
        {
            DirectoryInfo[] versenyszamok = new DirectoryInfo(di.FullName).GetDirectories();
            List<Versenyszam> versenyszams = new List<Versenyszam>();
            foreach (DirectoryInfo versenyszam in versenyszamok)
            {
                DateTime dt = DateTime.Parse(File.ReadAllText(versenyszam.FullName + "\\ShootEventDescriptor.txt").Split('\n')[6]);
               
                foreach (DirectoryInfo resz in versenyszam.GetDirectories())
                {
                    FileInfo pdf = resz.GetFiles()
                       .Where(f => f.FullName.EndsWith(".pdf"))
                       .OrderByDescending(f => f.LastWriteTime).FirstOrDefault();
                    if(pdf != null)
                        versenyszams.Add(new Versenyszam(pdf, dt));
                }
            }

            versenyszams.Sort();


            foreach (var item in versenyszams)
            {
                
                    if (document == null)
                        document = new MergeDocument(item.Pdf.FullName);
                    else
                        document.Append(item.Pdf.FullName);
            }
            
        }

        private void btn_talloz_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_mappa.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = fbd_mappa.SelectedPath;
                textBox1.Text = folderName;
            }
        }
    }
}
