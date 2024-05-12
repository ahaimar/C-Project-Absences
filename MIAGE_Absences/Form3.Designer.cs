namespace MIAGE_Absences
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbmod = new System.Windows.Forms.ComboBox();
            this.txtfill = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.Column5});
            this.DataGridView1.Location = new System.Drawing.Point(23, 324);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(884, 254);
            this.DataGridView1.TabIndex = 16;
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
            this.Column4.HeaderText = "Absence";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Absence 2eme";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.dateTimePicker3);
            this.GroupBox1.Controls.Add(this.dateTimePicker2);
            this.GroupBox1.Controls.Add(this.panel1);
            this.GroupBox1.Controls.Add(this.dateTimePicker1);
            this.GroupBox1.Controls.Add(this.cmbmod);
            this.GroupBox1.Controls.Add(this.txtfill);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(23, 74);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(884, 227);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Information Absences";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "hh:mm";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(578, 98);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(92, 26);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(578, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 86);
            this.panel1.TabIndex = 7;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(267, 44);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 24);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3h";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(156, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "2h";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "1h30min";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre d\'heures";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(686, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cmbmod
            // 
            this.cmbmod.FormattingEnabled = true;
            this.cmbmod.Items.AddRange(new object[] {
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
            this.cmbmod.Location = new System.Drawing.Point(126, 178);
            this.cmbmod.Name = "cmbmod";
            this.cmbmod.Size = new System.Drawing.Size(206, 28);
            this.cmbmod.TabIndex = 4;
            this.cmbmod.SelectedIndexChanged += new System.EventHandler(this.cmbmod_SelectedIndexChanged);
            // 
            // txtfill
            // 
            this.txtfill.FormattingEnabled = true;
            this.txtfill.Items.AddRange(new object[] {
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
            this.txtfill.Location = new System.Drawing.Point(126, 130);
            this.txtfill.Name = "txtfill";
            this.txtfill.Size = new System.Drawing.Size(206, 28);
            this.txtfill.TabIndex = 3;
            this.txtfill.SelectedIndexChanged += new System.EventHandler(this.txtfill_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filiere";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(43, 183);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 15);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Module";
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
            this.ToolStrip1.Size = new System.Drawing.Size(935, 39);
            this.ToolStrip1.TabIndex = 21;
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 590);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.DataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox txtfill;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label2;
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
        private System.Windows.Forms.ComboBox cmbmod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}