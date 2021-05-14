using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioBtn
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcesa_Click(object sender, EventArgs e)
        {
            if (rbtnPizza.Checked == true)
            {
                Response.Write("Te recomiendo una pizza del Sierra. <br>");
            }
            else if (rbtnFrutas.Checked == true)
            {
                Response.Write("Te recomiendo una sandía. <br>");
            }
            else if (rbtnVerduras.Checked == true)
            {
                Response.Write("Te recomiendo un brócoli. <br>");
            }
        }
    }
}