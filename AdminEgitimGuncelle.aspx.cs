using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLEgitimHTableAdapter dr =
                new DataSet1TableAdapters.TBLEgitimHTableAdapter();
                TxtBaslik.Text = dr.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBas.Text = dr.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = dr.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = dr.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
                TxtGnot.Text = dr.EgitimGetir(Convert.ToInt16(x))[0].GNOT;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEgitimHTableAdapter dr =
                new DataSet1TableAdapters.TBLEgitimHTableAdapter();
            dr.EgitimGuncelle(TxtBaslik.Text, TxtAltBas.Text, TxtAciklama.Text, 
                TxtGnot.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}