namespace MIAGE_Absences
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEnregistrer = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnRechercher = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnLister = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnModifier = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSupprimer = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfil = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcomm = new System.Windows.Forms.TextBox();
            this.txtema = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtwat = new System.Windows.Forms.TextBox();
            this.txttelp = new System.Windows.Forms.TextBox();
            this.txtsta = new System.Windows.Forms.TextBox();
            this.txtniv = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbnum = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ToolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/M/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(450, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator1,
            this.mnEnregistrer,
            this.ToolStripSeparator2,
            this.mnRechercher,
            this.ToolStripSeparator3,
            this.mnLister,
            this.ToolStripSeparator4,
            this.mnModifier,
            this.ToolStripSeparator5,
            this.mnSupprimer,
            this.ToolStripSeparator6,
            this.toolStripButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(920, 39);
            this.ToolStrip1.TabIndex = 16;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // mnEnregistrer
            // 
            this.mnEnregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("mnEnregistrer.Image")));
            this.mnEnregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnEnregistrer.Name = "mnEnregistrer";
            this.mnEnregistrer.Size = new System.Drawing.Size(36, 36);
            this.mnEnregistrer.Text = "ToolStripButton2";
            this.mnEnregistrer.ToolTipText = "Enregistrer";
            this.mnEnregistrer.Click += new System.EventHandler(this.mnEnregistrer_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // mnRechercher
            // 
            this.mnRechercher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("mnRechercher.Image")));
            this.mnRechercher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnRechercher.Name = "mnRechercher";
            this.mnRechercher.Size = new System.Drawing.Size(36, 36);
            this.mnRechercher.Text = "ToolStripButton3";
            this.mnRechercher.ToolTipText = "Rechercher";
            this.mnRechercher.Click += new System.EventHandler(this.mnRechercher_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // mnLister
            // 
            this.mnLister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnLister.Image = ((System.Drawing.Image)(resources.GetObject("mnLister.Image")));
            this.mnLister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnLister.Name = "mnLister";
            this.mnLister.Size = new System.Drawing.Size(36, 36);
            this.mnLister.Text = "ToolStripButton4";
            this.mnLister.ToolTipText = "Lister";
            this.mnLister.Click += new System.EventHandler(this.mnLister_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // mnModifier
            // 
            this.mnModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnModifier.Image = ((System.Drawing.Image)(resources.GetObject("mnModifier.Image")));
            this.mnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnModifier.Name = "mnModifier";
            this.mnModifier.Size = new System.Drawing.Size(36, 36);
            this.mnModifier.Text = "ToolStripButton5";
            this.mnModifier.ToolTipText = "Modifier";
            this.mnModifier.Click += new System.EventHandler(this.mnModifier_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // mnSupprimer
            // 
            this.mnSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("mnSupprimer.Image")));
            this.mnSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnSupprimer.Name = "mnSupprimer";
            this.mnSupprimer.Size = new System.Drawing.Size(36, 36);
            this.mnSupprimer.Text = "ToolStripButton6";
            this.mnSupprimer.ToolTipText = "Supprimer";
            this.mnSupprimer.Click += new System.EventHandler(this.mnSupprimer_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MIAGE_Absences.Properties.Resources._2432797;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtfil);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.dateTimePicker1);
            this.GroupBox1.Controls.Add(this.txtcomm);
            this.GroupBox1.Controls.Add(this.txtema);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label14);
            this.GroupBox1.Controls.Add(this.txttel);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.txtwat);
            this.GroupBox1.Controls.Add(this.txttelp);
            this.GroupBox1.Controls.Add(this.txtsta);
            this.GroupBox1.Controls.Add(this.txtniv);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.txtad);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.label13);
            this.GroupBox1.Controls.Add(this.txtpre);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.txtnom);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.cmbnum);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 65);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(884, 364);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Information Etudiants";
            // 
            // txtfil
            // 
            this.txtfil.FormattingEnabled = true;
            this.txtfil.Items.AddRange(new object[] {
            "TS1 DI",
            "TS2 DI",
            "TS1 SR",
            "TS2 SR",
            "TS1 GE",
            "TS2 GE",
            "T1 GI",
            "T2 GI",
            "TS1 DM",
            "TS2 DM",
            "DQ"});
            this.txtfil.Location = new System.Drawing.Point(117, 213);
            this.txtfil.Name = "txtfil";
            this.txtfil.Size = new System.Drawing.Size(162, 28);
            this.txtfil.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(684, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtcomm
            // 
            this.txtcomm.Location = new System.Drawing.Point(450, 258);
            this.txtcomm.Multiline = true;
            this.txtcomm.Name = "txtcomm";
            this.txtcomm.Size = new System.Drawing.Size(166, 51);
            this.txtcomm.TabIndex = 2;
            // 
            // txtema
            // 
            this.txtema.Location = new System.Drawing.Point(450, 218);
            this.txtema.Name = "txtema";
            this.txtema.Size = new System.Drawing.Size(166, 26);
            this.txtema.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date N";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(362, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Commantaire";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(450, 173);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(166, 26);
            this.txttel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // txtwat
            // 
            this.txtwat.Location = new System.Drawing.Point(450, 123);
            this.txtwat.Name = "txtwat";
            this.txtwat.Size = new System.Drawing.Size(166, 26);
            this.txtwat.TabIndex = 2;
            // 
            // txttelp
            // 
            this.txttelp.Location = new System.Drawing.Point(450, 74);
            this.txttelp.Name = "txttelp";
            this.txttelp.Size = new System.Drawing.Size(166, 26);
            this.txttelp.TabIndex = 2;
            // 
            // txtsta
            // 
            this.txtsta.Location = new System.Drawing.Point(117, 307);
            this.txtsta.Name = "txtsta";
            this.txtsta.Size = new System.Drawing.Size(166, 26);
            this.txtsta.TabIndex = 2;
            // 
            // txtniv
            // 
            this.txtniv.Location = new System.Drawing.Point(117, 261);
            this.txtniv.Name = "txtniv";
            this.txtniv.Size = new System.Drawing.Size(166, 26);
            this.txtniv.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(356, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Whatsapp";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(117, 162);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(166, 26);
            this.txtad.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Telephone Par";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Filiere";
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(117, 117);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(166, 26);
            this.txtpre.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Niveau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adresse";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(117, 77);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(166, 26);
            this.txtnom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom";
            // 
            // cmbnum
            // 
            this.cmbnum.FormattingEnabled = true;
            this.cmbnum.Location = new System.Drawing.Point(117, 34);
            this.cmbnum.Name = "cmbnum";
            this.cmbnum.Size = new System.Drawing.Size(166, 28);
            this.cmbnum.TabIndex = 1;
            this.cmbnum.SelectedIndexChanged += new System.EventHandler(this.cmbnum_SelectedIndexChanged);
            this.cmbnum.Click += new System.EventHandler(this.RomKlick);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(34, 81);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 15);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Nom";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(34, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Code";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DataGridView1.Location = new System.Drawing.Point(12, 454);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(884, 254);
            this.DataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prénom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Filiere";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telephone";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date N";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 720);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Etudiants";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton mnEnregistrer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton mnRechercher;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton mnLister;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton mnModifier;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton mnSupprimer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtema;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txttel;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtpre;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbnum;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TextBox txtwat;
        internal System.Windows.Forms.TextBox txttelp;
        internal System.Windows.Forms.TextBox txtsta;
        internal System.Windows.Forms.TextBox txtniv;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtad;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox txtcomm;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox txtfil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

