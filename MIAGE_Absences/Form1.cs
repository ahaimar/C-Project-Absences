using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace MIAGE_Absences
{
    public partial class Form1 : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st,imgpath;

        public Form1()
        {
            InitializeComponent();
        }
        public void enregistrer()
        {
            db.cn.Open();
            st = "INSERT INTO `etudiants` (`codeE`, `nom`, `prenom`, `filiere`, `adresse`, `telephone`, `whatsapp`, `telephonePar`, `email`, `datenaissance`, `niveau`, `photo`, `status`, `commantaire`) VALUES('" + cmbnum.Text + "', '" + txtnom.Text + "', '" + txtpre.Text + "', '" + txtfil.Text + "', '" + txtad.Text + "', '" + txttel.Text + "', '" + txtwat.Text + "', '" + txttelp.Text + "', '" + txtema.Text + "', '" + dateTimePicker1.Text + "', '" + txtniv.Text + "', '" + imgpath + "', '1', '" + txtcomm.Text + "');";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("L' Etudiant est bien enregistrer");


        }
        public void modifier()
        {
            
           
            db.cn.Open();
            st = "update `etudiants` set `codeE`='" + cmbnum.Text + "', `nom`='" + txtnom.Text + "', `prenom`='" + txtpre.Text + "', `filiere`='" + txtfil.Text + "', `adresse`='" + txtad.Text + "', `telephone`='" + txttel.Text + "', `whatsapp`='" + txtwat.Text + "', `telephonePar`= '" + txttelp.Text + "', `email`='" + txtema.Text + "', `datenaissance`='" + dateTimePicker1.Text + "', `niveau`='" + txtniv.Text + "', `photo`='" + imgpath + "', `status`= '1' , `commantaire`= '" + txtcomm.Text + "' WHERE codeE = '" + cmbnum.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("L' Etudiant est bien :modifier");


        }
        public void remplir() {
            db.cn.Open();
            st = "SELECT * FROM etudiants where isdeleted=0";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            cmbnum.Items.Clear();
            while (dr.Read()) {
                cmbnum.Items.Add(dr[0]);
            }
            db.cn.Close();

        }
        public void rechercher()
        {
            db.cn.Open();
            st = "SELECT * FROM etudiants WHERE codeE = '" + cmbnum.Text + "' and isdeleted=0";
            cmd = new MySqlCommand(st,db.cn);
            dr = cmd.ExecuteReader();
          
            while(dr.Read())
            {
                cmbnum.Text = dr[0].ToString();
                txtnom.Text = dr[1].ToString();
                txtpre.Text = dr[2].ToString(); 
                txtfil.Text = dr[3].ToString();
                txtad.Text = dr[4].ToString(); 
                txttel.Text = dr[5].ToString(); 
                txtwat.Text = dr[6].ToString(); 
                txttelp.Text = dr[7].ToString();
                txtema.Text = dr[8].ToString();
                dateTimePicker1.Text = dr[9].ToString(); 
                txtniv.Text = dr[10].ToString();
                pictureBox1.Load("http://192.168.15.31/images/"+dr[11].ToString());
                imgpath = dr[11].ToString();
                txtsta.Text = dr[12].ToString(); 
                txtcomm.Text = dr[13].ToString();
            }
            db.cn.Close();


        }
        public void supprimer() {
            db.cn.Open();
            st = "update  etudiants set isdeleted=1 where codeE = '" + cmbnum.Text + "'  ";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("L' Etudiant est bien supprimer");
        
        }
        public void Lister()
        {
            db.cn.Open();
            st = "SELECT * FROM etudiants WHERE   isdeleted=0";
            cmd = new MySqlCommand(st,db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while(dr.Read()){
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[9].ToString(), dr[12].ToString());   
            }
            db.cn.Close();
        }
        public void Lister2()
        {
            db.cn.Open();
            st = "SELECT * FROM etudiants WHERE   isdeleted=0 and filiere='"+txtfil.Text+"'";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[5].ToString(), dr[9].ToString(), dr[12].ToString());
            }
            db.cn.Close();
        }
                
        private void mnEnregistrer_Click(object sender, EventArgs e)
        {
            imgpath = "avatar.jpg";
            try
            {
                WebClient cl = new WebClient();
                cl.UploadFile("http://192.168.15.31/upload.php", openFileDialog1.FileName);
                imgpath = openFileDialog1.SafeFileName.ToString();
            }
            catch (Exception ex) { }

            enregistrer();
        }

        private void RomKlick(object sender, EventArgs e)
        {
            remplir();//<---------------- 
          
        }

        private void mnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                rechercher();

            }
            catch (Exception ex)
            {
            }
        }

        private void cmbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercher();//<-----------

        }

        private void mnSupprimer_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void mnLister_Click(object sender, EventArgs e)
        {
            if (txtfil.Text != "")
                Lister2();
            else
                Lister();
        }

        private void mnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient cl = new WebClient();
                cl.UploadFile("http://192.168.15.31/upload.php", openFileDialog1.FileName);
               
            }
            catch (Exception ex) { }

            modifier();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try { 
                openFileDialog1.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imgpath = openFileDialog1.SafeFileName.ToString();
            }catch(Exception ex){}
           
        }
    }
}
