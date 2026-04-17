using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciYönetimSistemiform
{
    public partial class Form1 : Form
    {
        DataTable ogrenciTablosu;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciTablosu = new DataTable();
            ogrenciTablosu.Columns.Add("Öğrenci Adı", typeof(string));
            ogrenciTablosu.Columns.Add("Öğrenci Soyadı", typeof(string));
            ogrenciTablosu.Columns.Add("Öğrenci Cinsiyeti", typeof(string));
            dataGridView1.DataSource = ogrenciTablosu;
        }
      


        private void eklebtn_Click(object sender, EventArgs e)
        {
            if(ogrenciAdiText.Text.Length > 0 && ogrenciSoyadiText.Text.Length>0 && ogrenciErkek.Checked ||ogrenciKadin.Checked) 
            {
                ogrenciTablosu.Rows.Add(ogrenciAdiText.Text, ogrenciSoyadiText.Text, (ogrenciErkek.Checked) ? ("Erkek") : ("Kadın"));
                MessageBox.Show("Öğrenci kaydı yapıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olunuz.");
            }
        }

        
    }
}
