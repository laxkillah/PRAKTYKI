
namespace Drwale
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.nextInLine = new System.Windows.Forms.TextBox();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.Bananowego = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię drwala:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(148, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 20);
            this.name.TabIndex = 1;
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(50, 70);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(258, 23);
            this.addLumberjack.TabIndex = 2;
            this.addLumberjack.Text = "Dodaj drwala";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(50, 145);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(120, 277);
            this.line.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolejka do śniadania";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.Bananowego);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Location = new System.Drawing.Point(190, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 304);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nakarm drwala";
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(6, 275);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(188, 23);
            this.nextLumberjack.TabIndex = 7;
            this.nextLumberjack.Text = "Następny drwal";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // nextInLine
            // 
            this.nextInLine.Location = new System.Drawing.Point(6, 193);
            this.nextInLine.Multiline = true;
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(188, 59);
            this.nextInLine.TabIndex = 6;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(7, 163);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(187, 23);
            this.addFlapjacks.TabIndex = 5;
            this.addFlapjacks.Text = "Dodaj naleśniki";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // Bananowego
            // 
            this.Bananowego.AutoSize = true;
            this.Bananowego.Location = new System.Drawing.Point(6, 126);
            this.Bananowego.Name = "Bananowego";
            this.Bananowego.Size = new System.Drawing.Size(88, 17);
            this.Bananowego.TabIndex = 4;
            this.Bananowego.TabStop = true;
            this.Bananowego.Text = "Bananowego";
            this.Bananowego.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(6, 103);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(79, 17);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Rumianego";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(6, 80);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(79, 17);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Wilgotnego";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(6, 57);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(79, 17);
            this.crispy.TabIndex = 1;
            this.crispy.TabStop = true;
            this.crispy.Text = "Chrupkiego";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(7, 27);
            this.howMany.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(87, 20);
            this.howMany.TabIndex = 8;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.TextBox nextInLine;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.RadioButton Bananowego;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
    }
}

