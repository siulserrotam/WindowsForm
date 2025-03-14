using System;
using System.Data.SqlClient;

namespace SVRepository.DB
{
    public class Conexion
    {
        private readonly IConfiguration _configuracion;
        private readonly string _CadenaConexion;

        public Conexion(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            _CadenaConexion = _configuracion.GetConnectionString("CadenaConexion")!;
        }

        public SqlConnection Obtener()
        {
            return new SqlConnection(_CadenaConexion);
        }
    }
}
