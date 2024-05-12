using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MIAGE_Absences
{
    public partial class Form3 : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st;
        public string nbrh;
        public Form3()
        {
            InitializeComponent();
        }
        public void Lister2()
        {
            db.cn.Open();
            st = "SELECT * FROM etudiants WHERE   isdeleted=0 and filiere='" + txtfill.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            db.cn.Close();
        }
        public void Lister3()
        {
            db.cn.Open();
            st = "SELECT * FROM modules WHERE   isdeleted=0 and filiere='" + txtfill.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            cmbmod.Items.Clear();
            while (dr.Read())
            {
                cmbmod.Items.Add(dr[1].ToString());
            }
            db.cn.Close();
        }
        public void recherchercodM()
        {
            db.cn.Open();
            st = "SELECT * FROM  modules  WHERE module = '" + cmbmod.Text + "' and isdeleted=0";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                label4.Text = dr[0].ToString();
            }
            db.cn.Close();
        }
        public void enregistrer() {
            db.cn.Open();
            
            for (int i = 0; i < DataGridView1.Rows.Count - 1; i++) {
                    string v1 = "False", v2 = "False";
                    try{
                        v1 = DataGridView1.Rows[i].Cells[3].Value.ToString();
                     }catch (Exception ex) { }
                    try
                    {
                        v2 = DataGridView1.Rows[i].Cells[4].Value.ToString();
                    }catch (Exception ex) { }

                    if (radioButton3.Checked == false) {

                        if (v1 == "True")
                        {
                            st = "INSERT INTO `miage`.`absences` (`codeE`, `codeM`, `dateab`, `houre`, `absence`) VALUES ('" + DataGridView1.Rows[i].Cells[0].Value.ToString() + "', '" + label4.Text + "', '" + dateTimePicker2.Text + "', '" + dateTimePicker3.Text + " - " + dateTimePicker1.Text + "', " + nbrh + "); ";
                            cmd = new MySqlCommand(st, db.cn);
                            cmd.ExecuteNonQuery();
                        }
                         
                    }else {
                        MessageBox.Show(v1);
                        MessageBox.Show(v2);
                            if ((v1 == "True") || (v2 == "True"))
                            {
                                if ((v1 == "True") && (v2 == "True")) { nbrh = "3"; }
                                st = "INSERT INTO `miage`.`absences` (`codeE`, `codeM`, `dateab`, `houre`, `absence`) VALUES ('" + DataGridView1.Rows[i].Cells[0].Value.ToString() + "', '" + label4.Text + "', '" + dateTimePicker2.Text + "', '" + dateTimePicker3.Text + " - " + dateTimePicker1.Text + "', " + nbrh + "); ";
                                cmd = new MySqlCommand(st, db.cn);
                                cmd.ExecuteNonQuery();
                            }
                        }
            }
            db.cn.Close();
            MessageBox.Show("Absences est bien enregistrer");
        }
        private void txtfill_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lister2();
            Lister3();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) {
                Column5.Visible = true;
            }
            else Column5.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Column5.Visible = true;
            }
            else Column5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Column5.Visible = true;
            }
            else Column5.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Column5.Visible = true;
            }
            else Column5.Visible = false;
        }

        private void cmbmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            recherchercodM();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show(DataGridView1.Rows[0].Cells[3].Value.ToString());
                
            
        }

        private void mnEnregistrer_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) nbrh="1.5";
            else if (radioButton2.Checked == true) nbrh = "2";
            else if (radioButton3.Checked == true) nbrh = "1.5";
            //MessageBox.Show(nbrh.ToString());
            enregistrer();
        }

       
        
    }
}
