using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class AdminDeneyim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAd"] == null)
            {
                Response.Redirect("LoginPanel.aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz...." + Session["KullaniciAd"].ToString());
            }

            DataSet1TableAdapters.TBLDeneyimTableAdapter dr =
                new DataSet1TableAdapters.TBLDeneyimTableAdapter();
            Repeater1.DataSource = dr.DeneyimListesi();
            Repeater1.DataBind();
        }
    }
}