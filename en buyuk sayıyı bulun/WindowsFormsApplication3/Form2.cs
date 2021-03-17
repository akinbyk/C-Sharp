using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Okul.accdb;");
        OleDbDataAdapter Adp;
        DataSet ds = new DataSet();
        OleDbCommand komut = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            komut.CommandText = "select * from Kullanici where kullanici = '" + kullaniciadi + "' and sifre ='" + sifre + "'";
            komut.Connection = conn;
            OleDbDataReader reader;
            conn.Open();
            reader = komut.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (textBox1.Text == reader["kullanici"].ToString() && textBox2.Text == reader["sifre"].ToString())
                    {
                        Form1 frm1 = new Form1();
                        frm1.Text = textBox1.Text + " İsimli Kullanıcı";
                        frm1.Show();
                    }
                }
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            conn.Close();

        }
    }
}
