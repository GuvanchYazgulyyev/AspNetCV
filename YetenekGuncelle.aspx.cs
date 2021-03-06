﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspCV
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Enabled = false;
            TxtID.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLYeteneklerTableAdapter dr =
                new DataSet1TableAdapters.TBLYeteneklerTableAdapter();
                TxtYetenek.Text = dr.YetenekGetir(Convert.ToInt16(x))[0].YETENEK;
                

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYeteneklerTableAdapter dr =
                new DataSet1TableAdapters.TBLYeteneklerTableAdapter();
            dr.YetenekGuncelle(TxtYetenek.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Yetenek.aspx");
        }
    }
}