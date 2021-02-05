using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class Default : System.Web.UI.Page
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

            DataSet1TableAdapters.TBLHakkimdaTableAdapter dr = 
                new DataSet1TableAdapters.TBLHakkimdaTableAdapter();
            Repeater1.DataSource = dr.HakkimdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDeneyimTableAdapter dr1 =
                 new DataSet1TableAdapters.TBLDeneyimTableAdapter();
            Repeater2.DataSource = dr1.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEgitimHTableAdapter dr2 =
                new DataSet1TableAdapters.TBLEgitimHTableAdapter();
            Repeater3.DataSource = dr2.EgitimBilgi();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLHobiTableAdapter dr3 = 
                new DataSet1TableAdapters.TBLHobiTableAdapter();
            Repeater4.DataSource = dr3.hobiBilgi();
            Repeater4.DataBind();


            DataSet1TableAdapters.TBLSertifikaTableAdapter dr4 =
                new DataSet1TableAdapters.TBLSertifikaTableAdapter();
            Repeater5.DataSource = dr4.SertifikaBilgi();
            Repeater5.DataBind();


            DataSet1TableAdapters.TBLYeteneklerTableAdapter dr5 =
                new DataSet1TableAdapters.TBLYeteneklerTableAdapter();
            Repeater6.DataSource = dr5.YetenekBilgi();
            Repeater6.DataBind();


            DataSet1TableAdapters.TBLHakkimdaTableAdapter dr7 =
                new DataSet1TableAdapters.TBLHakkimdaTableAdapter();
            Repeater7.DataSource = dr7.HakkimdaListele();
            Repeater7.DataBind();

        }
    }
}