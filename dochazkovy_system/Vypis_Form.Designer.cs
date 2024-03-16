namespace dochazkovy_system
{
    partial class Vypis_Form
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
            this.zamestnanecCombo = new System.Windows.Forms.ComboBox();
            this.DatailVypis_DataGridView = new System.Windows.Forms.DataGridView();
            this.mesicCombo = new System.Windows.Forms.ComboBox();
            this.zobrazitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatailVypis_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zamestnanecCombo
            // 
            this.zamestnanecCombo.FormattingEnabled = true;
            this.zamestnanecCombo.Location = new System.Drawing.Point(29, 148);
            this.zamestnanecCombo.Name = "zamestnanecCombo";
            this.zamestnanecCombo.Size = new System.Drawing.Size(121, 21);
            this.zamestnanecCombo.TabIndex = 0;
            // 
            // DatailVypis_DataGridView
            // 
            this.DatailVypis_DataGridView.AllowUserToAddRows = false;
            this.DatailVypis_DataGridView.AllowUserToDeleteRows = false;
            this.DatailVypis_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatailVypis_DataGridView.Enabled = false;
            this.DatailVypis_DataGridView.Location = new System.Drawing.Point(29, 243);
            this.DatailVypis_DataGridView.Name = "DatailVypis_DataGridView";
            this.DatailVypis_DataGridView.Size = new System.Drawing.Size(413, 201);
            this.DatailVypis_DataGridView.TabIndex = 1;
            // 
            // mesicCombo
            // 
            this.mesicCombo.FormattingEnabled = true;
            this.mesicCombo.Location = new System.Drawing.Point(165, 148);
            this.mesicCombo.Name = "mesicCombo";
            this.mesicCombo.Size = new System.Drawing.Size(121, 21);
            this.mesicCombo.TabIndex = 2;
            // 
            // zobrazitButton
            // 
            this.zobrazitButton.Location = new System.Drawing.Point(322, 148);
            this.zobrazitButton.Name = "zobrazitButton";
            this.zobrazitButton.Size = new System.Drawing.Size(75, 23);
            this.zobrazitButton.TabIndex = 3;
            this.zobrazitButton.Text = "button1";
            this.zobrazitButton.UseVisualStyleBackColor = true;
            this.zobrazitButton.Click += new System.EventHandler(this.zobrazitButton_Click);
            // 
            // Vypis_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 522);
            this.Controls.Add(this.zobrazitButton);
            this.Controls.Add(this.mesicCombo);
            this.Controls.Add(this.DatailVypis_DataGridView);
            this.Controls.Add(this.zamestnanecCombo);
            this.Name = "Vypis_Form";
            this.Text = "Vypis_Form";
            ((System.ComponentModel.ISupportInitialize)(this.DatailVypis_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox zamestnanecCombo;
        private System.Windows.Forms.DataGridView DatailVypis_DataGridView;
        private System.Windows.Forms.ComboBox mesicCombo;
        private System.Windows.Forms.Button zobrazitButton;
    }
}