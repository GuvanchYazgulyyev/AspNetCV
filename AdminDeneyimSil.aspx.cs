using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLDeneyimTableAdapter dr =
                new DataSet1TableAdapters.TBLDeneyimTableAdapter();
            dr.DeneyimSil(Convert.ToInt16(x));
            Response.Redirect("AdminDeneyim.aspx");
        }
    }
}