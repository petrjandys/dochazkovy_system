namespace dochazkovy_system
{
    partial class userReg
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
            this.hodiny_textbox = new System.Windows.Forms.TextBox();
            this.hodinovka_textbox = new System.Windows.Forms.TextBox();
            this.prac_pozice_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_user_btn
            // 
            this.register_user_btn.Location = new System.Drawing.Point(107, 186);
            this.register_user_btn.Name = "register_user_btn";
            this.register_user_btn.Size = new System.Drawing.Size(114, 23);
            this.register_user_btn.TabIndex = 0;
            this.register_user_btn.Text = "Zaregistrovat";
            this.register_user_btn.UseVisualStyleBackColor = true;
            this.register_user_btn.Click += new System.EventHandler(this.register_user_btn_Click);
            // 
            // jmeno_textbox
            // 
            this.jmeno_textbox.Location = new System.Drawing.Point(107, 53);
            this.jmeno_textbox.Name = "jmeno_textbox";
            this.jmeno_textbox.Size = new System.Drawing.Size(100, 20);
            this.jmeno_textbox.TabIndex = 1;
            // 
            // prijmeni_textbox
            // 
            this.prijmeni_textbox.Location = new System.Drawing.Point(107, 79);
            this.prijmeni_textbox.Name = "prijmeni_textbox";
            this.prijmeni_textbox.Size = new System.Drawing.Size(100, 20);
            this.prijmeni_textbox.TabIndex = 2;
            // 
            // hodiny_textbox
            // 
            this.hodiny_textbox.Location = new System.Drawing.Point(107, 131);
            this.hodiny_textbox.Name = "hodiny_textbox";
            this.hodiny_textbox.Size = new System.Drawing.Size(100, 20);
            this.hodiny_textbox.TabIndex = 3;
            // 
            // hodinovka_textbox
            // 
            this.hodinovka_textbox.Location = new System.Drawing.Point(107, 105);
            this.hodinovka_textbox.Name = "hodinovka_textbox";
            this.hodinovka_textbox.Size = new System.Drawing.Size(100, 20);
            this.hodinovka_textbox.TabIndex = 4;
            // 
            // prac_pozice_textbox
            // 
            this.prac_pozice_textbox.Location = new System.Drawing.Point(107, 160);
            this.prac_pozice_textbox.Name = "prac_pozice_textbox";
            this.prac_pozice_textbox.Size = new System.Drawing.Size(100, 20);
            this.prac_pozice_textbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "hodinovka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "pozice";
            // 
            // userReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prac_pozice_textbox);
            this.Controls.Add(this.hodinovka_textbox);
            this.Controls.Add(this.hodiny_textbox);
            this.Controls.Add(this.prijmeni_textbox);
            this.Controls.Add(this.jmeno_textbox);
            this.Controls.Add(this.register_user_btn);
            this.Name = "userReg";
            this.Text = "userReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_user_btn;
        private System.Windows.Forms.TextBox jmeno_textbox;
        private System.Windows.Forms.TextBox prijmeni_textbox;
        private System.Windows.Forms.TextBox hodiny_textbox;
        private System.Windows.Forms.TextBox hodinovka_textbox;
        private System.Windows.Forms.TextBox prac_pozice_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}