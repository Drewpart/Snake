﻿namespace Snake
{
    partial class EndingScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "Play again?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(171, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 75);
            this.button2.TabIndex = 9;
            this.button2.Text = "NO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(171, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "YES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(96, 83);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(309, 95);
            this.winLabel.TabIndex = 7;
            this.winLabel.Text = "You WIN/LOSE";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.winLabel);
            this.Name = "EndingScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label winLabel;
    }
}
