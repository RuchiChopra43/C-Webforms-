using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;
using Bulletin.Repository;

namespace Bulletin
{
    public partial class BoardPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Board board = new Board();
            Board _board = board.GetBoard(id);
            string a1 = "<h2>Board's Name : " + _board.Name + "</h2>";
            ContentPlaceHolder cpa1 = Page.Master.FindControl("BoardPostPlaceHolder1") as ContentPlaceHolder;
            cpa1.Controls.Add(new LiteralControl(a1));

            string linkToAddPost = "<a href='AddPost.aspx?boardid="+id+ "'>Add new Post</a>";

            newPostPH.Controls.Add(new LiteralControl(linkToAddPost));


            string a2 = @"

             <table style ='width:auto;' border ='1' align= 'center'>
              <tr><td align = 'center'>ID</td>
              <td align= 'center'>Text</td>               
               <td align= 'center'>Created on</td>";


            for (int n = 0; n < _board.Posts.Count; n++)
            {

                if (n % 2 == 0)
                    a2 = a2 + "<tr>";


                else


                    a2 = a2 + "</tr><tr>";
                a2 = a2 + "<td align = 'center'>" + _board.Posts.ElementAt(n).PostID + "</td>";
                a2 = a2 + "<td align = 'center'>" + _board.Posts.ElementAt(n).Text + "</td>";
                a2 = a2 + "<td align = 'center'>" + _board.Posts.ElementAt(n).DateCreated.ToString() + "</td>";
                

            }

            a2 = a2 + "</tr></table>";

            ContentPlaceHolder cpa2 = Page.Master.FindControl("BoardPostPlaceHolder2") as ContentPlaceHolder;
            cpa2.Controls.Add(new LiteralControl(a2));

        }

       
       
    }
}
