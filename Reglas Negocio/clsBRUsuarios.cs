using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Negocio;
using Entidades_Negocio;

namespace Reglas_Negocio
{
    public class clsBRUsuarios
    {
        clsBDUsuarios _objBDUsuarios = new clsBDUsuarios();
        clsBEUsuarios objBEUsuarios = new clsBEUsuarios();
        //public string _nombre { get; set; }
        //public string _correo { get; set; }
        //public clsBRUsuarios(clsBEUsuarios objBEUsuarios)
        //{
        //    _nombre = objBEUsuarios.Nombre;
        //    _correo = objBEUsuarios.Correo;
        //}

        public void Guardar(clsBEUsuarios _objBEUsuarios)
        {

            _objBDUsuarios.Guardar(_objBEUsuarios);

        }
    }
}
