namespace genera_parole
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSingolo = new System.Windows.Forms.Button();
            this.btnMultiplo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSingolo = new System.Windows.Forms.TextBox();
            this.pgbSingoloThread = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMultiplo = new System.Windows.Forms.TextBox();
            this.pgbTreThread = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSingolo
            // 
            this.btnSingolo.Location = new System.Drawing.Point(5, 18);
            this.btnSingolo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSingolo.Name = "btnSingolo";
            this.btnSingolo.Size = new System.Drawing.Size(70, 30);
            this.btnSingolo.TabIndex = 0;
            this.btnSingolo.Text = "Singolo";
            this.btnSingolo.UseVisualStyleBackColor = true;
            this.btnSingolo.Click += new System.EventHandler(this.btnSingolo_Click);
            // 
            // btnMultiplo
            // 
            this.btnMultiplo.Location = new System.Drawing.Point(5, 18);
            this.btnMultiplo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplo.Name = "btnMultiplo";
            this.btnMultiplo.Size = new System.Drawing.Size(69, 30);
            this.btnMultiplo.TabIndex = 1;
            this.btnMultiplo.Text = "Multiplo";
            this.btnMultiplo.UseVisualStyleBackColor = true;
            this.btnMultiplo.Click += new System.EventHandler(this.btnMultiplo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tempo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSingolo);
            this.groupBox1.Controls.Add(this.pgbSingoloThread);
            this.groupBox1.Controls.Add(this.btnSingolo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Singolo Thread";
            // 
            // txtSingolo
            // 
            this.txtSingolo.Location = new System.Drawing.Point(113, 61);
            this.txtSingolo.Name = "txtSingolo";
            this.txtSingolo.Size = new System.Drawing.Size(157, 20);
            this.txtSingolo.TabIndex = 6;
            // 
            // pgbSingoloThread
            // 
            this.pgbSingoloThread.Location = new System.Drawing.Point(113, 25);
            this.pgbSingoloThread.Name = "pgbSingoloThread";
            this.pgbSingoloThread.Size = new System.Drawing.Size(157, 23);
            this.pgbSingoloThread.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMultiplo);
            this.groupBox2.Controls.Add(this.pgbTreThread);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnMultiplo);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tre Thread";
            // 
            // txtMultiplo
            // 
            this.txtMultiplo.Location = new System.Drawing.Point(113, 61);
            this.txtMultiplo.Name = "txtMultiplo";
            this.txtMultiplo.Size = new System.Drawing.Size(157, 20);
            this.txtMultiplo.TabIndex = 7;
            // 
            // pgbTreThread
            // 
            this.pgbTreThread.Location = new System.Drawing.Point(113, 25);
            this.pgbTreThread.Name = "pgbTreThread";
            this.pgbTreThread.Size = new System.Drawing.Size(157, 23);
            this.pgbTreThread.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tempo";
            // 
            // btnGara
            // 
            this.btnGara.Location = new System.Drawing.Point(13, 216);
            this.btnGara.Name = "btnGara";
            this.btnGara.Size = new System.Drawing.Size(304, 23);
            this.btnGara.TabIndex = 7;
            this.btnGara.Text = "Gara";
            this.btnGara.UseVisualStyleBackColor = true;
            this.btnGara.Click += new System.EventHandler(this.btnGara_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ms";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 249);
            this.Controls.Add(this.btnGara);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Crea Parole";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingolo;
        private System.Windows.Forms.Button btnMultiplo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSingolo;
        private System.Windows.Forms.ProgressBar pgbSingoloThread;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMultiplo;
        private System.Windows.Forms.ProgressBar pgbTreThread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

