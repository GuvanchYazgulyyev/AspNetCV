﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class AdminEgitim : System.Web.UI.Page
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

            DataSet1TableAdapters.TBLEgitimHTableAdapter dr =
                new DataSet1TableAdapters.TBLEgitimHTableAdapter();
            Repeater1.DataSource = dr.EgitimBilgi();
            Repeater1.DataBind();
        }
    }
}