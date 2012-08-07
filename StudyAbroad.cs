using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jenzabar.Common;
using Jenzabar.Portal.Framework;
using Jenzabar.Portal.Framework.Web;
using Jenzabar.Portal.Framework.Web.UI;
using Jenzabar.Portal.Framework.Security.Authorization;

#region "Settings - Optional"
	/// <summary>
	/// 
	
	/// </summary>
	/// 	


#endregion

namespace CUS.ICS.StudyAbroad
{
    [PortletOperation(
        "CANACCESS",
        "Can Access Portlet",
        "Whether a user can access this portlet or not",
        PortletOperationScope.Global)]

    [PortletOperation(
        "CanAdminPortlet",
        "Can Admin Portlet",
        "Whether a user can admin this portlet or not",
        PortletOperationScope.Global)]

  public partial class StudyAbroad : SecuredPortletBase
  {

        protected override PortletViewBase GetCurrentScreen()
        {
            switch (this.CurrentPortletScreenName)
            {
                case "MainView":
                    return this.LoadPortletView("ICS/StudyAbroad/MainView.ascx");
                case "DefaultView":
                    return this.LoadPortletView("ICS/StudyAbroad/DefaultView.ascx");
                default:
                    return this.LoadPortletView("ICS/StudyAbroad/DefaultView.ascx");
            }
        }
    }
}
