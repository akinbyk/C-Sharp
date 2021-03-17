using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı1.accdb");
            if (baglanti.State != ConnectionState.Connecting)
                baglanti.Open();
            verigoruntuleme();
            
        }
        private void verigoruntuleme()
        {
            komut = new OleDbCommand();
            komut.CommandText = "Select * from Tablo1";
            komut.Connection = baglanti;
            OleDbDataReader okuyucu = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(okuyucu);
            dataGridView1.DataSource = dt;
            label5.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            komut.CommandText = "insert into Tablo1 (ad,soyad,numara) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("1 Kayıt  Eklendi");
            verigoruntuleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kimlik;
            kimlik=int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Kimlik No Giriniz","Silme","",100,100));
            komut=new OleDbCommand();
            komut.CommandText="DELETE FROM TABLO1 WHERE kimlik =" + kimlik.ToString();
            komut.Connection=baglanti;
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt silindi");
            verigoruntuleme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            komut.CommandText = "update Tablo1 set ad='"+textBox1.Text+"',soyad='"+textBox2.Text+"',numara="+textBox3.Text+"  where kimlik="+label5.Text;
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            verigoruntuleme();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ad;
            ad = Microsoft.VisualBasic.Interaction.InputBox("Adı giriniz = ", "Arama", "", 100, 100);
            komut = new OleDbCommand();
            komut.CommandText="select * from Tablo1 where ad='"+ ad +"'";
            komut.Connection = baglanti;
            OleDbDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    label5.Text = okuyucu["kimlik"].ToString();
                    textBox1.Text = okuyucu["ad"].ToString();
                    textBox2.Text = okuyucu["soyad"].ToString();
                    textBox3.Text = okuyucu["numara"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string k_no;
            k_no = Microsoft.VisualBasic.Interaction.InputBox("Adı giriniz = ", "Arama", "", 100, 100);
            komut = new OleDbCommand();
            komut.CommandText = "select * from Tablo1 where kimlik='" + k_no + "'";
            komut.Connection = baglanti;
            OleDbDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    label5.Text = okuyucu["kimlik"].ToString();
                    textBox1.Text = okuyucu["ad"].ToString();
                    textBox2.Text = okuyucu["soyad"].ToString();
                    textBox3.Text = okuyucu["numara"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }
    }
}
