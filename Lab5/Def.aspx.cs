using System;

namespace  P5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDate.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate != DateTime.MinValue)
            {
                string selectedDate = Calendar1.SelectedDate.ToShortDateString();
                Response.Redirect("Leave.aspx?date=" + Server.UrlEncode(selectedDate));
            }
            else
            {
                lblSelectedDate.Text = "Please select a date first.";
            }
        }
    }
}
