using SimuladorMapeamentoDireto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMapeamentoDireto
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();
        private Simulator simulator;

        public Form1()
        {
            InitializeComponent();
            simulator = new Simulator();

            fillsCache();
            fillsMemory();

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

        }
        private void fillsCache()
        {
            List<string> cacheStr = new List<string>();
            int i = 0;
            foreach (var item in simulator.Cache)
            {
                cacheStr.Add("["+i+"] : "+item.ToString());
                i++;
            }
            this.cache.DataSource = cacheStr;
        }

        private void fillsMemory()
        {
            List<string> mem = new List<string>();
            foreach(var m in simulator.MainMemory)
            {
                mem.Add("["+m.Key + "] : " + m.Value);
            }
            this.mainMemory.DataSource = mem;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            for (int i = 1; (i <= 10); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    if (i > 1)
                        System.Threading.Thread.Sleep(5000);
                    worker.ReportProgress((i * 10));
                    
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.tbProgress.Text = "Canceled!";
            }
            else if (!(e.Error == null))
            {
                this.tbProgress.Text = ("Error: " + e.Error.Message);
            }
            else
            {
                this.tbProgress.Text = "Done!";
            }
            this.button1.Enabled = true;
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.button1.Enabled = false;
            this.button1.BackColor = Color.LightGray;
            int i = e.ProgressPercentage / 10;
            this.end.Text = simulator.Enderecos.ElementAt(i-1).ToString();

            int cacheLine = simulator.Enderecos.ElementAt(i - 1) % simulator.CacheSize;
            bool hasInCache = simulator.accessAddress(simulator.Enderecos.ElementAt(i - 1));
            fillsMemory();
            fillsCache();
            if(!hasInCache)
                this.mainMemory.SelectedIndex = i - 1;

            this.cache.SelectedIndex = cacheLine;

            this.button1.BackColor = Color.Lime;
            
            this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
