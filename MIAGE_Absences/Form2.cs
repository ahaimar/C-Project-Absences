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
   

    public partial class Form2 : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st;

        public Form2()
        {
            InitializeComponent();
        }


        public void enregistrer()
        {
            db.cn.Open();
            st = "INSERT INTO `modules` (`codeM`, `module`, `filiere`, `formateur`, `volumeH`, `coef`, `semes`) VALUES('" + cmbnum.Text + "', '" + txtnom.Text + "', '" + txtfill.Text + "', '" + txtfor.Text + "', '" + txtvolH.Text + "', '" + txtcoef.Text + "', '" + txtsemes.Text + "')";
             cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show(" modules est bien enregistrer");


        }
        public void modifier()
        {
            db.cn.Open();
            st = "update `modules`set `codeM`='" + cmbnum.Text + "', `module`='" + txtnom.Text + "', `filiere`='" + txtfill.Text + "', `formateur`='" + txtfor.Text + "', `volumeH`='" + txtvolH.Text + "', `coef`='" + txtcoef.Text + "', `semes`='" + txtsemes.Text + "' WHERE codeM = '" + cmbnum.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show(" modules est bien Modiffier");


        }
        public void Lister()
        {
            db.cn.Open();
            st = "SELECT * FROM modules WHERE   isdeleted=0";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            db.cn.Close();
        }
        public void Lister2()
        {
            db.cn.Open();
            st = "SELECT * FROM modules WHERE   isdeleted=0 and filiere='"+txtfill.Text+"'";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            db.cn.Close();
        }
        public void supprimer()
        {
            db.cn.Open();
            st = "update  modules set isdeleted=1 where codeM = '" + cmbnum.Text + "'  ";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("LE modules est bien supprimer");

        }
        public void rechercher()
        {
            db.cn.Open();
            st = "SELECT * FROM  modules  WHERE codeM = '" + cmbnum.Text + "' and isdeleted=0";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbnum.Text = dr[0].ToString();
                txtnom.Text = dr[1].ToString();
                txtfill.Text = dr[2].ToString();
                txtfor.Text = dr[3].ToString();
                txtvolH.Text = dr[4].ToString();
                txtcoef.Text = dr[5].ToString();
                txtsemes.Text = dr[6].ToString();
                
            }
            db.cn.Close();


        }
        public void remplir()
        {
            db.cn.Open();
            st = "SELECT * FROM modules where isdeleted=0";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            cmbnum.Items.Clear();
            while (dr.Read())
            {
                cmbnum.Items.Add(dr[0]);
            }
            db.cn.Close();

        }

        private void cmbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercher();
        }

        private void mnEnregistrer_Click(object sender, EventArgs e)
        {
            enregistrer();
        }

        private void mnLister_Click(object sender, EventArgs e)
        {
            if(txtfill.Text!="")
            Lister2();
            else
                Lister();

        }

        private void mnSupprimer_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void mnRechercher_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void cmbnum_Click(object sender, EventArgs e)
        {
            remplir();
        }

        private void mnModifier_Click(object sender, EventArgs e)
        {
            modifier();
        }
    }
}
