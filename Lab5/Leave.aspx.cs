using System;
using System.Xml.Linq;

namespace LeaveApp
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["date"] != null)
                {
                    lblLeaveDate.Text = Request.QueryString["date"];
                }

                if (Request.Cookies["EmpName"] != null)
                {
                    txtName.Text = Request.Cookies["EmpName"].Value;
                    chkRemember.Checked = true;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (chkRemember.Checked)
            {
                Response.Cookies["EmpName"].Value = txtName.Text;
                Response.Cookies["EmpName"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["EmpName"].Expires = DateTime.Now.AddDays(-1);
            }

            lblMessage.Text = "Leave application submitted successfully for " + txtName.Text + " on " + lblLeaveDate.Text + ".";
        }
    }
}
