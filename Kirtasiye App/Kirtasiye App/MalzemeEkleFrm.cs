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
    public partial class MalzemeEkleFrm : Form
    {
        public MalzemeEkleFrm()
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

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
        
            SqlCommand insert = new SqlCommand
                ("insert into malzeme (adi,stok,kategori_id) values (@p1,@p2,@p3)",connect.sqlConnection());
            insert.Parameters.AddWithValue("@p1", ad_txt.Text);
            insert.Parameters.AddWithValue("@p2", stok_txt.Text);
            insert.Parameters.AddWithValue("@p3", (comboBox1.SelectedIndex).ToString());
            insert.ExecuteNonQuery();
            connect.sqlConnection().Close();
            MessageBox.Show("Ürün sisteme girildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            getList();
            
        }

        private void MalzemeEkleFrm_Load(object sender, EventArgs e)
        {
            SqlCommand getCategory = new SqlCommand();
            getCategory.CommandText = "SELECT * FROM malzeme_kategori";
            getCategory.Connection = connect.sqlConnection();
            getCategory.CommandType = CommandType.Text;

            SqlDataReader dr;
          
            dr = getCategory.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kategori_adi"]);
            }
            connect.sqlConnection().Close();
        }
    }
}
