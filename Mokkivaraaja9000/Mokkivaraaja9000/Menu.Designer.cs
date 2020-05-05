namespace Mokkivaraaja9000
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnSelaa_mokki = new System.Windows.Forms.Button();
            this.btnVaraa_mokki = new System.Windows.Forms.Button();
            this.btnSelaa_asiakas = new System.Windows.Forms.Button();
            this.btnSyota_tietoa = new System.Windows.Forms.Button();
            this.btnExitMenu = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMinMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelaa_mokki
            // 
            this.btnSelaa_mokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelaa_mokki.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelaa_mokki.Image = ((System.Drawing.Image)(resources.GetObject("btnSelaa_mokki.Image")));
            this.btnSelaa_mokki.Location = new System.Drawing.Point(12, 61);
            this.btnSelaa_mokki.Name = "btnSelaa_mokki";
            this.btnSelaa_mokki.Size = new System.Drawing.Size(140, 110);
            this.btnSelaa_mokki.TabIndex = 0;
            this.btnSelaa_mokki.Text = "SELAA";
            this.btnSelaa_mokki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelaa_mokki.UseVisualStyleBackColor = true;
            this.btnSelaa_mokki.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVaraa_mokki
            // 
            this.btnVaraa_mokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaraa_mokki.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnVaraa_mokki.Image = ((System.Drawing.Image)(resources.GetObject("btnVaraa_mokki.Image")));
            this.btnVaraa_mokki.Location = new System.Drawing.Point(158, 61);
            this.btnVaraa_mokki.Name = "btnVaraa_mokki";
            this.btnVaraa_mokki.Size = new System.Drawing.Size(140, 110);
            this.btnVaraa_mokki.TabIndex = 1;
            this.btnVaraa_mokki.Text = "VARAA";
            this.btnVaraa_mokki.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVaraa_mokki.UseVisualStyleBackColor = true;
            this.btnVaraa_mokki.Click += new System.EventHandler(this.btnVaraa_mokki_Click);
            // 
            // btnSelaa_asiakas
            // 
            this.btnSelaa_asiakas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelaa_asiakas.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnSelaa_asiakas.Image = ((System.Drawing.Image)(resources.GetObject("btnSelaa_asiakas.Image")));
            this.btnSelaa_asiakas.Location = new System.Drawing.Point(12, 177);
            this.btnSelaa_asiakas.Name = "btnSelaa_asiakas";
            this.btnSelaa_asiakas.Size = new System.Drawing.Size(140, 110);
            this.btnSelaa_asiakas.TabIndex = 2;
            this.btnSelaa_asiakas.Text = "ASIAKAS";
            this.btnSelaa_asiakas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelaa_asiakas.UseVisualStyleBackColor = true;
            // 
            // btnSyota_tietoa
            // 
            this.btnSyota_tietoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyota_tietoa.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnSyota_tietoa.Image = ((System.Drawing.Image)(resources.GetObject("btnSyota_tietoa.Image")));
            this.btnSyota_tietoa.Location = new System.Drawing.Point(158, 177);
            this.btnSyota_tietoa.Name = "btnSyota_tietoa";
            this.btnSyota_tietoa.Size = new System.Drawing.Size(140, 110);
            this.btnSyota_tietoa.TabIndex = 3;
            this.btnSyota_tietoa.Text = "SYÖTÄ";
            this.btnSyota_tietoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSyota_tietoa.UseVisualStyleBackColor = true;
            this.btnSyota_tietoa.Click += new System.EventHandler(this.btnSyota_tietoa_Click);
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExitMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnExitMenu.Image")));
            this.btnExitMenu.Location = new System.Drawing.Point(258, 12);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Size = new System.Drawing.Size(40, 40);
            this.btnExitMenu.TabIndex = 4;
            this.btnExitMenu.UseVisualStyleBackColor = true;
            this.btnExitMenu.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenu.Location = new System.Drawing.Point(12, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(72, 27);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "MENU";
            // 
            // btnMinMenu
            // 
            this.btnMinMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMinMenu.Image")));
            this.btnMinMenu.Location = new System.Drawing.Point(212, 12);
            this.btnMinMenu.Name = "btnMinMenu";
            this.btnMinMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMinMenu.TabIndex = 13;
            this.btnMinMenu.UseVisualStyleBackColor = true;
            this.btnMinMenu.Click += new System.EventHandler(this.btnMinMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(313, 299);
            this.Controls.Add(this.btnMinMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnExitMenu);
            this.Controls.Add(this.btnSyota_tietoa);
            this.Controls.Add(this.btnSelaa_asiakas);
            this.Controls.Add(this.btnVaraa_mokki);
            this.Controls.Add(this.btnSelaa_mokki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelaa_mokki;
        private System.Windows.Forms.Button btnVaraa_mokki;
        private System.Windows.Forms.Button btnSelaa_asiakas;
        private System.Windows.Forms.Button btnSyota_tietoa;
        private System.Windows.Forms.Button btnExitMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnMinMenu;
    }
}

