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
    public partial class MalzemeCikisFrm : Form
    {
        public MalzemeCikisFrm()
        {
            InitializeComponent();
        }
        sqlBaglanti connect = new sqlBaglanti();

        MalzemelerForm formMalzeme = new MalzemelerForm();

        void getList()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand("SELECT kategori.kategori_adi as 'Kategori', malzeme.adi as 'Malzeme Adı', malzeme.stok as 'Stok' FROM malzeme AS malzeme INNER JOIN malzeme_kategori AS kategori ON kategori.id = malzeme.kategori_id", connect.sqlConnection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            formMalzeme.gridControl1.DataSource = data;
        }
        private void malzeme_cikis_btn_Click(object sender, EventArgs e)
        {
            int kalan_adet = int.Parse(stok_txt.Text) - int.Parse(adet_txt.Text);
            if(kalan_adet < 0)
            {
                MessageBox.Show("Çıkış Adedi Stok adedinden fazladır.Malzeme çıkışı yapılamaz", "Malzeme Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand update = new SqlCommand
                ("update malzeme set stok = @p1 where id = @p2", connect.sqlConnection());
                update.Parameters.AddWithValue("@p1", kalan_adet.ToString());
                update.Parameters.AddWithValue("@p2", (id_txt.Text).ToString());
                update.ExecuteNonQuery();
                connect.sqlConnection().Close();
                MessageBox.Show("Ürün Çıkışı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
