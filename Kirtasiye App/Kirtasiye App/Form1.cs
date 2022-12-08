using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kirtasiye_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MalzemelerForm formMalzeme;
        MalzemeEkleFrm formMalzemeEkle;
        sqlBaglanti connect = new sqlBaglanti();
        private void malzemelerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(formMalzeme == null)
            {
                formMalzeme = new MalzemelerForm();
                formMalzeme.MdiParent = this;
                formMalzeme.Show();
            }
        }

        private void malzemeEkleBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formMalzemeEkle == null)
            {
                formMalzemeEkle = new MalzemeEkleFrm();
                formMalzemeEkle.MdiParent = this;
                formMalzemeEkle.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand("SELECT kategori.kategori_adi as 'Kategori', malzeme.adi as 'Malzeme Adı', malzeme.stok as 'Stok' FROM malzeme AS malzeme INNER JOIN malzeme_kategori AS kategori ON kategori.id = malzeme.kategori_id", connect.sqlConnection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            formMalzeme.gridControl1.DataSource = data;
        }

        private void barEditItem2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void barEditItem2_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //search ama devExp gridControl kendisi verdiği icin yapmadım.

            /*DataTable data = new DataTable();
            SqlCommand command = new SqlCommand("SELECT kategori.kategori_adi as 'Kategori', malzeme.adi as 'Malzeme Adı', malzeme.stok as 'Stok' FROM malzeme AS malzeme INNER JOIN malzeme_kategori AS kategori ON kategori.id = malzeme.kategori_id where adi = @p1", connect.sqlConnection());
            command.Parameters.AddWithValue("@p1", (textBox1.Text).ToString());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            formMalzeme.gridControl1.DataSource = data;*/
        }
    }
}
