using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEgitimHTableAdapter dr =
                new DataSet1TableAdapters.TBLEgitimHTableAdapter();
            dr.EgitimEkle(TxtBaslik.Text, TxtAltBas.Text, TxtAciklama.Text, TxtGnot.Text, TxtTarih.Text);
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}