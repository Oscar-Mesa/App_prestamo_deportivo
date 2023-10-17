using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    internal class cls_ModuloUsuarios
    {
        private String str_id;
        private String str_pnombre;
        private String str_snombre;
        private String str_papellido;
        private String str_sapellido;
        private String str_contacto;
        private String str_correo;
        private String str_sexo;

        cls_conexion objConectar = new cls_conexion();

        public void fnt_guardar(String id, String p_nombre, String s_nombre, String p_apellido, String s_apellido, String contacto,
            String correo, String direccion, String sexo)
        {
            if (id.Equals("") || p_nombre.Equals("") || s_nombre.Equals("") || p_apellido.Equals("") || s_apellido.Equals("") ||
                contacto.Equals("") || correo.Equals("") || direccion.Equals("") || sexo.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
