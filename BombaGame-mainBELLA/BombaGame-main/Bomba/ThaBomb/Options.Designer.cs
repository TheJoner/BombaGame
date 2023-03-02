namespace ThaBomb
{
    partial class Options
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
            this.volume = new System.Windows.Forms.TrackBar();
            this.vollable = new System.Windows.Forms.Label();
            this.confirmOptions = new System.Windows.Forms.Button();
            this.language = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.SuspendLayout();
            // 
            // volume
            // 
            this.volume.LargeChange = 1;
            this.volume.Location = new System.Drawing.Point(12, 31);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(151, 45);
            this.volume.TabIndex = 0;
            this.volume.TabStop = false;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // vollable
            // 
            this.vollable.AutoSize = true;
            this.vollable.Location = new System.Drawing.Point(9, 9);
            this.vollable.Name = "vollable";
            this.vollable.Size = new System.Drawing.Size(42, 13);
            this.vollable.TabIndex = 1;
            this.vollable.Text = "Volume";
            // 
            // confirmOptions
            // 
            this.confirmOptions.Location = new System.Drawing.Point(12, 126);
            this.confirmOptions.Name = "confirmOptions";
            this.confirmOptions.Size = new System.Drawing.Size(151, 23);
            this.confirmOptions.TabIndex = 2;
            this.confirmOptions.Text = "OK";
            this.confirmOptions.UseVisualStyleBackColor = true;
            this.confirmOptions.Click += new System.EventHandler(this.confirmOptions_Click);
            // 
            // language
            // 
            this.language.FormattingEnabled = true;
            this.language.Items.AddRange(new object[] {
            "English",
            "Italiano",
            "Italiano (Bergamasco)"});
            this.language.Location = new System.Drawing.Point(15, 82);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(148, 21);
            this.language.TabIndex = 3;
            this.language.Text = "Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "valore";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.language);
            this.Controls.Add(this.confirmOptions);
            this.Controls.Add(this.vollable);
            this.Controls.Add(this.volume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Label vollable;
        private System.Windows.Forms.Button confirmOptions;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.Label label1;
    }
}