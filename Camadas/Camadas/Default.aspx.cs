using System;

namespace Camadas
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            meuGrid.DataSource = new CamadaLogicaNegocios().ObtemClientes();
            meuGrid.DataBind();
        }
    }
}