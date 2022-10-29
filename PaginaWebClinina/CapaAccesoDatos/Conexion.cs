using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null;
        private Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=SQL5104.site4now.net;Initial Catalog=db_a8cb54_desaweb2022;Persist Security Info=True;User ID=db_a8cb54_desaweb2022_admin;Password=br4928ox;MultipleActiveResultSets=True";
            return conexion;
        }
    }
}
