using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_conexion
    {

            public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AEE6ANE\\SQLEXPRESS;Initial Catalog=dbs_roles;Integrated Security=True");
        }

    }
}
