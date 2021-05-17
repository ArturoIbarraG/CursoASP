using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceApp
{
    public partial class _Default : Page
    {
        ServiceReference.WebServiceSoapClient webService;
        protected void Page_Load(object sender, EventArgs e)
        {
            webService = new ServiceReference.WebServiceSoapClient();
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            lblText.Text = webService.HelloWorld();
        }
    }
}