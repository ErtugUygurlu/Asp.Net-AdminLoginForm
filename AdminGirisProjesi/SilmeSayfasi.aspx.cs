﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminGirisProjesi
{
    public partial class SilmeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"].ToString());
            DataSet1TableAdapters.TblAdminTableAdapter dt = new DataSet1TableAdapters.TblAdminTableAdapter();
            dt.AdminSil(x);
            Response.Redirect("Veriler.Aspx");
        }
    }
}