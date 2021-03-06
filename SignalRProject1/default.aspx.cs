using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignalRProject1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            this.Title = int.TryParse(Request["id"], out id)
            ? "Page " + id
            : "Home page";
            var html = new StringBuilder();
            html.AppendLine("<ul>");
            for (int i = 1; i < 11; i++)
            {
                var text = "Page " + i;
                var link = string.Format(
                "<li><a href='Default.aspx?id={0}'>{1}</a></li>",
                i, text
                );
            html.AppendFormat(link);
            }
            html.AppendLine("</ul>");
            placeHolder.Controls.Add(
            new LiteralControl(html.ToString())
            );
        }
    }
}