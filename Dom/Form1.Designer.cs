
namespace Dom
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
            this.description = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(530, 220);
            this.description.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(26, 252);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(108, 21);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Idź tutaj:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(105, 285);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(355, 32);
            this.goThroughTheDoor.TabIndex = 2;
            this.goThroughTheDoor.Text = "Przejdź przez drzwi";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(140, 252);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(402, 21);
            this.exits.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 329);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Zbadaj dom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.ComboBox exits;
    }
}

