using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Jenzabar.Common;
using Jenzabar.Portal.Framework;
using Jenzabar.Common.Web.UI.Controls;
using Jenzabar.Portal.Framework.Web.UI;
using Jenzabar.Common.ApplicationBlocks.Data;

namespace CUS.ICS.JenzabarPortletTemplate1
{
    public partial class PurchaseView : PortletViewBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblError.Visible = false;

            string curtime = DateTime.Now.ToString();
            string purchamt = Session["purch"].ToString();
            string id = Session["idnum"].ToString();
            string sqlInsert = "";

            SqlConnection dbcon = null;

            this.purchamount.Text = purchamt;

            this.ParentPortlet.State = PortletState.Default;


            try
            {
                dbcon = new SqlConnection(
                            System.Configuration.ConfigurationManager
                            .ConnectionStrings["JenzabarConnectionString"]
                            .ConnectionString);

                dbcon.Open();



                sqlInsert = "INSERT INTO [dbo].[tlu_submission] "
                       + "(tlu_submission_dte,tlu_submitter_id,tlu_submission_sts,tlu_submission_amt,USERNAME,JOB_NAME,JOB_TIME) "
                       + "VALUES('" + curtime + "','" + id + "','H','" + purchamt + "','Jenzabar','BDBucksFrARCredit','" + curtime + "')";
                SqlCommand sqlStmt = new SqlCommand(sqlInsert, dbcon);
                sqlStmt.ExecuteNonQuery();

                dbcon.Close();
            }
            catch
            {
                this.lblError.Text = "error occurred in dbcon insert attempt" + sqlInsert;
                this.lblError.Visible = true;
                dbcon.Close();
            }
        }
    }
}