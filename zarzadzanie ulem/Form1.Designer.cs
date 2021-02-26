
namespace zarzadzanie_ulem
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextShift = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextShift.Location = new System.Drawing.Point(498, 13);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(179, 126);
            this.nextShift.TabIndex = 0;
            this.nextShift.Text = "Przepracuj następną zmianę";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // assignJob
            // 
            this.assignJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assignJob.Location = new System.Drawing.Point(10, 77);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(405, 29);
            this.assignJob.TabIndex = 4;
            this.assignJob.Text = "Przypisz tę pracę pszczole";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(295, 37);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 20);
            this.shifts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zmiany";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Wytwarzanie miodu",
            "Pielęgnacja jaj",
            "Nauczanie pszczółek",
            "Utrzymanie ula",
            "Patrol z żądłami"});
            this.workerBeeJob.Location = new System.Drawing.Point(10, 37);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(215, 21);
            this.workerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadanie robotnicy";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(24, 144);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(653, 163);
            this.report.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 319);
            this.Controls.Add(this.report);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextShift);
            this.Name = "Form1";
            this.Text = "System zarządzania ulem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox report;
    }
}

