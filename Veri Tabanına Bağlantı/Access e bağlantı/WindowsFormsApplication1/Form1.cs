using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection com = new OleDbConnection();
            com.ConnectionString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
            com.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText="select * from Tablo1";
            komut.Connection=com;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("Kimlik: " + reader["Kimlik"] + "Ad: " + reader["Ad"] + "Soyad: " + reader["Soyad"] + "Yaş: " + reader["Yas"]);
                
            }
            com.Close();

        }
    }
}
