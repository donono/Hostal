using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer.DC;

namespace PresentationLayer.paginas
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarDDLCategorias();
        }

        public void llenarDDLCategorias()
        {
            try
            {
                dllCategorias.DataSource = new BcCategoria().ReadAll();
                dllCategorias.DataTextField = "descripcion";   // "nombre del campo en la bd"
                dllCategorias.DataValueField = "id_categoria";
                dllCategorias.DataBind();
                dllCategorias.Items.Insert(0, new ListItem(" Seleccione ", "0"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}