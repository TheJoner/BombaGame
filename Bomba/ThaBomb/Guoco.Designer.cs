﻿namespace ThaBomb
{
    partial class Guoco
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indovinelli = new System.Windows.Forms.TabControl();
            this.led1 = new ThaBomb.led();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "difficoltà";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "volume di guoco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "lingua";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 3;
            // 
            // indovinelli
            // 
            this.indovinelli.Location = new System.Drawing.Point(12, 82);
            this.indovinelli.Name = "indovinelli";
            this.indovinelli.SelectedIndex = 0;
            this.indovinelli.Size = new System.Drawing.Size(776, 88);
            this.indovinelli.TabIndex = 4;
            // 
            // led1
            // 
            this.led1.IsOn = false;
            this.led1.ledColor = System.Drawing.Color.Red;
            this.led1.Location = new System.Drawing.Point(165, 206);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(92, 93);
            this.led1.TabIndex = 5;
            this.led1.Text = "led1";
            this.led1.Click += new System.EventHandler(this.led1_Click);
            // 
            // Guoco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 799);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.indovinelli);
            this.Controls.Add(this.panel1);
            this.Name = "Guoco";
            this.Text = "Guoco";
            this.Load += new System.EventHandler(this.Guoco_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl indovinelli;
        private led led1;
    }
}