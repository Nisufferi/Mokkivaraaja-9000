namespace Mokkivaraaja9000
{
    partial class mokkitietokanta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mokkitietokanta));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toimipisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkitietokantaDataSet = new Mokkivaraaja9000.mokkitietokantaDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.toimipisteTableAdapter = new Mokkivaraaja9000.mokkitietokantaDataSetTableAdapters.ToimipisteTableAdapter();
            this.tableAdapterManager = new Mokkivaraaja9000.mokkitietokantaDataSetTableAdapters.TableAdapterManager();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblMokit = new System.Windows.Forms.Label();
            this.btnEtsimokki = new System.Windows.Forms.Button();
            this.cbLisapalvelut = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mcKalenteri = new System.Windows.Forms.MonthCalendar();
            this.cbPaikka = new System.Windows.Forms.ComboBox();
            this.cbHlomaara = new System.Windows.Forms.ComboBox();
            this.toimipisteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postitoimipaikkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkitietokantaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimipisteidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.postitoimipaikkaDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toimipisteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toimipisteBindingSource
            // 
            this.toimipisteBindingSource.DataMember = "Toimipiste";
            this.toimipisteBindingSource.DataSource = this.mokkitietokantaDataSet;
            // 
            // mokkitietokantaDataSet
            // 
            this.mokkitietokantaDataSet.DataSetName = "mokkitietokantaDataSet";
            this.mokkitietokantaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(748, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // toimipisteTableAdapter
            // 
            this.toimipisteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsiakasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaskuTableAdapter = null;
            this.tableAdapterManager.PalveluTableAdapter = null;
            this.tableAdapterManager.ToimipisteTableAdapter = this.toimipisteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mokkivaraaja9000.mokkitietokantaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Varauksen_palvelutTableAdapter = null;
            this.tableAdapterManager.VarausTableAdapter = null;
            // 
            // btnMin
            // 
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(702, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 40);
            this.btnMin.TabIndex = 23;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblMokit
            // 
            this.lblMokit.AutoSize = true;
            this.lblMokit.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMokit.Location = new System.Drawing.Point(12, 9);
            this.lblMokit.Name = "lblMokit";
            this.lblMokit.Size = new System.Drawing.Size(83, 27);
            this.lblMokit.TabIndex = 8;
            this.lblMokit.Text = "MÖKKI";
            // 
            // btnEtsimokki
            // 
            this.btnEtsimokki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtsimokki.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnEtsimokki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEtsimokki.Image = ((System.Drawing.Image)(resources.GetObject("btnEtsimokki.Image")));
            this.btnEtsimokki.Location = new System.Drawing.Point(728, 163);
            this.btnEtsimokki.Name = "btnEtsimokki";
            this.btnEtsimokki.Size = new System.Drawing.Size(60, 60);
            this.btnEtsimokki.TabIndex = 31;
            this.btnEtsimokki.UseVisualStyleBackColor = true;
            this.btnEtsimokki.Click += new System.EventHandler(this.btnEtsimokki_Click);
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
            this.cbLisapalvelut.Location = new System.Drawing.Point(435, 78);
            this.cbLisapalvelut.Name = "cbLisapalvelut";
            this.cbLisapalvelut.Size = new System.Drawing.Size(120, 90);
            this.cbLisapalvelut.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(431, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Lisäpalvelut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(256, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Henkilömäärä";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(256, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Paikkakunta";
            // 
            // mcKalenteri
            // 
            this.mcKalenteri.BackColor = System.Drawing.SystemColors.Window;
            this.mcKalenteri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.mcKalenteri.Location = new System.Drawing.Point(17, 55);
            this.mcKalenteri.Name = "mcKalenteri";
            this.mcKalenteri.TabIndex = 26;
            // 
            // cbPaikka
            // 
            this.cbPaikka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPaikka.FormattingEnabled = true;
            this.cbPaikka.Location = new System.Drawing.Point(260, 132);
            this.cbPaikka.Name = "cbPaikka";
            this.cbPaikka.Size = new System.Drawing.Size(150, 21);
            this.cbPaikka.TabIndex = 25;
            // 
            // cbHlomaara
            // 
            this.cbHlomaara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHlomaara.FormattingEnabled = true;
            this.cbHlomaara.Location = new System.Drawing.Point(260, 78);
            this.cbHlomaara.Name = "cbHlomaara";
            this.cbHlomaara.Size = new System.Drawing.Size(56, 21);
            this.cbHlomaara.TabIndex = 24;
            // 
            // toimipisteidDataGridViewTextBoxColumn
            // 
            this.toimipisteidDataGridViewTextBoxColumn.DataPropertyName = "toimipiste_id";
            this.toimipisteidDataGridViewTextBoxColumn.HeaderText = "toimipiste_id";
            this.toimipisteidDataGridViewTextBoxColumn.Name = "toimipisteidDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            // 
            // postitoimipaikkaDataGridViewTextBoxColumn
            // 
            this.postitoimipaikkaDataGridViewTextBoxColumn.DataPropertyName = "postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.HeaderText = "postitoimipaikka";
            this.postitoimipaikkaDataGridViewTextBoxColumn.Name = "postitoimipaikkaDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            // 
            // mokkitietokanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(803, 580);
            this.Controls.Add(this.btnEtsimokki);
            this.Controls.Add(this.cbLisapalvelut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcKalenteri);
            this.Controls.Add(this.cbPaikka);
            this.Controls.Add(this.cbHlomaara);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMokit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mokkitietokanta";
            this.Text = "mokkitietokanta";
            this.Load += new System.EventHandler(this.mokkitietokanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkitietokantaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private mokkitietokantaDataSet mokkitietokantaDataSet;
        private System.Windows.Forms.BindingSource toimipisteBindingSource;
        private mokkitietokantaDataSetTableAdapters.ToimipisteTableAdapter toimipisteTableAdapter;
        private mokkitietokantaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lblMokit;
        private System.Windows.Forms.Button btnEtsimokki;
        private System.Windows.Forms.CheckedListBox cbLisapalvelut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcKalenteri;
        private System.Windows.Forms.ComboBox cbPaikka;
        private System.Windows.Forms.ComboBox cbHlomaara;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimipisteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postitoimipaikkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
    }
}