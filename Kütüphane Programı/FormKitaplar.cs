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

namespace Kütüphane_Programı
{
    public partial class FormKitaplar : Form
    {
        public FormKitaplar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            DataTable tb = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from Kitaplar where Kitap_Adi='"+textBox1.Text+"'", baglanti);
            adp.Fill(tb);
            dataGridView1.DataSource = tb;
            baglanti.Close();
        }
    }
}
