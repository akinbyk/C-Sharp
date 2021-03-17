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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Okul.accdb;");
        OleDbDataAdapter Adp;
        DataSet ds = new DataSet();
        OleDbCommand komut = new OleDbCommand();



        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.CommandText = "insert into Kullanici (kullanici, sifre) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            komut.Connection = conn;
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            texttemizle();
            gridguncelle();
        }
        void gridguncelle()
        {
            ds.Clear();
            Adp = new OleDbDataAdapter("select * from Kullanici", conn);
            Adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void texttemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gridguncelle();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text;
            komut.CommandText = "select * from Kullanici where kullanici = '" + ara + "'";
            komut.Connection = conn;
            OleDbDataReader reader;
            conn.Open();
            reader = komut.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox1.Text = reader["kullanici"].ToString();
                    textBox2.Text = reader["sifre"].ToString();
                }
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text;
            komut.CommandText = "update Kullanici set kullanici='" + textBox1.Text + "',Sifre='" + textBox2.Text + "'where kullanici='" + ara + "'";
            komut.Connection = conn;
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            gridguncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ara = textBox1.Text;
            komut.CommandText = "delete from Kullanici where kullanici = '" + ara + "'";
            komut.Connection = conn;
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Silindi");
            gridguncelle();
        }
    }
}


