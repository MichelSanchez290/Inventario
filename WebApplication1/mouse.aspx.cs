using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ClassBLInventario;
using ClassCapaEntidad;

namespace WebApplication1
{
    public partial class mouse : System.Web.UI.Page
    {
        CapaNegocioMouse nuevo = null;
        //CapaNegocioComponentes V = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                nuevo = new CapaNegocioMouse(ConfigurationManager.ConnectionStrings["nueva"].ConnectionString);
                Session["Nuevo"] = nuevo;

                

            }
            else
            {
                nuevo = (CapaNegocioMouse)Session["nueva"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //EntidadMouse guardar = new EntidadMouse()
            //{
            //    f_marcamouse =  
                
            //}
        }
    }
}