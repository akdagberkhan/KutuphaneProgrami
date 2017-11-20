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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.mdb");

        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            pnl_formalan.Controls.Clear();
            FormKitaplar frmkitap = new FormKitaplar();
            frmkitap.TopLevel = false;
            pnl_formalan.Controls.Add(frmkitap);
            frmkitap.BringToFront();
            frmkitap.Show();

            baglanti.Open();
            DataTable tb = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from Kitaplar",baglanti);
            adp.Fill(tb);
            frmkitap.dataGridView1.DataSource = tb;
            baglanti.Close();

        }

        private void btn_kitapislem_Click(object sender, EventArgs e)
        {
            pnl_formalan.Controls.Clear();
            FormKitapIslem frmkitapislem = new FormKitapIslem();
            frmkitapislem.TopLevel = false;
            pnl_formalan.Controls.Add(frmkitapislem);
            frmkitapislem.BringToFront();
            frmkitapislem.Show();
        }

        private void btn_emanetTakip_Click(object sender, EventArgs e)
        {
            pnl_formalan.Controls.Clear();
            FormKitapEmanetTakip frmkitapemanettakip = new FormKitapEmanetTakip();
            frmkitapemanettakip.TopLevel = false;
            pnl_formalan.Controls.Add(frmkitapemanettakip);
            frmkitapemanettakip.BringToFront();
            frmkitapemanettakip.Show();
        }
    }
}
