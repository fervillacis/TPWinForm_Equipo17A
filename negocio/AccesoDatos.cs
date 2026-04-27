using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using Negocio;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader _lector;

        public SqlDataReader Lector  //getter objeto lector.
        {
            get { return _lector; }
        }

        public AccesoDatos() //consturctor de AccesoDatos, inicializa la conexion y el comando.
        {
            //conexion = new SqlConnection("server=(localdb)\\MSSQLLocalDB;");
            //conexion = new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=CATALOGO_P3_DB; Integrated Security=True");
            conexion = new SqlConnection("server=localhost,1433; database=CATALOGO_P3_DB; user id=sa; password=Clave123!; TrustServerCertificate=True;");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta) //consulta a ejecutar
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura() //consultas select
        {
            comando.Connection = conexion;
            conexion.Open();
            _lector = comando.ExecuteReader();
        }

        public void ejecutarAccion() //consultas insert, update, delete
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion() //cierra conexion y lector si no es nulo.
        {
            if (_lector != null)
                _lector.Close();

            conexion.Close();
        }

    }
}
