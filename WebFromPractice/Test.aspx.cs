using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFromPractice
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = 100;

            if (!IsPostBack)
            {
                ViewState["count"] = Convert.ToString(x);
                ViewState["SecondCount"] = Convert.ToString(x);
                Label5.Text = Convert.ToString(x);
                Label6.Text = Convert.ToString(x);

            }


            if (!IsPostBack)
            {
                Label3.Text = "100";
                Label4.Text = "100";
            }


            if (!IsPostBack)
            {
                Label2.Text = "0";

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var res = Name.Text;
            Label1.Text = "Hello, " + res + "!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(Label2.Text);
            count++;
            Label2.Text = Convert.ToString(count);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(Label4.Text);
            count--;
            Label4.Text = Convert.ToString(count);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(ViewState["count"]);
            count++;
            ViewState["count"] = Convert.ToString(count);
            Label5.Text = Convert.ToString(count);
        }
    }
}