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

namespace CUS.ICS.StudyAbroad
{
    public partial class DefaultView : PortletViewBase
    {
        String usernm = "";
        String idnum = "";
        String curtime = "";
        Int32 idnumInt = 0;
        String curryr = "";
        String currtrm = "";
        String currsess = "";
       
        SqlConnection sqlcon = null;



        protected void Page_Load(object sender, System.EventArgs e)
        {
            //  if (Jenzabar.Portal.Framework.PortalUser.Current.IsMemberOf(PortalGroup.Students))
            //  {
      
            Session["idnum"] = Jenzabar.Portal.Framework.PortalUser.Current.HostID;

            this.ParentPortlet.State = PortletState.Default;

            


            if (IsFirstLoad)
            {

                idnum = this.tluid.Text;
                //  }
                //  else
                //  {
                // Get and populate known user information
                this.ParentPortlet.State = PortletState.Maximized;


                try
                {
                    sqlcon = new SqlConnection(
                        System.Configuration.ConfigurationManager
                        .ConnectionStrings["JenzabarConnectionString"]
                        .ConnectionString);

                    sqlcon.Open();

                    //****************************************
                    // Try to populate 
                    //****************************************
                    try
                    {
                       
                        
                        //    Get current year and term
                        SqlCommand sqlGetCurrentTerm = new SqlCommand(
                          "select curr_yr,curr_trm,curr_sess from cust_intrfc_cntrl where intrfc_type = 'CURR'", sqlcon);
                        SqlDataReader readtrm = sqlGetCurrentTerm.ExecuteReader();
                        if (readtrm.HasRows)
                        {
                            while (readtrm.Read())
                            {
                                curryr = readtrm["CURR_YR"].ToString();
                                currtrm = readtrm["CURR_TRM"].ToString();
                                currsess = readtrm["CURR_SESS"].ToString();
                               
                            }
                        }

                        this.curr_yr.Text = curryr;
                        this.curr_trm.Text = currsess;


                        //    Populate personal information
                        SqlCommand sqlcmdStudyAbrdPerson = new SqlCommand(
                         "SELECT a.ID_NUM, LAST_NAME, FIRST_NAME, MIDDLE_NAME, PHONE, ADDR_CDE, "
                       + "ADDR_LINE_1, addr_line_2,b.city,b.state,b.zip,c.bldg_cde,c.room_cde "
                       + "FROM NAME_MASTER a JOIN ADDRESS_MASTER b "
                       + "ON a.ID_NUM = b.ID_NUM "
                       + "left join stud_sess_assign cc "
                       + "on a.id_num = cc.id_num "
                       + "left join room_assign c "
                       + "on a.id_num = c.id_num "
                       + "WHERE cc.sess_cde = '2011FA"
                       + " and b.addr_cde in ('*LHP','OFFC','CBOX') "
                       + "and a.ID_NUM = '" + Jenzabar.Portal.Framework.PortalUser.Current.HostID + "'", sqlcon);

                        SqlDataReader reader = sqlcmdStudyAbrdPerson.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                this.tluid.Text = reader["ID_NUM"].ToString();
                                this.lname.Text = reader["LAST_NAME"].ToString();
                                this.fname.Text = reader["FIRST_NAME"].ToString();
                                this.mname.Text = reader["addr_cde"].ToString();

                                //         this.usernm.Text = Jenzabar.Portal.Framework.PortalUser.Current.NameDetails.DisplayName.ToString();

                                String item = reader["ADDR_CDE"].ToString();


                                idnum = reader["ID_NUM"].ToString();
                                idnumInt = Convert.ToInt32(idnum);

                                if (item == "*LHP")
                                {
                                    this.hphone.Text = reader["PHONE"].ToString();
                                    this.permaddr.Text = reader["addr_line_1"].ToString();
                                    this.permcity.Text = reader["city"].ToString();
                                    this.permst.Text = reader["state"].ToString();
                                    this.permzip.Text = reader["zip"].ToString();
                                }
                                if (item == "*EML")
                                {
                                    this.email.Text = reader["ADDR_LINE_1"].ToString();
                                }
                                if (item == "CBOX")
                                {

                                    this.campaddr.Text = " Box: " + reader["addr_line_2"].ToString() + "   Room: " + reader["bldg_cde"].ToString() + " " + reader["room_cde"].ToString();
                                }

                                //        if (item == "OFFC")
                                //        {
                                //            this.locaddr.Text = reader["addr_line_1"].ToString();
                                //            this.campcity.Text = reader["city"].ToString();
                                //            this.campst.Text = reader["state"].ToString();
                                //            this.campzip.Text = reader["zip"].ToString();
                                //        }

                            }

                        }
                        else
                        {
                            Console.WriteLine("no Items Found");
                        }
                        reader.Close();

                      

                        


                    } //Try close

                    catch 
                    {
                        lname.Enabled = false;
                        lname.Enabled = false;

                    }

                }
                catch
                {

                    sqlcon.Close();
                }
            }  //FirstLoad close
        } //Protected class close

        protected void btnSubmit_Click(object sender, EventArgs e)
        {


            if (Page.IsPostBack)
            {
                if (Page.IsValid)
                {
                    SqlConnection sqlconUp = new SqlConnection(
                    System.Configuration.ConfigurationManager
                           .ConnectionStrings["JenzabarConnectionString"]
                           .ConnectionString);
                    sqlconUp.Open();

                    String pageItem;
                    String sqlInsert;

                    DateTime Now = DateTime.Now;
                    pageItem = Now.ToString();
                    curtime = Now.ToString();
                    idnum = this.tluid.Text;

                    sqlInsert = "INSERT INTO [dbo].[CUST_STUDY_ABROAD] "
                           + "(ID_NUM,USER_NAME,JOB_NAME,JOB_TIME) "
                           + "VALUES('" + idnum + "','" + usernm + "'," + "'StudyAbroadPortal'" + ",'" + curtime + "')";
                    SqlCommand sqlStmtInit = new SqlCommand(sqlInsert, sqlconUp);
                    sqlStmtInit.ExecuteNonQuery();

                    this.ParentPortlet.NextScreen("MainView");
                    //  Server.Transfer("MainView.ascx");
                }
                else
                {
                  
                    //       this.ParentPortlet.NextScreen("HlthFrm");
                }
            }
        }
        



    }  //Public class close
}
