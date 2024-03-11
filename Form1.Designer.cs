namespace FibonachiGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_calcFibo = new Button();
            progressBar1 = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            text_result = new TextBox();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // btn_calcFibo
            // 
            btn_calcFibo.Location = new Point(12, 12);
            btn_calcFibo.Name = "btn_calcFibo";
            btn_calcFibo.Size = new Size(174, 68);
            btn_calcFibo.TabIndex = 0;
            btn_calcFibo.Text = "Calculate";
            btn_calcFibo.UseVisualStyleBackColor = true;
            btn_calcFibo.Click += btn_calcFibo_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(220, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1973, 68);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // text_result
            // 
            text_result.Location = new Point(220, 109);
            text_result.Multiline = true;
            text_result.Name = "text_result";
            text_result.ReadOnly = true;
            text_result.Size = new Size(1973, 856);
            text_result.TabIndex = 2;
            text_result.TextChanged += textBox1_TextChanged;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(12, 109);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(174, 68);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2230, 1088);
            Controls.Add(btn_cancel);
            Controls.Add(text_result);
            Controls.Add(progressBar1);
            Controls.Add(btn_calcFibo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_calcFibo;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox text_result;
        private Button btn_cancel;
    }
}
