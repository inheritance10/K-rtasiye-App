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
    public partial class MalzemelerForm : Form
    {
        public MalzemelerForm()
        {
            InitializeComponent();
        }
        sqlBaglanti connect = new sqlBaglanti();

        MalzemeCikisFrm malzemeCikisFrm;

        void getList()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand("SELECT malzeme.id as 'ID', kategori.kategori_adi as 'Kategori', malzeme.adi as 'Malzeme Adı', malzeme.stok as 'Stok' FROM malzeme AS malzeme INNER JOIN malzeme_kategori AS kategori ON kategori.id = malzeme.kategori_id", connect.sqlConnection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            gridControl1.DataSource = data;
        }
        private void MalzemelerForm_Load(object sender, EventArgs e)
        {
            getList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            malzemeCikisFrm = new MalzemeCikisFrm();
   
            DataRow rowData = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            malzemeCikisFrm.malzemeAd_txt.Text = rowData["Malzeme Adı"].ToString();
            malzemeCikisFrm.kategoriAd_txt.Text = rowData["Kategori"].ToString();
            malzemeCikisFrm.stok_txt.Text = rowData["Stok"].ToString();
            malzemeCikisFrm.id_txt.Text = rowData["ID"].ToString();
            malzemeCikisFrm.Show();

            //GridView search ederken bazen hata alıyorum sebebini anladım ama çözemedim


        }
    }
}
