namespace dochazkovy_system
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.prichod_btn = new System.Windows.Forms.Button();
            this.odchod_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uzivateleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrovaníUzivateleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrovatUzivateleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vypisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prichod_list = new System.Windows.Forms.ListBox();
            this.odchod_list = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prichod_btn
            // 
            this.prichod_btn.Location = new System.Drawing.Point(36, 199);
            this.prichod_btn.Name = "prichod_btn";
            this.prichod_btn.Size = new System.Drawing.Size(75, 23);
            this.prichod_btn.TabIndex = 1;
            this.prichod_btn.Text = "Příchod";
            this.prichod_btn.UseVisualStyleBackColor = true;
            this.prichod_btn.Click += new System.EventHandler(this.prichod_btn_Click);
            // 
            // odchod_btn
            // 
            this.odchod_btn.Location = new System.Drawing.Point(296, 199);
            this.odchod_btn.Name = "odchod_btn";
            this.odchod_btn.Size = new System.Drawing.Size(75, 23);
            this.odchod_btn.TabIndex = 2;
            this.odchod_btn.Text = "Odchod";
            this.odchod_btn.UseVisualStyleBackColor = true;
            this.odchod_btn.Click += new System.EventHandler(this.odchod_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uzivateleToolStripMenuItem,
            this.vypisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uzivateleToolStripMenuItem
            // 
            this.uzivateleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrovaníUzivateleToolStripMenuItem,
            this.registrovatUzivateleToolStripMenuItem});
            this.uzivateleToolStripMenuItem.Name = "uzivateleToolStripMenuItem";
            this.uzivateleToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.uzivateleToolStripMenuItem.Text = "Uzivatele";
            // 
            // registrovaníUzivateleToolStripMenuItem
            // 
            this.registrovaníUzivateleToolStripMenuItem.Name = "registrovaníUzivateleToolStripMenuItem";
            this.registrovaníUzivateleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.registrovaníUzivateleToolStripMenuItem.Text = "Registrovaní uzivatele";
            // 
            // registrovatUzivateleToolStripMenuItem
            // 
            this.registrovatUzivateleToolStripMenuItem.Name = "registrovatUzivateleToolStripMenuItem";
            this.registrovatUzivateleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.registrovatUzivateleToolStripMenuItem.Text = "Registrovat uzivatele";
            this.registrovatUzivateleToolStripMenuItem.Click += new System.EventHandler(this.registrovatUzivateleToolStripMenuItem_Click);
            // 
            // vypisToolStripMenuItem
            // 
            this.vypisToolStripMenuItem.Name = "vypisToolStripMenuItem";
            this.vypisToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.vypisToolStripMenuItem.Text = "Vypis";
            this.vypisToolStripMenuItem.Click += new System.EventHandler(this.vypisToolStripMenuItem_Click);
            // 
            // prichod_list
            // 
            this.prichod_list.FormattingEnabled = true;
            this.prichod_list.Location = new System.Drawing.Point(24, 61);
            this.prichod_list.Name = "prichod_list";
            this.prichod_list.Size = new System.Drawing.Size(179, 121);
            this.prichod_list.TabIndex = 7;
            // 
            // odchod_list
            // 
            this.odchod_list.FormattingEnabled = true;
            this.odchod_list.Location = new System.Drawing.Point(235, 61);
            this.odchod_list.Name = "odchod_list";
            this.odchod_list.Size = new System.Drawing.Size(179, 121);
            this.odchod_list.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Příchod";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.odchod_list);
            this.Controls.Add(this.prichod_list);
            this.Controls.Add(this.odchod_btn);
            this.Controls.Add(this.prichod_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prichod_btn;
        private System.Windows.Forms.Button odchod_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uzivateleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vypisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrovaníUzivateleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrovatUzivateleToolStripMenuItem;
        private System.Windows.Forms.ListBox prichod_list;
        private System.Windows.Forms.ListBox odchod_list;
        private System.Windows.Forms.Button button1;
    }
}

