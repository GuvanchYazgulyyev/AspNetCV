using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLDeneyimTableAdapter dr =
                new DataSet1TableAdapters.TBLDeneyimTableAdapter();
                TxtBaslik.Text = dr.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBas.Text = dr.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = dr.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = dr.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
            }            
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDeneyimTableAdapter dr2 =
                  new DataSet1TableAdapters.TBLDeneyimTableAdapter();
            dr2.DeneyimGuncelle(TxtBaslik.Text, TxtAltBas.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("AdminDeneyim.aspx");

        }
    }
}