using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList.CarpetaA.CarpetaB
{
    public partial class EnCarpetaB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // El path actual.
            Response.Write(Server.MapPath(".") + "<br/>");

            // El path del padre.
            Response.Write(Server.MapPath("..") + "<br/>");

            // El path de root o directorio raíz.
            Response.Write(Server.MapPath("~") + "<br/>");

            if (!IsPostBack)
            {
                DataSet DS = new DataSet();
                DS.ReadXml(Server.MapPath("~/Frutas.xml"));

                ddlFrutas.DataSource = DS;

                ddlFrutas.DataValueField = "FrutaID";
                ddlFrutas.DataTextField = "FrutaNombre";

                ddlFrutas.DataBind();
            }
        }
    }
}