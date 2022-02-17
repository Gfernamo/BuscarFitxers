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
using System.Threading;

namespace BuscarFitxers
{
    public partial class FrmMain : Form
    {
        int llargadaExtensio = 0;
        String extensio = "";
        private Mutex exclusioMutua = new Mutex();
        List<BackgroundWorker> llBackW = new List<BackgroundWorker>();
        private delegate void delegat(String file);
        private delegate void delegatRatoli();
        delegatRatoli ratoli;
        delegat nouFitxer;
        int qttBw = 0;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ratoli = cursorNormal;
            nouFitxer = afegeixFitxer;
        }
        private void cursorNormal()
        {
            Cursor = Cursors.Default;
        }
        private void afegeixFitxer(string files)
        {
            llFitxers.Items.Add(files);
            llFitxers.SelectedIndex = llFitxers.Items.Count - 1;
        }
        private void btCarpeta_Click(object sender, EventArgs e)
        {
            if (tbExtensio.Text.Trim(' ') != "")
            {
                if (dlgCarpeta.ShowDialog() == DialogResult.OK)
                {
                    llBackW.Clear();
                    llFitxers.Items.Clear();
                    llargadaExtensio = tbExtensio.Text.Trim(' ').Length;
                    extensio = tbExtensio.Text.Trim(' ').ToLower();
                    tbCarpeta.Text = dlgCarpeta.SelectedPath;
                    Cursor = Cursors.WaitCursor;
                    creaNouBW(dlgCarpeta.SelectedPath);
                }
            }
            else
            {
                MessageBox.Show("Tens que escriure una extensió!","Extensió necessària"); 
            }

        }
        private void creaNouBW(string selectedPath)
        {
            llBackW.Add(new BackgroundWorker());
            qttBw++;
            llBackW[llBackW.Count - 1].DoWork += BuscarFitxers;
            llBackW[llBackW.Count - 1].WorkerSupportsCancellation = true;
            llBackW[llBackW.Count - 1].RunWorkerAsync(argument: selectedPath);
            llBackW[llBackW.Count - 1].RunWorkerCompleted += heAcabat;
        }
        private void BuscarFitxers(object sender, DoWorkEventArgs e)
        {
            String selectedPath = (String)e.Argument;
            if (Directory.GetFiles(selectedPath).Length > 0)
            {
                foreach (String files in Directory.GetFiles(selectedPath))
                {
                    if (files.Substring(files.Length - llargadaExtensio) == extensio)
                    {
                        this.Invoke(nouFitxer, files);
                    }
                }
            }
            if (Directory.GetDirectories(selectedPath).Length > 0)
            {
                foreach (String subcarpeta in Directory.GetDirectories(selectedPath))
                {
                    exclusioMutua.WaitOne();
                    creaNouBW(subcarpeta);
                    exclusioMutua.ReleaseMutex();
                }
            }
            else if (qttBw == 0)
            {
                resumFinal();
            }
        }
        private void heAcabat(object sender, RunWorkerCompletedEventArgs e)
        {
            exclusioMutua.WaitOne();
            qttBw--;
            if (qttBw <= 0)
            {

                resumFinal();
            }
            exclusioMutua.ReleaseMutex();
        }
        private void resumFinal()
        {
            MessageBox.Show("S'han trobat " + llFitxers.Items.Count.ToString() + " fitxers amb la extensió: " + extensio + Environment.NewLine +"He fet servir " + llBackW.Count.ToString() + " backgrounds.", "Ja he acabat");
            this.Invoke(ratoli);
        }
    }
}
