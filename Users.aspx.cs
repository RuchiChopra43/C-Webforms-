using Bulletin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bulletin
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((User)Session["loggedInUser"] == null)
            {
                Response.Redirect("Register.aspx");
            }

            else if (((User)Session["LoggedInUser"]).UserType == "ADMIN")
            {
                User user = new User();
                List<User> listOfUser = user.GetUsers();


                string u = @"
             <table style ='width:1000;' border ='1' align= 'center'>
              <tr>
              <td align = 'center'>UserID</td>
              <td align= 'center'>Name</td>
               <td align= 'center'>Username</td>
               <td align= 'center'>Password</td>
               <td align= 'center'>UserType</td>
               <td align= 'center'>Last Login Date</td>
               <td align= 'center'>Action</td></tr>";

                for (int n = 0; n < listOfUser.Count; n++)
                {

                    if (n % 2 == 0)
                        u = u + "<tr>";

                    else
                        u = u + "</tr><tr>";
                    u = u + "<td align = 'center'>" + listOfUser.ElementAt(n).UserID + "</td>";
                    u = u + "<td align = 'center'>" + listOfUser.ElementAt(n).Name + "</td>";
                    u = u + "<td align = 'center'>" + listOfUser.ElementAt(n).Username + "</td>";
                    u = u + "<td align = 'center'>" + listOfUser.ElementAt(n).Password + "</td>";
                    u = u + "<td align = 'center'>" + listOfUser.ElementAt(n).UserType + "</td>";
                    u = u + "<td align = 'center'>" + listOfUser.ElementAt(n).LastLoginDate + "</td>";
                    u = u + "<td align = 'center'>";

                    string reDirect = string.Format("UpdateUser.aspx?id= {0}", listOfUser.ElementAt(n).UserID);
                    string hyperlink = "<a href = '" + reDirect + "'> Update!</a>";
                    u = u + hyperlink + "</td>";
                }
                u = u + "</tr></table>";

                ContentPlaceHolder cpu = Page.Master.FindControl("usersPlaceHolder") as ContentPlaceHolder;
                cpu.Controls.Add(new LiteralControl(u));

            }


            else if (((User)Session["LoggedInUser"]).UserType == "BLOCKED")
            {
                string reDirect = String.Format("Error.aspx?message = {0}",
                    "You are blocked");
                Response.Redirect(reDirect);
            }

            else if (((User)Session["LoggedInUser"]).UserType == "USER")
            {
                string reDirect = String.Format("Error.aspx?message = {0}",
                    "You are not Admin");
                Response.Redirect(reDirect);
            }
            else
                Response.Redirect("Register.aspx");
        }
    }
}





        
    
