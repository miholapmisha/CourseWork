﻿
namespace TerminalHacking
{
    partial class GuessPinCode
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(232, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Easy (7 letters)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(232, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Average (9 letters)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonAvarage_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(232, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hard (11 letters)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.ForeColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(232, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 26);
            this.button5.TabIndex = 5;
            this.button5.Text = "Very hard (12 letters)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonVeryHard_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(232, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Very easy (5 letters)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonVeryEasy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose level of game:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button6.ForeColor = System.Drawing.Color.Lime;
            this.button6.Location = new System.Drawing.Point(232, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 26);
            this.button6.TabIndex = 6;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(612, 353);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
    }
}

