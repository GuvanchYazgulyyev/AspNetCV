using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspCV
{
    public partial class LoginPanel : System.Web.UI.Page
    {
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-SIEHT30\SQLEXPRESS;Initial Catalog=GuvanchCV;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLAdmin where KullaniciAd=@p1 and " +
                "Sifre=@p2 ", bgl);
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Session.Add("KullaniciAd", TextBox1.Text);
                Response.Redirect("AdminDeneyim.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş !!!");
            }
            bgl.Close();
        }
    }
}