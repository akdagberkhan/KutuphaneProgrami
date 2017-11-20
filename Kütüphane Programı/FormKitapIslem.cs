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
    public partial class FormKitapIslem : Form
    {
        public FormKitapIslem()
        {
            InitializeComponent();
        }
        string kitapdurum = "Kütüphane";
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.mdb");

        private void FormKitapIslem_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand("insert into Kitaplar(Kitap_No,Kitap_Adi,Yazar_Adi,Yayin_Evi,Kitap_Turu,Basim_Yili,Sayfa_Sayisi,Kayit_Tarihi,Ekleyen,Kitap_Durumu,Raf) values('"+txt_kitapno.Text+ "','" + txt_kitapad.Text + "','"+txt_yazarad.Text+ "','"+txt_yayinev.Text+ "','"+cbox_tur.Text+ "','"+maskedtxt_basimyil.Text+ "','"+txt_sayfasayisi.Text+ "','"+dtpicker_kayittarih.Value+ "','"+txt_ekleyen.Text+ "','"+kitapdurum+ "','"+cbox_raf.Text+"')",baglanti);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            baglanti.Close();

            txt_kitapno.Text = "";
            txt_kitapad.Text = "";
            txt_yazarad.Text = "";
            txt_yayinev.Text = "";
          
            txt_sayfasayisi.Text = "";
            txt_ekleyen.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand("update Kitaplar set Kitap_No="+textBox6.Text+ ",Kitap_Adi='" + textBox5.Text+ "',Yazar_Adi='" + textBox4.Text+ "',Yayin_Evi='" + textBox3.Text+ "',Kitap_Turu='" + comboBox2.Text+ "',Basim_Yili=" + maskedTextBox1.Text+ ",Sayfa_Sayisi='" + textBox2.Text+ "',Kayit_Tarihi='" + dateTimePicker1.Text+ "',Ekleyen='" + textBox1.Text+ "',Kitap_Durumu='" + comboBox3.Text+"',Raf='"+comboBox1.Text+ "' where Kitap_No=" +txt_guncellenecek.Text+"",baglanti);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kitap Başarıyla Güncellendi");
            baglanti.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand("delete from Kitaplar where Kitap_No="+txt_kitapsil.Text+"",baglanti);
            sil.ExecuteNonQuery();
            MessageBox.Show("Kitap Başarıyla Silindi");
            baglanti.Close();
        }
    }
}
