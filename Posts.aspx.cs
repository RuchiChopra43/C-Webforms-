using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;
namespace Bulletin
{
    public partial class Posts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Post post = new Post();
            List<Post> listOfPost = post.GetPosts();


            string u = @"
             <table style ='width:1000;' border ='1' align= 'center'>
              <tr>
              <td align = 'center'>PostID</td>
              <td align= 'center'>Text</td>
               <td align= 'center'>Created on </td>
               </tr>";

            for (int n = 0; n < listOfPost.Count; n++)
            {

                if (n % 2 == 0)
                    u = u + "</tr><tr>";
                u = u + "<td align = 'center'>" + listOfPost.ElementAt(n).PostID + "</td>";
                u = u + "<td align = 'center'>" + listOfPost.ElementAt(n).Text + "</td>";
                u = u + "<td align = 'center'>" + listOfPost.ElementAt(n).DateCreated + "</td>";
              
            }
            u = u + "</tr></table>";

            ContentPlaceHolder cpu = Page.Master.FindControl("postsPlaceHolder") as ContentPlaceHolder;
            cpu.Controls.Add(new LiteralControl(u));


        }


    }
}
