﻿namespace dochazkovy_system
{
    partial class MainForm
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
            this.zavritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prichod_list = new System.Windows.Forms.ListBox();
            this.odchod_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prichod_btn
            // 
            this.prichod_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.prichod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prichod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prichod_btn.Location = new System.Drawing.Point(79, 346);
            this.prichod_btn.Margin = new System.Windows.Forms.Padding(4);
            this.prichod_btn.Name = "prichod_btn";
            this.prichod_btn.Size = new System.Drawing.Size(165, 71);
            this.prichod_btn.TabIndex = 2;
            this.prichod_btn.Text = "Příchod";
            this.prichod_btn.UseVisualStyleBackColor = false;
            this.prichod_btn.Click += new System.EventHandler(this.prichod_btn_Click);
            // 
            // odchod_btn
            // 
            this.odchod_btn.BackColor = System.Drawing.Color.LightCoral;
            this.odchod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odchod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odchod_btn.Location = new System.Drawing.Point(360, 346);
            this.odchod_btn.Margin = new System.Windows.Forms.Padding(4);
            this.odchod_btn.Name = "odchod_btn";
            this.odchod_btn.Size = new System.Drawing.Size(165, 71);
            this.odchod_btn.TabIndex = 4;
            this.odchod_btn.Text = "Odchod";
            this.odchod_btn.UseVisualStyleBackColor = false;
            this.odchod_btn.Click += new System.EventHandler(this.odchod_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uzivateleToolStripMenuItem,
            this.vypisToolStripMenuItem,
            this.zavritToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uzivateleToolStripMenuItem
            // 
            this.uzivateleToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.uzivateleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrovaníUzivateleToolStripMenuItem,
            this.registrovatUzivateleToolStripMenuItem});
            this.uzivateleToolStripMenuItem.Name = "uzivateleToolStripMenuItem";
            this.uzivateleToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.uzivateleToolStripMenuItem.Text = "Zaměstnanci";
            // 
            // registrovaníUzivateleToolStripMenuItem
            // 
            this.registrovaníUzivateleToolStripMenuItem.Name = "registrovaníUzivateleToolStripMenuItem";
            this.registrovaníUzivateleToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.registrovaníUzivateleToolStripMenuItem.Text = "Zaměstnanci";
            this.registrovaníUzivateleToolStripMenuItem.Click += new System.EventHandler(this.registrovaníUzivateleToolStripMenuItem_Click);
            // 
            // registrovatUzivateleToolStripMenuItem
            // 
            this.registrovatUzivateleToolStripMenuItem.Name = "registrovatUzivateleToolStripMenuItem";
            this.registrovatUzivateleToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.registrovatUzivateleToolStripMenuItem.Text = "Přidat zaměstnance";
            this.registrovatUzivateleToolStripMenuItem.Click += new System.EventHandler(this.registrovatUzivateleToolStripMenuItem_Click);
            // 
            // vypisToolStripMenuItem
            // 
            this.vypisToolStripMenuItem.Name = "vypisToolStripMenuItem";
            this.vypisToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.vypisToolStripMenuItem.Text = "Výpis";
            this.vypisToolStripMenuItem.Click += new System.EventHandler(this.vypisToolStripMenuItem_Click);
            // 
            // zavritToolStripMenuItem
            // 
            this.zavritToolStripMenuItem.Name = "zavritToolStripMenuItem";
            this.zavritToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.zavritToolStripMenuItem.Text = "Zavřít";
            this.zavritToolStripMenuItem.Click += new System.EventHandler(this.zavritToolStripMenuItem_Click);
            // 
            // prichod_list
            // 
            this.prichod_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prichod_list.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.prichod_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prichod_list.FormattingEnabled = true;
            this.prichod_list.ItemHeight = 25;
            this.prichod_list.Location = new System.Drawing.Point(44, 167);
            this.prichod_list.Margin = new System.Windows.Forms.Padding(4);
            this.prichod_list.Name = "prichod_list";
            this.prichod_list.Size = new System.Drawing.Size(250, 104);
            this.prichod_list.TabIndex = 1;
            // 
            // odchod_list
            // 
            this.odchod_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.odchod_list.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.odchod_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odchod_list.FormattingEnabled = true;
            this.odchod_list.ItemHeight = 25;
            this.odchod_list.Location = new System.Drawing.Point(317, 167);
            this.odchod_list.Margin = new System.Windows.Forms.Padding(4);
            this.odchod_list.Name = "odchod_list";
            this.odchod_list.Size = new System.Drawing.Size(250, 104);
            this.odchod_list.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(195, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Docházka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Příchody:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Odchody:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(623, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odchod_list);
            this.Controls.Add(this.prichod_list);
            this.Controls.Add(this.odchod_btn);
            this.Controls.Add(this.prichod_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Docházkový systém";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem zavritToolStripMenuItem;
    }
}

