using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MIAGE_Absences
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrystalReport11.SetParameterValue("numet", comboBox1.Text);
            crystalReportViewer1.ReportSource = CrystalReport11;
            crystalReportViewer1.Refresh();
        }

        
    }
}
