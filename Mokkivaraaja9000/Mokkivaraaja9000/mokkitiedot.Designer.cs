namespace Mokkivaraaja9000
{
    partial class haemokkeja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(haemokkeja));
            this.btnBack = new System.Windows.Forms.Button();
            this.cbHlomaara = new System.Windows.Forms.ComboBox();
            this.cbPaikka = new System.Windows.Forms.ComboBox();
            this.mcKalenteri = new System.Windows.Forms.MonthCalendar();
            this.lblAika = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLisapalvelut = new System.Windows.Forms.CheckedListBox();
            this.btnEtsimokki = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(468, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbHlomaara
            // 
            this.cbHlomaara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHlomaara.FormattingEnabled = true;
            this.cbHlomaara.Location = new System.Drawing.Point(256, 75);
            this.cbHlomaara.Name = "cbHlomaara";
            this.cbHlomaara.Size = new System.Drawing.Size(56, 21);
            this.cbHlomaara.TabIndex = 4;
            this.cbHlomaara.SelectedIndexChanged += new System.EventHandler(this.cbHlomaara_SelectedIndexChanged);
            // 
            // cbPaikka
            // 
            this.cbPaikka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPaikka.FormattingEnabled = true;
            this.cbPaikka.Location = new System.Drawing.Point(256, 129);
            this.cbPaikka.Name = "cbPaikka";
            this.cbPaikka.Size = new System.Drawing.Size(150, 21);
            this.cbPaikka.TabIndex = 5;
            // 
            // mcKalenteri
            // 
            this.mcKalenteri.BackColor = System.Drawing.SystemColors.Window;
            this.mcKalenteri.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.mcKalenteri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mcKalenteri.Location = new System.Drawing.Point(17, 45);
            this.mcKalenteri.Name = "mcKalenteri";
            this.mcKalenteri.TabIndex = 6;
            // 
            // lblAika
            // 
            this.lblAika.AutoSize = true;
            this.lblAika.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAika.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAika.Location = new System.Drawing.Point(12, 9);
            this.lblAika.Name = "lblAika";
            this.lblAika.Size = new System.Drawing.Size(145, 27);
            this.lblAika.TabIndex = 7;
            this.lblAika.Text = "Saapuminen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(252, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Paikkakunta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(252, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Henkilömäärä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(252, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lisäpalvelut";
            // 
            // cbLisapalvelut
            // 
            this.cbLisapalvelut.BackColor = System.Drawing.Color.Gold;
            this.cbLisapalvelut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbLisapalvelut.FormattingEnabled = true;
            this.cbLisapalvelut.Items.AddRange(new object[] {
            "poroajelu",
            "siivous",
            "perkele"});
            this.cbLisapalvelut.Location = new System.Drawing.Point(261, 183);
            this.cbLisapalvelut.Name = "cbLisapalvelut";
            this.cbLisapalvelut.Size = new System.Drawing.Size(120, 90);
            this.cbLisapalvelut.TabIndex = 11;
            // 
            // btnEtsimokki
            // 
            this.btnEtsimokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtsimokki.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnEtsimokki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEtsimokki.Image = ((System.Drawing.Image)(resources.GetObject("btnEtsimokki.Image")));
            this.btnEtsimokki.Location = new System.Drawing.Point(448, 300);
            this.btnEtsimokki.Name = "btnEtsimokki";
            this.btnEtsimokki.Size = new System.Drawing.Size(60, 60);
            this.btnEtsimokki.TabIndex = 13;
            this.btnEtsimokki.UseVisualStyleBackColor = true;
            this.btnEtsimokki.Click += new System.EventHandler(this.btnVaraa_mokki_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(422, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 40);
            this.btnMin.TabIndex = 23;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // haemokkeja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(520, 372);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnEtsimokki);
            this.Controls.Add(this.cbLisapalvelut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAika);
            this.Controls.Add(this.mcKalenteri);
            this.Controls.Add(this.cbPaikka);
            this.Controls.Add(this.cbHlomaara);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "haemokkeja";
            this.Text = "mokkitiedot";
            this.Load += new System.EventHandler(this.btnHaemokkeja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbHlomaara;
        private System.Windows.Forms.ComboBox cbPaikka;
        private System.Windows.Forms.MonthCalendar mcKalenteri;
        private System.Windows.Forms.Label lblAika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cbLisapalvelut;
        private System.Windows.Forms.Button btnEtsimokki;
        private System.Windows.Forms.Button btnMin;
    }
}