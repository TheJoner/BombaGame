namespace ThaBomb
{
    partial class Menu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.play = new System.Windows.Forms.Button();
            this.created = new System.Windows.Forms.Label();
            this.minMenu = new System.Windows.Forms.Label();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.options = new System.Windows.Forms.Button();
            this.valorinoVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(25, 231);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(193, 45);
            this.play.TabIndex = 0;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // created
            // 
            this.created.Location = new System.Drawing.Point(417, 278);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(201, 17);
            this.created.TabIndex = 1;
            this.created.Text = "Created by: TheJoner | Technoguys_YT";
            // 
            // minMenu
            // 
            this.minMenu.AutoSize = true;
            this.minMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minMenu.Location = new System.Drawing.Point(12, 9);
            this.minMenu.Name = "minMenu";
            this.minMenu.Size = new System.Drawing.Size(349, 73);
            this.minMenu.TabIndex = 2;
            this.minMenu.Text = "Main Menu";
            // 
            // difficulty
            // 
            this.difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Custom"});
            this.difficulty.Location = new System.Drawing.Point(25, 171);
            this.difficulty.MaxDropDownItems = 4;
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(193, 28);
            this.difficulty.TabIndex = 3;
            this.difficulty.Text = "Difficulty";
            this.difficulty.DropDown += new System.EventHandler(this.difficulty_DropDown);
            this.difficulty.SelectedIndexChanged += new System.EventHandler(this.difficulty_SelectedIndexChanged);
            this.difficulty.Click += new System.EventHandler(this.haiClicccato);
            this.difficulty.Enter += new System.EventHandler(this.difficulty_Enter);
            this.difficulty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.difficulty_MouseDown);
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(25, 105);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(193, 45);
            this.options.TabIndex = 4;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // valorinoVolume
            // 
            this.valorinoVolume.AutoSize = true;
            this.valorinoVolume.Location = new System.Drawing.Point(482, 105);
            this.valorinoVolume.Name = "valorinoVolume";
            this.valorinoVolume.Size = new System.Drawing.Size(98, 13);
            this.valorinoVolume.TabIndex = 5;
            this.valorinoVolume.Tag = "";
            this.valorinoVolume.Text = "VALORE VOLUME";
            this.valorinoVolume.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 297);
            this.Controls.Add(this.valorinoVolume);
            this.Controls.Add(this.options);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.minMenu);
            this.Controls.Add(this.created);
            this.Controls.Add(this.play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label created;
        private System.Windows.Forms.Label minMenu;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Label valorinoVolume;
    }
}

