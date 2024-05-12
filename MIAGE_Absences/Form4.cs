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
    public partial class Form4 : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st;

        public Form4()
        {
            InitializeComponent();
        }
        public void Lister2()
        {
            db.cn.Open();
            st = "SELECT etudiants.codeE,etudiants.nom,etudiants.prenom, SUM(absences.absence) FROM etudiants,absences WHERE etudiants.codeE=absences.codeE AND absences.codeM='"+label4.Text+"' GROUP BY etudiants.codeE,etudiants.nom,etudiants.prenom";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                float pr = (float.Parse(dr[3].ToString()) * 100) / float.Parse(label5.Text);
                string pr2 = pr.ToString("F2");
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), pr2 + "%");
            }
            db.cn.Close();
        }
        public void Lister4()
        {
            db.cn.Open();
            st = "SELECT * FROM etudiants WHERE etudiants.codeE NOT IN (SELECT etudiants.codeE FROM etudiants JOIN absences ON absences.codeE=etudiants.codeE WHERE  absences.codeM='"+label4.Text+"');";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
           // DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "0", "0%");
            
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
                label5.Text = dr[4].ToString();
            }
            db.cn.Close();
        }
        private void txtfill_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lister3();
        }

        private void cmbmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            recherchercodM();
            Lister2();
            Lister4();
        }
       
    }
}
