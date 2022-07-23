using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webservisDeneme
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnsorgula_Click(object sender, EventArgs e)
        {
            localhost.Nufuskayit nk = new localhost.Nufuskayit();
            GridView1.DataSource = nk.TrafikServisTC(txttckno.Text);
            DataBind();
        }

        protected void Btngetir_Click(object sender, EventArgs e)
        {
            localhost.Nufuskayit nk2 = new localhost.Nufuskayit();
            GridView1.DataSource = nk2.Trafikservis();
            DataBind();
        }
    }
}