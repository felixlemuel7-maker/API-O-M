#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient; // Paquete NuGet: Microsoft.Data.SqlClient

namespace Periodoacademico26.Repositorios
{
    using Periodoacademico26;

    /// <summary>
    /// VERSIÓN DE PRUEBA CONECTADA A SQL SERVER.
    /// Antes esto era una lista en memoria; ahora cada método abre una
    /// conexión, hace la consulta y cierra. El modelo PeriodoAcademico.cs
    /// no cambió en nada — solo cambió de dónde vienen los datos.
    /// </summary>
    public static class PeriodosRepositorio
    {
        // AJUSTA esta línea según cómo tengas instalado SQL Server:
        //
        //  - Si usas LocalDB (viene incluido con Visual Studio):
        //      "Server=(localdb)\\MSSQLLocalDB;Database=Periodoacademico26DB;Trusted_Connection=True;TrustServerCertificate=True;"
        //
        //  - Si usas SQL Server Express con instancia con nombre
        //    (como "JULISAYBODDENE\SQLEXPRESS" que vimos en el módulo
        //    de Asignaturas de tu compañero), reemplaza TU_PC\SQLEXPRESS
        //    por el nombre real de tu computadora + instancia:
        //      "Server=TU_PC\\SQLEXPRESS;Database=Periodoacademico26DB;Trusted_Connection=True;TrustServerCertificate=True;"
        private const string CadenaConexion =
            "Server=(localdb)\\MSSQLLocalDB;Database=Periodoacademico26DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<PeriodoAcademico> ObtenerTodos(string filtroNombre = "")
        {
            var lista = new List<PeriodoAcademico>();

            string sql = "SELECT IdPeriodo, NombrePeriodo, TipoPeriodo, FechaInicio, FechaFin, Estado FROM PeriodosAcademicos";
            if (!string.IsNullOrWhiteSpace(filtroNombre))
            {
                sql += " WHERE NombrePeriodo LIKE @Filtro";
            }
            sql += " ORDER BY FechaInicio";

            using var conexion = new SqlConnection(CadenaConexion);
            conexion.Open();

            using var comando = new SqlCommand(sql, conexion);
            if (!string.IsNullOrWhiteSpace(filtroNombre))
            {
                comando.Parameters.AddWithValue("@Filtro", $"%{filtroNombre}%");
            }

            using var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new PeriodoAcademico(
                    lector.GetInt32(0),
                    lector.GetString(1),
                    lector.GetString(2),
                    lector.GetDateTime(3),
                    lector.GetDateTime(4),
                    lector.GetString(5)));
            }

            return lista;
        }

        public static PeriodoAcademico ObtenerPorId(int idPeriodo)
        {
            string sql = "SELECT IdPeriodo, NombrePeriodo, TipoPeriodo, FechaInicio, FechaFin, Estado FROM PeriodosAcademicos WHERE IdPeriodo = @Id";

            using var conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            using var comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Id", idPeriodo);

            using var lector = comando.ExecuteReader();
            if (lector.Read())
            {
                return new PeriodoAcademico(
                    lector.GetInt32(0), lector.GetString(1), lector.GetString(2),
                    lector.GetDateTime(3), lector.GetDateTime(4), lector.GetString(5));
            }

            return null;
        }

        public static List<string> ObtenerNombresActivos()
        {
            var nombres = new List<string>();
            string sql = "SELECT NombrePeriodo FROM PeriodosAcademicos WHERE Estado = 'Activo'";

            using var conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            using var comando = new SqlCommand(sql, conexion);
            using var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                nombres.Add(lector.GetString(0));
            }

            return nombres;
        }

        /// <summary>
        /// Inserta el período y devuelve el Id que le asignó la base de
        /// datos (SCOPE_IDENTITY), para poder usarlo enseguida.
        /// </summary>
        public static int Agregar(PeriodoAcademico periodo)
        {
            string sql = @"INSERT INTO PeriodosAcademicos (NombrePeriodo, TipoPeriodo, FechaInicio, FechaFin, Estado)
                           VALUES (@Nombre, @Tipo, @Inicio, @Fin, @Estado);
                           SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using var conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            using var comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Nombre", periodo.NombrePeriodo);
            comando.Parameters.AddWithValue("@Tipo", periodo.TipoPeriodo);
            comando.Parameters.AddWithValue("@Inicio", periodo.FechaInicio);
            comando.Parameters.AddWithValue("@Fin", periodo.FechaFin);
            comando.Parameters.AddWithValue("@Estado", periodo.Estado);

            return (int)comando.ExecuteScalar();
        }

        public static void Actualizar(PeriodoAcademico periodo)
        {
            string sql = @"UPDATE PeriodosAcademicos
                           SET NombrePeriodo = @Nombre, TipoPeriodo = @Tipo,
                               FechaInicio = @Inicio, FechaFin = @Fin, Estado = @Estado
                           WHERE IdPeriodo = @Id";

            using var conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            using var comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Nombre", periodo.NombrePeriodo);
            comando.Parameters.AddWithValue("@Tipo", periodo.TipoPeriodo);
            comando.Parameters.AddWithValue("@Inicio", periodo.FechaInicio);
            comando.Parameters.AddWithValue("@Fin", periodo.FechaFin);
            comando.Parameters.AddWithValue("@Estado", periodo.Estado);
            comando.Parameters.AddWithValue("@Id", periodo.IdPeriodo);
            comando.ExecuteNonQuery();
        }

        public static void Eliminar(int idPeriodo)
        {
            string sql = "DELETE FROM PeriodosAcademicos WHERE IdPeriodo = @Id";

            using var conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            using var comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Id", idPeriodo);
            comando.ExecuteNonQuery();
        }
    }
}
