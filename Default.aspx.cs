using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bulletin.Models;

namespace Bulletin
{
    public partial class Login : System.Web.UI.Page
    {
          
        User user = new User();
        Utility utility = new Utility();
        static int count = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UserNameTextBox.Text;
            string password = PassTextBox.Text;
            string checkUsername = utility.CheckUsername(Username, "login");
            string checkPassword = utility.CheckPassword(password);


            if (checkUsername == "OK" && checkPassword == "OK")
            {
                user = user.Login(Username, password);
                if (user != null)   // If user logged in 
                {
                    Session.Add("loggedInUser", user);
                    User _user = (User)(Session["loggedInUser"]);
                    Response.Redirect("Boards.aspx");
                }
                else
                {
                    if (count < 3)
                    {


                        string html = "<p style='color:red'>Something went wrong. You need to check your id and password!</p>";


                        helperText.Controls.Add(new LiteralControl(html));
                        count++;
                    }
                    else
                    {
                        Response.Redirect("Register.aspx");
                    }
                }
            }

        }
    }
}