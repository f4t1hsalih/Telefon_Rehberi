using System.Data;
using System.Data.SqlClient;

namespace Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbRehber;Integrated Security=True");

        void Goruntule()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Kisiler", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_Kisiler(Ad,Soyad,Telefon,Mail) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kiþi Baþarýyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Goruntule();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kiþi Rehberden Silinsin Mi?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_Kisiler where ID=" + txtID.Text, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kiþi Rehberden Silindi", "Bilgi");
                Goruntule();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_Kisiler set Ad=@p1,Soyad=@p2,Telefon=@p3,Mail=@p4 where ID=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayýt Baþarýyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}