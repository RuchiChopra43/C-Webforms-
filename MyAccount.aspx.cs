using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class MyAccount : System.Web.UI.Page
    {
        static User userForUpdate;
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["loggedInUser"];
            Board board = new Board();
            Post post = new Post();

            NameLabel.Text = user.Name;
            UsernameLabel.Text = user.Username;

            string a1 = "<h2>Boards created by you </h2>";
            ContentPlaceHolder cpa1 = Page.Master.FindControl("MyAccountPlaceHolder1") as ContentPlaceHolder;
            cpa1.Controls.Add(new LiteralControl(a1));

            string a2 = @"

             <table style ='width:auto;' border ='1' align= 'center'>
              <tr><td align= 'center'>Board ID</td>               
               <td align= 'center'>Name</td>
               <td align= 'center'>Created on</td>
              <td align = 'center' >Posts</td ></tr> ";



            for (int n = 0; n < user.Boards.Count; n++)
            {

                if (n % 2 == 0)
                    a2 = a2 + "<tr>";


                else


                    a2 = a2 + "</tr><tr>";
                a2 = a2 + "<td align = 'center'>" + user.Boards.ElementAt(n).BoardID + "</td>";
                a2 = a2 + "<td align = 'center'>" + user.Boards.ElementAt(n).Name + "</td>";
                a2 = a2 + "<td align = 'center'>" + user.Boards.ElementAt(n).DateCreated.ToString() + "</td>";
                a2 = a2 + "<td align = 'center'>";

                string reDirect = string.Format("BoardPost.aspx?id= {0}", user.Boards.ElementAt(n).BoardID);
                string hyperlink = "<a href = '" + reDirect + "'> Go to posts!</a>";
                a2 = a2 + hyperlink + "</td>";

            }

            a2 = a2 + "</tr></table>";

            ContentPlaceHolder cpa2 = Page.Master.FindControl("MyAccountPlaceHolder2") as ContentPlaceHolder;
            cpa2.Controls.Add(new LiteralControl(a2));


            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            User user = (User)Session["loggedInUser"]; 
            user.Password = NewpassTextBox.Text;
            user.UpdateUser(user);
            Response.Redirect("MyAccount.aspx");
        }
    }


}
