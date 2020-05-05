namespace Mokkivaraaja9000
{
    partial class Lisaapalvelu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lisaapalvelu2));
            this.lpminbtn = new System.Windows.Forms.Button();
            this.lpbackbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lisaapalvelubtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lpminbtn
            // 
            this.lpminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lpminbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpminbtn.Image = ((System.Drawing.Image)(resources.GetObject("lpminbtn.Image")));
            this.lpminbtn.Location = new System.Drawing.Point(365, 12);
            this.lpminbtn.Name = "lpminbtn";
            this.lpminbtn.Size = new System.Drawing.Size(39, 33);
            this.lpminbtn.TabIndex = 17;
            this.lpminbtn.UseVisualStyleBackColor = true;
            this.lpminbtn.Click += new System.EventHandler(this.lpminbtn_Click);
            // 
            // lpbackbtn
            // 
            this.lpbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lpbackbtn.Image = ((System.Drawing.Image)(resources.GetObject("lpbackbtn.Image")));
            this.lpbackbtn.Location = new System.Drawing.Point(410, 12);
            this.lpbackbtn.Name = "lpbackbtn";
            this.lpbackbtn.Size = new System.Drawing.Size(37, 33);
            this.lpbackbtn.TabIndex = 18;
            this.lpbackbtn.UseVisualStyleBackColor = true;
            this.lpbackbtn.Click += new System.EventHandler(this.lpbackbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nimi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kuvaus";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(172, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 96);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hinta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            // 
            // lisaapalvelubtn
            // 
            this.lisaapalvelubtn.Location = new System.Drawing.Point(172, 307);
            this.lisaapalvelubtn.Name = "lisaapalvelubtn";
            this.lisaapalvelubtn.Size = new System.Drawing.Size(121, 49);
            this.lisaapalvelubtn.TabIndex = 25;
            this.lisaapalvelubtn.Text = "Tallenna";
            this.lisaapalvelubtn.UseVisualStyleBackColor = true;
            this.lisaapalvelubtn.Click += new System.EventHandler(this.lisaapalvelubtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Lisää palvelu";
            // 
            // Lisaapalvelu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(467, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lisaapalvelubtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lpbackbtn);
            this.Controls.Add(this.lpminbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lisaapalvelu2";
            this.Text = "Lisaapalvelu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lpminbtn;
        private System.Windows.Forms.Button lpbackbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button lisaapalvelubtn;
        private System.Windows.Forms.Label label4;
    }
}