using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p3S5WebformPageProperties
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["submits"] == null)
            {
                Application["submits"] = 0;
            }
            if (Page.IsPostBack)
            {
                string capture = "Name = " + txtname.Text + "<br>Address = " + txtaddress.Text + "<br>Class = " + txtclass.Text + "<br>Email = " + txtemail.Text + "<hr>";
                lblLog.Text += capture;
            }
            else
            {
                if (Request.QueryString["name"] != null)
                {
                    txtname.Text = Request.QueryString["name"];
                    Response.Write("QueryString RECEIVED");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int submits = (int)Application["submits"];
            submits++;
            Application["submits"] = submits;
            lblCount.Text = submits.ToString() + "submits done";
        }
    }
}