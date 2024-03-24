namespace dochazkovy_system
{
    partial class Vypis_uzivatelu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UlozitZmeny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vymazButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zpetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(736, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // UlozitZmeny
            // 
            this.UlozitZmeny.BackColor = System.Drawing.Color.GreenYellow;
            this.UlozitZmeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UlozitZmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UlozitZmeny.Location = new System.Drawing.Point(236, 313);
            this.UlozitZmeny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UlozitZmeny.Name = "UlozitZmeny";
            this.UlozitZmeny.Size = new System.Drawing.Size(173, 58);
            this.UlozitZmeny.TabIndex = 1;
            this.UlozitZmeny.Text = "Uložit změny";
            this.UlozitZmeny.UseVisualStyleBackColor = false;
            this.UlozitZmeny.Click += new System.EventHandler(this.UlozitZmenyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(180, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Výpis zaměstnanců";
            // 
            // vymazButton
            // 
            this.vymazButton.BackColor = System.Drawing.Color.MistyRose;
            this.vymazButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vymazButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vymazButton.Location = new System.Drawing.Point(417, 313);
            this.vymazButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vymazButton.Name = "vymazButton";
            this.vymazButton.Size = new System.Drawing.Size(173, 58);
            this.vymazButton.TabIndex = 3;
            this.vymazButton.Text = "Smazat zaměstnance";
            this.vymazButton.UseVisualStyleBackColor = false;
            this.vymazButton.Click += new System.EventHandler(this.vymazButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zpetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zpetToolStripMenuItem
            // 
            this.zpetToolStripMenuItem.Name = "zpetToolStripMenuItem";
            this.zpetToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.zpetToolStripMenuItem.Text = "Zpět";
            this.zpetToolStripMenuItem.Click += new System.EventHandler(this.zpetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.exitToolStripMenuItem.Text = "Zavřít";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Vypis_uzivatelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(820, 414);
            this.Controls.Add(this.vymazButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UlozitZmeny);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vypis_uzivatelu";
            this.Text = "Docházkový systém - výpis zaměstnanců";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vypis_uzivatelu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UlozitZmeny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vymazButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zpetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}