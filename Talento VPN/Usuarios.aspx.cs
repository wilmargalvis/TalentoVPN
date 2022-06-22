using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades_Negocio;
using Reglas_Negocio;

namespace Talento_VPN
{
    public partial class Usuarios : System.Web.UI.Page
    {
       private readonly clsBEUsuarios _objBEUsuarios = new clsBEUsuarios();
        private readonly clsBRUsuarios _objBRUsuarios = new clsBRUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                //Llenar datos
                LlenarObjeto();

                //Guardar
                Guardar(_objBEUsuarios);
            }
        }

        private void LlenarObjeto()
        {
            _objBEUsuarios.Nombre = "Wilmar Galvis";
            _objBEUsuarios.Edad = "37";
            _objBEUsuarios.Correo = "wilmargalvis@gmail.com";
            _objBEUsuarios.Iglesia = "VPN";
            _objBEUsuarios.Pais = "";
            _objBEUsuarios.Departamento = "";
            _objBEUsuarios.Municipio = "";
            _objBEUsuarios.Barrio = "";
        }

        private void Guardar(clsBEUsuarios _objBEUsuarios)
        {
            _objBRUsuarios.Guardar(_objBEUsuarios);
        }
    }
}