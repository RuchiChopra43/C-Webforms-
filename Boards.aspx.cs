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
    public partial class Boards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Board _board = new Board();
            List<Board> listOfBoard = new List<Board>();
            listOfBoard = _board.GetBoards();

            string a = @"
             <table style ='width:auto;' border ='1' align= 'center'>
              <tr>
              <td align= 'center'>Name</td><td align= 'center'>Posts</td>
               </tr>";


            for (int n = 0; n < listOfBoard.Count; n++)
            {

                if (n % 2 == 0) { a = a + "<tr>"; } else { a = a + "</tr><tr>"; }
                a = a + "<td align = 'center'>" + listOfBoard.ElementAt(n).Name + "</td>";
                a = a + "<td align = 'center'>";

                string reDirect = string.Format("BoardPost.aspx?id= {0}", listOfBoard.ElementAt(n).BoardID);
                string hyperlink = "<a href = '" + reDirect + "'> Go to posts!</a>";
                a = a + hyperlink + "</td>";

                a = a + "<td align = 'center'>";

             
            }

            a = a + "</tr></table>";
            ContentPlaceHolder cpa = Page.Master.FindControl("boardsPlaceHolder") as ContentPlaceHolder;
            cpa.Controls.Add(new LiteralControl(a));

            
            User user = (User)Session["loggedInUser"];
            

        }

        
    }
}