using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class AddBoard : System.Web.UI.Page
    {
        User user = new User();
        Board board = new Board();
        Utility utility = new Utility();
        protected void Page_Load(object sender, EventArgs e)
        {
           

            }

        protected void AddBoardButton_Click(object sender, EventArgs e)
        {
            Board _board = new Board();
            
            _board.Name = NewBoardTextBox.Text;
            _board.DateCreated = DateTime.Now;
            User _user = (User)Session["loggedInUser"];

            


            bool isBoardAdded = board.AddBoard(_board, _user);
            if (isBoardAdded== true) {
                Response.Redirect("Boards.aspx");
            }
            
        }
    }
}