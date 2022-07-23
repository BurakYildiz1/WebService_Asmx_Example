using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace webservice
{
    /// <summary>
    /// Nufuskayit için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class Nufuskayit : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet TrafikServisTC(string tckno)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.InitialCatalog = "AsmxDB";
            sqlConnectionStringBuilder.DataSource = @"Veritabani_bilgilerini_girin";
            sqlConnectionStringBuilder.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

            string sorgu = "select * from tblkisibilgi where tckno='"+tckno+"'";
            SqlDataAdapter dt = new SqlDataAdapter(sorgu,con);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            return ds;
        }


        [WebMethod]
        public DataSet Trafikservis()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.InitialCatalog = "AsmxDB";
            sqlConnectionStringBuilder.DataSource = @"DESKTOP-ECI1EV7\SQLEXPRESS";
            sqlConnectionStringBuilder.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

            string sorgu = "select * from tblkisibilgi";
            SqlDataAdapter dt = new SqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            return ds;
        }
    }
}
