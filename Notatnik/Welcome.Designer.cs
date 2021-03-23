
using System.Windows.Forms;

namespace Notatnik
{
    partial class Welcome : Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.newListPasswordButton = new System.Windows.Forms.Button();
            this.openListButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(174, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co chcesz zrobić?";
            // 
            // newListPasswordButton
            // 
            this.newListPasswordButton.Location = new System.Drawing.Point(162, 94);
            this.newListPasswordButton.Name = "newListPasswordButton";
            this.newListPasswordButton.Size = new System.Drawing.Size(185, 42);
            this.newListPasswordButton.TabIndex = 1;
            this.newListPasswordButton.Text = "Utwórz nową listę notatek z hasłem";
            this.newListPasswordButton.UseVisualStyleBackColor = true;
            this.newListPasswordButton.Click += new System.EventHandler(this.newListPasswordButton_Click);
            // 
            // openListButton
            // 
            this.openListButton.Location = new System.Drawing.Point(162, 188);
            this.openListButton.Name = "openListButton";
            this.openListButton.Size = new System.Drawing.Size(185, 43);
            this.openListButton.TabIndex = 2;
            this.openListButton.Text = "Otwórz istniejącą listę notatek";
            this.openListButton.UseVisualStyleBackColor = true;
            this.openListButton.Click += new System.EventHandler(this.openListButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(228, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Witaj!";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(364, 106);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(143, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wprowadź hasło:";
            // 
            // newListButton
            // 
            this.newListButton.Location = new System.Drawing.Point(162, 142);
            this.newListButton.Name = "newListButton";
            this.newListButton.Size = new System.Drawing.Size(185, 40);
            this.newListButton.TabIndex = 6;
            this.newListButton.Text = "Utwórz nową listę notatek bez hasła";
            this.newListButton.UseVisualStyleBackColor = true;
            this.newListButton.Click += new System.EventHandler(this.newListButton_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 348);
            this.Controls.Add(this.newListButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openListButton);
            this.Controls.Add(this.newListPasswordButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.Text = "Notatnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newListPasswordButton;
        private System.Windows.Forms.Button openListButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newListButton;
    }
}