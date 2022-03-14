using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Veri_Tabanı_Bağlama._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection connection;
        OleDbDataAdapter adapter;
        DataTable data;
        OleDbCommand command;


        private void Form1_Load(object sender, EventArgs e)
        {
            Bağlantı();
        }
        private void Bağlantı()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Utku1.accdb");
            adapter = new OleDbDataAdapter("select*from okul", connection);
            data = new DataTable();
            connection.Open();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into Okul(Adi,Soyadi,Numarasi,Sinifi) values('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtNumarasi.Text + "','" + txtSinifi.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();
            Bağlantı();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSıra_No.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNumarasi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSinifi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "delete from Okul where Sıra_No=" + txtSıra_No.Text + "";
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "update Okul set Adi='" + txtAdi.Text + "',Soyadi='" + txtSoyadi.Text + "',Numarasi='" + txtNumarasi.Text + "' where Sıra_No=" + txtSıra_No.Text + "";
            command.ExecuteNonQuery();
            connection.Close();
            Bağlantı();
        }
    }
}
