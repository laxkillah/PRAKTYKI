
namespace Gra_przygodowa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.potionRed = new System.Windows.Forms.PictureBox();
            this.potionBlue = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downMoveButton = new System.Windows.Forms.Button();
            this.rightMoveButton = new System.Windows.Forms.Button();
            this.leftMoveButton = new System.Windows.Forms.Button();
            this.upMoveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.downAttackButton = new System.Windows.Forms.Button();
            this.rightAttackButton = new System.Windows.Forms.Button();
            this.leftAttackButton = new System.Windows.Forms.Button();
            this.upAttackButton = new System.Windows.Forms.Button();
            this.swordEq = new System.Windows.Forms.PictureBox();
            this.bowEq = new System.Windows.Forms.PictureBox();
            this.maceEq = new System.Windows.Forms.PictureBox();
            this.potionRedEq = new System.Windows.Forms.PictureBox();
            this.potionBlueEq = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swordEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueEq)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPicture
            // 
            this.playerPicture.BackColor = System.Drawing.Color.Transparent;
            this.playerPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerPicture.BackgroundImage")));
            this.playerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerPicture.Location = new System.Drawing.Point(12, 12);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(37, 42);
            this.playerPicture.TabIndex = 0;
            this.playerPicture.TabStop = false;
            this.playerPicture.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bat.BackgroundImage")));
            this.bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bat.Location = new System.Drawing.Point(55, 12);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(37, 42);
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghost.BackgroundImage")));
            this.ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghost.Location = new System.Drawing.Point(100, 12);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(37, 42);
            this.ghost.TabIndex = 2;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghoul.BackgroundImage")));
            this.ghoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghoul.Location = new System.Drawing.Point(142, 12);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(37, 42);
            this.ghoul.TabIndex = 3;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // potionRed
            // 
            this.potionRed.BackColor = System.Drawing.Color.Transparent;
            this.potionRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionRed.BackgroundImage")));
            this.potionRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionRed.Location = new System.Drawing.Point(185, 12);
            this.potionRed.Name = "potionRed";
            this.potionRed.Size = new System.Drawing.Size(37, 42);
            this.potionRed.TabIndex = 4;
            this.potionRed.TabStop = false;
            this.potionRed.Visible = false;
            // 
            // potionBlue
            // 
            this.potionBlue.BackColor = System.Drawing.Color.Transparent;
            this.potionBlue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionBlue.BackgroundImage")));
            this.potionBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionBlue.Location = new System.Drawing.Point(228, 12);
            this.potionBlue.Name = "potionBlue";
            this.potionBlue.Size = new System.Drawing.Size(37, 42);
            this.potionBlue.TabIndex = 5;
            this.potionBlue.TabStop = false;
            this.potionBlue.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sword.BackgroundImage")));
            this.sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sword.Location = new System.Drawing.Point(271, 12);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(37, 42);
            this.sword.TabIndex = 6;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bow.BackgroundImage")));
            this.bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bow.Location = new System.Drawing.Point(314, 12);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(37, 42);
            this.bow.TabIndex = 7;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mace.BackgroundImage")));
            this.mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mace.Location = new System.Drawing.Point(357, 12);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(37, 42);
            this.mace.TabIndex = 8;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(623, 196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(132, 47);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gracz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nietoperz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upiór";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(69, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(55, 12);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(69, 12);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(59, 11);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(69, 23);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(59, 11);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(69, 34);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(59, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.downMoveButton);
            this.groupBox1.Controls.Add(this.rightMoveButton);
            this.groupBox1.Controls.Add(this.leftMoveButton);
            this.groupBox1.Controls.Add(this.upMoveButton);
            this.groupBox1.Location = new System.Drawing.Point(463, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruch";
            // 
            // downMoveButton
            // 
            this.downMoveButton.Location = new System.Drawing.Point(50, 48);
            this.downMoveButton.Name = "downMoveButton";
            this.downMoveButton.Size = new System.Drawing.Size(22, 23);
            this.downMoveButton.TabIndex = 3;
            this.downMoveButton.Text = "↓";
            this.downMoveButton.UseVisualStyleBackColor = true;
            // 
            // rightMoveButton
            // 
            this.rightMoveButton.Location = new System.Drawing.Point(78, 33);
            this.rightMoveButton.Name = "rightMoveButton";
            this.rightMoveButton.Size = new System.Drawing.Size(22, 23);
            this.rightMoveButton.TabIndex = 2;
            this.rightMoveButton.Text = "→";
            this.rightMoveButton.UseVisualStyleBackColor = true;
            // 
            // leftMoveButton
            // 
            this.leftMoveButton.Location = new System.Drawing.Point(22, 33);
            this.leftMoveButton.Name = "leftMoveButton";
            this.leftMoveButton.Size = new System.Drawing.Size(22, 23);
            this.leftMoveButton.TabIndex = 1;
            this.leftMoveButton.Text = "←";
            this.leftMoveButton.UseVisualStyleBackColor = true;
            // 
            // upMoveButton
            // 
            this.upMoveButton.Location = new System.Drawing.Point(50, 19);
            this.upMoveButton.Name = "upMoveButton";
            this.upMoveButton.Size = new System.Drawing.Size(22, 23);
            this.upMoveButton.TabIndex = 0;
            this.upMoveButton.Text = "↑";
            this.upMoveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.downAttackButton);
            this.groupBox2.Controls.Add(this.rightAttackButton);
            this.groupBox2.Controls.Add(this.leftAttackButton);
            this.groupBox2.Controls.Add(this.upAttackButton);
            this.groupBox2.Location = new System.Drawing.Point(611, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 87);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atak";
            // 
            // downAttackButton
            // 
            this.downAttackButton.Location = new System.Drawing.Point(50, 48);
            this.downAttackButton.Name = "downAttackButton";
            this.downAttackButton.Size = new System.Drawing.Size(22, 23);
            this.downAttackButton.TabIndex = 3;
            this.downAttackButton.Text = "↓";
            this.downAttackButton.UseVisualStyleBackColor = true;
            // 
            // rightAttackButton
            // 
            this.rightAttackButton.Location = new System.Drawing.Point(78, 33);
            this.rightAttackButton.Name = "rightAttackButton";
            this.rightAttackButton.Size = new System.Drawing.Size(22, 23);
            this.rightAttackButton.TabIndex = 2;
            this.rightAttackButton.Text = "→";
            this.rightAttackButton.UseVisualStyleBackColor = true;
            // 
            // leftAttackButton
            // 
            this.leftAttackButton.Location = new System.Drawing.Point(22, 33);
            this.leftAttackButton.Name = "leftAttackButton";
            this.leftAttackButton.Size = new System.Drawing.Size(22, 23);
            this.leftAttackButton.TabIndex = 1;
            this.leftAttackButton.Text = "←";
            this.leftAttackButton.UseVisualStyleBackColor = true;
            // 
            // upAttackButton
            // 
            this.upAttackButton.Location = new System.Drawing.Point(50, 19);
            this.upAttackButton.Name = "upAttackButton";
            this.upAttackButton.Size = new System.Drawing.Size(22, 23);
            this.upAttackButton.TabIndex = 0;
            this.upAttackButton.Text = "↑";
            this.upAttackButton.UseVisualStyleBackColor = true;
            // 
            // swordEq
            // 
            this.swordEq.BackColor = System.Drawing.Color.Transparent;
            this.swordEq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swordEq.BackgroundImage")));
            this.swordEq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordEq.Location = new System.Drawing.Point(12, 324);
            this.swordEq.Name = "swordEq";
            this.swordEq.Size = new System.Drawing.Size(65, 61);
            this.swordEq.TabIndex = 12;
            this.swordEq.TabStop = false;
            this.swordEq.Click += new System.EventHandler(this.swordEq_Click);
            // 
            // bowEq
            // 
            this.bowEq.BackColor = System.Drawing.Color.Transparent;
            this.bowEq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bowEq.BackgroundImage")));
            this.bowEq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bowEq.Location = new System.Drawing.Point(100, 324);
            this.bowEq.Name = "bowEq";
            this.bowEq.Size = new System.Drawing.Size(65, 61);
            this.bowEq.TabIndex = 13;
            this.bowEq.TabStop = false;
            this.bowEq.Click += new System.EventHandler(this.bowEq_Click);
            // 
            // maceEq
            // 
            this.maceEq.BackColor = System.Drawing.Color.Transparent;
            this.maceEq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maceEq.BackgroundImage")));
            this.maceEq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maceEq.Location = new System.Drawing.Point(185, 324);
            this.maceEq.Name = "maceEq";
            this.maceEq.Size = new System.Drawing.Size(65, 61);
            this.maceEq.TabIndex = 14;
            this.maceEq.TabStop = false;
            this.maceEq.Click += new System.EventHandler(this.maceEq_Click);
            // 
            // potionRedEq
            // 
            this.potionRedEq.BackColor = System.Drawing.Color.Transparent;
            this.potionRedEq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionRedEq.BackgroundImage")));
            this.potionRedEq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionRedEq.Location = new System.Drawing.Point(271, 324);
            this.potionRedEq.Name = "potionRedEq";
            this.potionRedEq.Size = new System.Drawing.Size(65, 61);
            this.potionRedEq.TabIndex = 15;
            this.potionRedEq.TabStop = false;
            this.potionRedEq.Click += new System.EventHandler(this.potionRedEq_Click);
            // 
            // potionBlueEq
            // 
            this.potionBlueEq.BackColor = System.Drawing.Color.Transparent;
            this.potionBlueEq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potionBlueEq.BackgroundImage")));
            this.potionBlueEq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potionBlueEq.Location = new System.Drawing.Point(357, 324);
            this.potionBlueEq.Name = "potionBlueEq";
            this.potionBlueEq.Size = new System.Drawing.Size(65, 61);
            this.potionBlueEq.TabIndex = 16;
            this.potionBlueEq.TabStop = false;
            this.potionBlueEq.Click += new System.EventHandler(this.potionBlueEq_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 407);
            this.Controls.Add(this.playerPicture);
            this.Controls.Add(this.potionBlueEq);
            this.Controls.Add(this.potionRedEq);
            this.Controls.Add(this.maceEq);
            this.Controls.Add(this.bowEq);
            this.Controls.Add(this.swordEq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.potionBlue);
            this.Controls.Add(this.potionRed);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.swordEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueEq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox potionRed;
        private System.Windows.Forms.PictureBox potionBlue;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button downMoveButton;
        private System.Windows.Forms.Button rightMoveButton;
        private System.Windows.Forms.Button leftMoveButton;
        private System.Windows.Forms.Button upMoveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button downAttackButton;
        private System.Windows.Forms.Button rightAttackButton;
        private System.Windows.Forms.Button leftAttackButton;
        private System.Windows.Forms.Button upAttackButton;
        private System.Windows.Forms.PictureBox swordEq;
        private System.Windows.Forms.PictureBox bowEq;
        private System.Windows.Forms.PictureBox maceEq;
        private System.Windows.Forms.PictureBox potionRedEq;
        private System.Windows.Forms.PictureBox potionBlueEq;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Timer timer1;
    }
}

