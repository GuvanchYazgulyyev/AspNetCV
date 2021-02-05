using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = x.ToString();

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLHobiTableAdapter dr
                    = new DataSet1TableAdapters.TBLHobiTableAdapter();
                TxtHobi.Text = dr.HobiGetir(Convert.ToInt16(x))[0].HOBI;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHobiTableAdapter dr
                = new DataSet1TableAdapters.TBLHobiTableAdapter();
            dr.HobiGuncelle(TxtHobi.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Hobiler.aspx");
        }
    }
}