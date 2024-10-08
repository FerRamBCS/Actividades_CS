using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    class Central
    {

        /*
         FUNCION CENTRAL: Inicializar logica para la base de datos
         */
        static string constrg = "Data Source=LAPTOP-FERNANDO\\fernando;" +
            "Initial Catalog=Calificaciones;User ID=sa;Password=123456;TrustServerCertificate=True";
        public static Response SubirAlumno(Alumnos alumno)
        {
            Response response = new Response();
            // codigo para registrar alumno
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("insert into alumnos (nombre, apellido, matricula) values (@Nombre, @Apellido, @Matricula" +
                ")", conn);
            comm.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            comm.Parameters.AddWithValue("@Apellido", alumno.Apellido);
            comm.Parameters.AddWithValue("@Matricula", alumno.Matricula);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                response.Codigo = 1;
                response.Mensaje = "ALUMNO REGISTRADO CON EXITO";
            }
            catch (Exception ex)
            {
                response.Codigo = 2;
                response.Mensaje = "OCURRIO UN ERROR, ALUMNO NO REGISTRADO";
                Logger.Log(ex.Message, "RegistrarAlumno","Central");

            }
            finally 
            {
                conn.Close();
            }
            return response;
        }
        public static Response SubirMateria (Materias materia)
        {
            // codigo para registrar registrar materias
            Response response = new Response();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("insert into Materias (Nombre, Codigo) values (@Nombre, @Codigo)", conn);
            comm.Parameters.AddWithValue("@Nombre", materia.NombreM);
            comm.Parameters.AddWithValue("@Codigo", materia.ClaveM);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                response.Codigo = 1;
                response.Mensaje = "MATERIA REGISTRADA CON EXITO";
            }
            catch (Exception ex)
            {
                response.Codigo = 2;
                response.Mensaje = "OCURRIO UN ERROR, MATERIA NO REGISTRADA";
                // Registrar el error en el log
                Logger.Log(ex.Message, "SubirMateria", "Central");
            }
            finally
            {
                conn.Close();
            }
            return response;
        }
        public static Response SubirMaestro(Maestros maestro)
        {
            //Codigo para registrar maestro
            Response response = new Response();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("insert into maestros (NombreMaestro, ApellidoMaestro, MatriculaMaestro) " +
                                             "values (@NombreMaestro, @ApellidoMaestro, @MatriculaMaestro)", conn);
            comm.Parameters.AddWithValue("@NombreMaestro", maestro.NombreMaestro);
            comm.Parameters.AddWithValue("@ApellidoMaestro", maestro.ApellidoMaestro);
            comm.Parameters.AddWithValue("@MatriculaMaestro", maestro.MatriculaMaestro);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                response.Codigo = 1;
                response.Mensaje = "MAESTRO REGISTRADO CON EXITO";
            }
            catch (Exception ex)
            {
                response.Codigo = 2;
                response.Mensaje = "OCURRIO UN ERROR, MAESTRO NO REGISTRADO";
                // Registrar el error en el log
                Logger.Log(ex.Message, "SubirMaestro", "Central");
            }
            finally
            {
                conn.Close();
            }
            return response;
        }
        public static Response SubirCalificacion(int alumnoId, int materiaId, decimal calificacion)
        {
            Response response = new Response();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("INSERT INTO Calificaciones (AlumnoId, MateriaId, Calificacion, Fecha) " +
                                             "VALUES (@AlumnoId, @MateriaId, @Calificacion, @Fecha)", conn);
            comm.Parameters.AddWithValue("@AlumnoId", alumnoId);
            comm.Parameters.AddWithValue("@MateriaId", materiaId);
            comm.Parameters.AddWithValue("@Calificacion", calificacion);
            comm.Parameters.AddWithValue("@Fecha", DateTime.Now);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                response.Codigo = 1;
                response.Mensaje = "CALIFICACION REGISTRADA CON EXITO";
            }
            catch (Exception ex)
            {
                response.Codigo = 2;
                response.Mensaje = "OCURRIO UN ERROR, CALIFICACION NO REGISTRADA";
            }
            finally
            {
                conn.Close();
            }
            return response;
        }
        public static DataTable CargarAlumnos()
        {
            // codigo para obtener lista de alumno
            DataTable dtAlumnos = new DataTable();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("select * from alumnos", conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dtAlumnos);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, "CargarAlumnos", "Central");
            }
            finally
            {
                conn.Close();
            }
            return dtAlumnos;
        }
        public static DataTable CargarMaterias()
        {
            // codigo para obtener lista de alumno
            DataTable dtMateria = new DataTable();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("select * from materias", conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dtMateria);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, "CargarMaterias", "Central");
            }
            finally
            {
                conn.Close();
            }
            return dtMateria;
        }
        public static DataTable CargarMaestros()
        {
            DataTable dtMaestros = new DataTable();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("SELECT * FROM maestros", conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dtMaestros);  // Llena el DataTable con los registros de la consulta
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, "CargarMaestros", "Central");  // Registra el error si ocurre
            }
            finally
            {
                conn.Close();
            }
            return dtMaestros;
        }
        public static DataTable CargarCalificaciones()
        {
            DataTable dtcalif = new DataTable();
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("SELECT * FROM calificaciones", conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dtcalif);  // Llena el DataTable con los registros de la consulta
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, "CargarCalificaiones", "Central");  // Registra el error si ocurre
            }
            finally
            {
                conn.Close();
            }
            return dtcalif;
        }
    }
}
