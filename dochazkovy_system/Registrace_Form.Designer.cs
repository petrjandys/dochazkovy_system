namespace dochazkovy_system
{
    partial class Registrace_Form
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
            this.register_user_btn = new System.Windows.Forms.Button();
            this.jmeno_textbox = new System.Windows.Forms.TextBox();
            this.prijmeni_textbox = new System.Windows.Forms.TextBox();
            this.hodinovka_textbox = new System.Windows.Forms.TextBox();
            this.prac_pozice_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zpetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_user_btn
            // 
            this.register_user_btn.BackColor = System.Drawing.Color.Beige;
            this.register_user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_user_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_user_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.register_user_btn.Location = new System.Drawing.Point(117, 241);
            this.register_user_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_user_btn.Name = "register_user_btn";
            this.register_user_btn.Size = new System.Drawing.Size(152, 44);
            this.register_user_btn.TabIndex = 0;
            this.register_user_btn.Text = "Zaregistrovat";
            this.register_user_btn.UseVisualStyleBackColor = false;
            this.register_user_btn.Click += new System.EventHandler(this.register_user_btn_Click);
            // 
            // jmeno_textbox
            // 
            this.jmeno_textbox.Location = new System.Drawing.Point(143, 89);
            this.jmeno_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jmeno_textbox.Name = "jmeno_textbox";
            this.jmeno_textbox.Size = new System.Drawing.Size(132, 22);
            this.jmeno_textbox.TabIndex = 1;
            // 
            // prijmeni_textbox
            // 
            this.prijmeni_textbox.Location = new System.Drawing.Point(143, 126);
            this.prijmeni_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prijmeni_textbox.Name = "prijmeni_textbox";
            this.prijmeni_textbox.Size = new System.Drawing.Size(132, 22);
            this.prijmeni_textbox.TabIndex = 2;
            // 
            // hodinovka_textbox
            // 
            this.hodinovka_textbox.Location = new System.Drawing.Point(143, 162);
            this.hodinovka_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hodinovka_textbox.Name = "hodinovka_textbox";
            this.hodinovka_textbox.Size = new System.Drawing.Size(132, 22);
            this.hodinovka_textbox.TabIndex = 4;
            this.hodinovka_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hodinovka_textbox_KeyPress);
            // 
            // prac_pozice_textbox
            // 
            this.prac_pozice_textbox.Location = new System.Drawing.Point(143, 199);
            this.prac_pozice_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prac_pozice_textbox.Name = "prac_pozice_textbox";
            this.prac_pozice_textbox.Size = new System.Drawing.Size(132, 22);
            this.prac_pozice_textbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hodinovka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pozice";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zpetToolStripMenuItem,
            this.zavřítToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zpetToolStripMenuItem
            // 
            this.zpetToolStripMenuItem.Name = "zpetToolStripMenuItem";
            this.zpetToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.zpetToolStripMenuItem.Text = "Zpět";
            this.zpetToolStripMenuItem.Click += new System.EventHandler(this.zpetToolStripMenuItem_Click);
            // 
            // zavřítToolStripMenuItem
            // 
            this.zavřítToolStripMenuItem.Name = "zavřítToolStripMenuItem";
            this.zavřítToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.zavřítToolStripMenuItem.Text = "Zavřít";
            this.zavřítToolStripMenuItem.Click += new System.EventHandler(this.zavritToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(53, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Přidání zaměstnance";
            // 
            // Registrace_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(376, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prac_pozice_textbox);
            this.Controls.Add(this.hodinovka_textbox);
            this.Controls.Add(this.prijmeni_textbox);
            this.Controls.Add(this.jmeno_textbox);
            this.Controls.Add(this.register_user_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registrace_Form";
            this.Text = "Docházkový systém - přidat zaměstnance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userReg_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_user_btn;
        private System.Windows.Forms.TextBox jmeno_textbox;
        private System.Windows.Forms.TextBox prijmeni_textbox;
        private System.Windows.Forms.TextBox hodinovka_textbox;
        private System.Windows.Forms.TextBox prac_pozice_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zpetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zavřítToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}