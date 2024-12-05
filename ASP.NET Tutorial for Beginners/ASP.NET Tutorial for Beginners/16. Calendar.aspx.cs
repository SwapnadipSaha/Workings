using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = false;

            foreach (DateTime dt in Calendar1.SelectedDates)
            {
                Response.Write(dt.ToString("dd/MM/yyyy") + " ");
            }

           //------------------Formats-----------------------------
            Response.Write("ToString() -"+ DateTime.Now.ToString() + "<br/>");
            Response.Write("TolongDateString() -" + DateTime.Now.ToLongDateString() + "<br/> ");
            Response.Write("ToShortDateString() -"+ DateTime.Now.ToShortDateString() + "<br/>");   
            Response.Write("ToLongTimeString()-" + DateTime.Now.ToLongTimeString() + "<br/>");     
            Response.Write("ToShortTimeString()-" + DateTime.Now.ToShortTimeString() + "<br/>");
///Output
//ToString()-09/30/202411:49:14PM
//TolongDateString()-Monday,September30,2024
//ToShortDateString()-09/30/2024
//ToLongTimeString()-11:49:14PM
//ToShortTimeString()-11:49PM

            Response.Write("------------------------------------------<br/>");

            Response.Write("d-" + DateTime.Now.ToString("d") +"<br/> ");   
            Response.Write("D-" + DateTime.Now.ToString("D")+ "<br/>");
            Response.Write("dd/MM/yyyy-"+DateTime.Now.ToString("dd/MM/yyyy") +"<br/>");
            Response.Write("dd/MMMM/yyyy - "+ DateTime.Now.ToString("dd/MMMM/yyyy") + "<br/>");
            Response.Write("dd/MMMM/yy - " + DateTime.Now.ToString("dd/MMMM/yy") + "<br/>");
            Response.Write("MM/dd/yy - " + DateTime.Now.ToString("MM/dd/yy") + "<br/>");
//Output
//d-09/30/2024
//D-Monday,September30,2024
//dd/MM/yyyy-30/09/2024
//dd/MMMM/yyyy-30/September/2024
//dd/MMMM/yy-30/September/24
//MM/dd/yy-09/30/24
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        { 
            //This event render for every day of the calendar
            Response.Write(e.Day.DayNumberText+" ");  // This will show all the visible dates. From previous month to next months.
            if(e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false; // disable other month date
            }

            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false; // disable other weekend
                e.Cell.BackColor = System.Drawing.Color.Red;  // change color
            }
            if (e.Day.Date.Day % 2 == 0)   // for the even dates
            {
                e.Cell.BackColor = System.Drawing.Color.Green;  // change color
                e.Cell.Text = "XX"; // change text
                e.Cell.ToolTip = "Booked";
                e.Cell.ForeColor = System.Drawing.Color.White;
            }
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            //This event fires when he visible month changed
            Response.Write("Month Changed from "+ getMonthName(e.PreviousDate.Month)+ " to " + getMonthName(e.NewDate.Month));
            //Output --   Month Changed from 10/01/2024 12:00:00 AM to 11/01/2024 12:00:00 AM
        }

        private string getMonthName(int MonthNumber)
        {
            switch (MonthNumber)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "No Month";
            }
        }
    }
}
