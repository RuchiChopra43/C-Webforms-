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
    public partial class AddPost : System.Web.UI.Page
    {
        int boardID;
        BulletinContext _context = new BulletinContext();
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            boardID = int.Parse(Request.QueryString["boardid"]);

        }


        protected void AddpostButton_Click(object sender, EventArgs e)
        {
            if (!(AddPostTextBox.Text == ""))
            {
                Board _board = new Board();
                Post post = new Post();
                _board = _context.Boards.Find(boardID);
                post.Text = AddPostTextBox.Text;
                post.DateCreated = DateTime.Now;
                User user = (User)Session["loggedInUser"];
               
                user.AddPost(user, _board, post);
                Response.Redirect("Boards.aspx");
            }
            else
            {

                ErrorLabel.Text = "Cant create a post";

                Response.Redirect("Boards.aspx");

            }
        }
    }
}
        
