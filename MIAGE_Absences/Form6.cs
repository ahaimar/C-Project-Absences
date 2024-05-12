using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
namespace MIAGE_Absences
{
    public partial class Form6 : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st, imgpath;
        public string key = "b14ca5898a4e4133bbce2ea2315a1911";
        public Form6()
        {
            InitializeComponent();
        }
        public void enregistrer()
        {
            
            string encryptedString = strEncrip.EncryptString(key, textBox4.Text);
            

            db.cn.Open();
            st = "INSERT INTO `miage`.`users` (`username`, `passw`) VALUES ('" + textBox3.Text + "', '" + encryptedString + "');";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("L' user est bien enregistrer");


        }
        public void loginuser(){



            string encryptedString = strEncrip.EncryptString(key, textBox2.Text);
            db.cn.Open();
            st = "SELECT * FROM users where username='" + textBox1.Text + "' and passw='" + encryptedString + "' and isactivated=1";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                menuStrip1.Enabled = true;

            }
            else
                MessageBox.Show("Nom d'utilisateur ou le mot de passe incorect");
            db.cn.Close();
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            enregistrer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginuser();
        }

        private void abToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void etToolStripMenuItem_Click(object sender, EventArgs e)
        {
             new Form1().Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}