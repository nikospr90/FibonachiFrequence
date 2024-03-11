using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FibonachiGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(
            object sender, 
            EventArgs e)
        {

        }


        private void btn_calcFibo_Click(
            object sender, 
            EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btn_cancel_Click(
            object sender, 
            EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            //progressBar1.Value = 0;
        }

        private void progressBar1_Click(
            object sender, 
            EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(
            object sender, 
            System.ComponentModel.DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            int fib1 = 1;
            int fib2 = 0;
            int result = 0;
            int count = 60;
            string output = "";
            text_result.Invoke(new Action(() => text_result.Text = "1, "));


            for (int i = 0; i < count; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                Thread.Sleep(1000);
                result = fib1 + fib2;
                fib1 = fib2;
                fib2 = result;
                output += result.ToString() + ", ";
                text_result.Invoke(new Action(() => text_result.Text = output));
                var progressPercentage = (int)((i + 1) / (double)count * 100);
                worker.ReportProgress(progressPercentage);
            }
        }

        private void backgroundWorker1_ProgressChanged(
            object sender, 
            System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(
            object sender, 
            System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(
                    "Operation Aborted", 
                    "Cancelled", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                progressBar1.Value = 0;
                text_result.Text = "";
            }
            else
            {
                MessageBox.Show(
                    "Operation succeed",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
