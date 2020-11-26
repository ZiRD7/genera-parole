using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace genera_parole
{
    // Driza Enes - generatore di parole v.0.1
    // Note: -------
    public partial class frmMain : Form
    {
        const int NUMERO_BGW = 3;
        const int NUMERO_PAROLE = 1000;
        const int NUMERO_LETTERE = 10; // lunghezza della parola

        BackgroundWorker bgwSingolo;
        List<BackgroundWorker> bgwList;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "GENERA PAROLE";

            pgbSingoloThread.Maximum = NUMERO_PAROLE;
            pgbTreThread.Maximum = NUMERO_PAROLE;

            txtSingolo.ReadOnly = true;
            txtMultiplo.ReadOnly = true;
        }

        // ********* Singolo *********
        private void btnSingolo_Click(object sender, EventArgs e)
        {
            btnSingolo.Enabled = false;

            bgwSingolo = new BackgroundWorker();
            bgwSingolo.WorkerReportsProgress = true;
            bgwSingolo.WorkerSupportsCancellation = true;
            bgwSingolo.DoWork += BgwSingolo_DoWork;
            bgwSingolo.ProgressChanged += BgwSingolo_ProgressChanged;
            bgwSingolo.RunWorkerCompleted += BgwSingolo_RunWorkerCompleted;

            List<string> parole = new List<string>();

            bgwSingolo.RunWorkerAsync(parole);
        }

        private void BgwSingolo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            List<string> lista_parole = e.Argument as List<string>;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            while(lista_parole.Count < NUMERO_PAROLE)
            {
                bgw.ReportProgress(lista_parole.Count);
                lista_parole.Add(GeneraParola());
                System.Threading.Thread.Sleep(100);
            }

            // ho concluso il mio lavoro
            stopwatch.Stop();
            bgw.CancelAsync();
            e.Result = (stopwatch.ElapsedMilliseconds.ToString());
        }

        private void BgwSingolo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // aggiorno la progressBar
            int progresso = (int)e.ProgressPercentage;
            if (progresso <= pgbSingoloThread.Maximum)
                pgbSingoloThread.Value = progresso;
        }

        private void BgwSingolo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // stampo il tempo impiegato
            string tempo = (string)e.Result;
            txtSingolo.Text = tempo + "  ms";
        }


        // ********* Multiplo *********
        private void btnMultiplo_Click(object sender, EventArgs e)
        {
            btnMultiplo.Enabled = false;

            bgwList = new List<BackgroundWorker>();

            // Creazione dei bgw
            for (int i = 0; i < NUMERO_BGW; i++)
            {
                bgwSingolo = new BackgroundWorker();
                bgwSingolo.WorkerReportsProgress = true;
                bgwSingolo.WorkerSupportsCancellation = true;
                bgwSingolo.DoWork += Bgw_DoWork;
                bgwSingolo.ProgressChanged += Bgw_ProgressChanged;
                bgwSingolo.RunWorkerCompleted += Bgw_RunWorkerCompleted;

                bgwList.Add(bgwSingolo);
            }

            List<string> parole = new List<string>();

            foreach (var item in bgwList)
            {
                item.RunWorkerAsync(parole);
            }

        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            List<string> lista_parole = e.Argument as List<string>;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            while (lista_parole.Count < NUMERO_PAROLE)
            {
                lock (lista_parole)
                {                    
                    lista_parole.Add(GeneraParola());
                }
                bgw.ReportProgress(lista_parole.Count + 1);
                System.Threading.Thread.Sleep(100);
            }

            // ho concluso il mio lavoro
            stopwatch.Stop();
            bgw.CancelAsync();
            e.Result = (stopwatch.ElapsedMilliseconds.ToString());
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // aggiorno la progressBar
            int progresso = (int)e.ProgressPercentage;
            if (progresso <= pgbTreThread.Maximum) 
                pgbTreThread.Value = progresso;            
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // stampo il tempo impiegato
            string tempo = (string)e.Result;
            txtMultiplo.Text = tempo + "  ms";
        }



        // GARA!
        private void btnGara_Click(object sender, EventArgs e)
        {
            btnGara.Enabled = false;

            btnSingolo_Click(sender, e);
            btnMultiplo_Click(sender, e);
        }



        // Metodo che genera una parola random
        public string GeneraParola()
        {
            string lettere = "qwertyuiopasdfghjklzxcvbnm";
            string parola = "";

            Random random = new Random();

            for (int i = 0; i < NUMERO_LETTERE; i++)
                parola += lettere[random.Next(lettere.Length)];

            return parola;
        }

        
    }
}
