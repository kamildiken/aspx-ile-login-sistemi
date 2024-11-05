using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginforweb
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // SAYFA BAŞLADIĞIINDA HATA MESAJININ GÖRÜNMEMESİ İÇİN
            Label3.Visible = false;
        }
        // BAĞLANTI KURMA
        SqlConnection baglanti = new SqlConnection("Veritabanı bağlantısını buraya yapıştırın");
        SqlCommand komut;
        SqlDataReader oku;

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // tablodan verileri çekiyoruz
            komut = new SqlCommand("select * from TABLOADI where kullaniciadi=@k1 and sifre=@k2", baglanti);
            komut.Parameters.AddWithValue("@k1", TextBox1.Text);
            komut.Parameters.AddWithValue("@k2", TextBox2.Text);
            //kontrol edilen kısım
            oku = komut.ExecuteReader();
            // okunan veri uyuşuyor ise giriş için yönlendirme yapılacak
            if (oku.Read())
            {
                Session["kullaniciadi"] = TextBox1.Text;
                Response.Redirect("Yönlendirme yapmak istediğiniz link");
                baglanti.Close();
            }
            // uyuşmuyor ise uyarı mesajı görünücek
            else { Label3.Visible = true; }
            
        }
    }
}