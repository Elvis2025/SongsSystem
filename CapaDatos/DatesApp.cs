using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CapaDatos
{
   public class DatesApp
    {

        private static DatesApp app;
        private DatesApp()
        {
            app = null;
        } 
        
        public static DatesApp dates
        {
            get
            {
                if (app == null )
                {
                    app = new DatesApp();
                }

                return app;
            }
        }




        /********* Vista de Usuario ********************/


        
      


        /***** Datos almacenados en listas ******/
        public List<string> allSingers(List<string> singers)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select nombre from singers", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string singer = reader.GetString(0);
                            singers.Add(singer);
                        }
                    }
                }
                connection.Close();
            }
            return singers;
        }

        public List<int> allPassword(List<int> singers)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT singerCode FROM singers\r\nORDER BY id;", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int singer = reader.GetInt32(0);
                            singers.Add(singer);
                        }
                    }
                }
                connection.Close();
            }
            return singers;
        }

        public List<string> allscales(List<string> scales)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Distinct musicalScale FROM SongsTrunk UNION SELECT distinct musicalScale FROM Proposals;", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string singer = reader.GetString(0);
                            scales.Add(singer);
                        }
                    }
                }
                connection.Close();
            }
            return scales;
        }

        public List<string> allTexitura(List<string> texitura)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT DISTINCT texituraVocal\r\nFROM singers;", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string singer = reader.GetString(0);
                            texitura.Add(singer);
                        }
                    }
                }
                connection.Close();
            }
            return texitura;
        }

        /******************************************************/





        /*** Busqueda En Vista General, todas los querys son del la tabla SongTrunk*****/

        public DataTable GetAllSingers(DataTable dataTable)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName, s.texituraVocal\r\nFROM songsTrunk st\r\nINNER JOIN singers s ON st.idSingers = s.id;", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }
        public DataTable buscarPorEscala(DataTable dt, string busqueda)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPorNombreEscala @nombreBusqueda = '"+busqueda+"'", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                connection.Close();
            }
            return dt;
        }
        public DataTable buscarPorNombre(DataTable dt, string busqueda)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPorNombreUsuario @nombreBusqueda = '"+busqueda+"'", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                connection.Close();
            }
            return dt;
        }
        public DataTable buscarTexitura(DataTable dt, string busqueda)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPorTexitura @nombreBusqueda = '"+busqueda+"'", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                connection.Close();
            }
            return dt;
        }
        public DataTable buscar(DataTable dt, string busqueda)
        {
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPropuestasPorNombres @nombreBusqueda = '" + busqueda + "'", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
                connection.Close();
            }
            return dt;
        }
        /*************************************************/

        /************* Busqueda De la tabla proposals   ************************************/
        public DataTable todasLasPropuestas(DataTable dataTable)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT \r\n " +
                    "   p.id,\r\n    p.nameSong,\r\n    p.musicalScale,\r\n    s.nombre AS singerName,\r\n  " +
                    "  s.texituraVocal\r\nFROM proposals AS p\r\nINNER JOIN singers AS s ON p.idSingers = s.id;", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }

        public DataTable BuscarPropuestas(DataTable dataTable,string nombre)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPropuestas @nombreBusqueda = '"+nombre+"';", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }

        public DataTable buscarPropuestasNombre(DataTable dataTable, string nombre)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPorNombre @nombreCantante = '"+nombre+"';", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }

        public DataTable buscarPropuestasEscala(DataTable dataTable,string nombre)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPorEscala @escalaMusical = '" + nombre+"';", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }

        public DataTable buscarPropuestasTexitura(DataTable dataTable, string nombre)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC BuscarPropuestasPorTexturaVocal @texituraBusqueda = '" + nombre + "';", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }

        public bool aprobarPropuestas(int id)
        {

            bool actualizado;
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE proposals\r\nSET stateProposals = 1\r\nWHERE id = '"+id+"';", connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        actualizado = true;
                    }
                    catch
                    {
                        actualizado = false;
                    }


                }
                connection.Close();
            }
            if(actualizado == true)
            {
                aprobandoPropuestas();
            }
            return actualizado;

        }
        public void aprobandoPropuestas()
        {

          
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("delete from proposals where stateProposals = 1;", connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Error de Conexion.");
                    }


                }
                connection.Close();
            }           

        }

        public bool elmiminarPropuestaAgregada(int id)
        {
            bool eliminado;
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("delete from proposals \r\nwhere id = '"+id+"';", connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        eliminado = true;
                    }
                    catch
                    {
                        eliminado = false;
                    }
                       
                    
                }
                connection.Close();
            }
            return eliminado;
        }

        public bool agregarPropuesta(string cancion, string nota, int id)
        {
            bool agregar;
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("insert into proposals values('" + cancion + "','"+nota+"','"+id+"',0)", connection))
                {
                    try
                    {
/*                        insert into proposals values('','',4,0)*/
                        command.ExecuteNonQuery();
                        agregar = true;
                       
                    }
                    catch
                    {
                        agregar = false;
                        
                    }


                }
                connection.Close();
            }
            return agregar;
        }

        public int idCantante(int code)
        {
            int id;
           
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ObtenerIdPorClave", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@singerCode", SqlDbType.Int).Value = code;
                    command.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    id = Convert.ToInt32(command.Parameters["@id"].Value);



                }
                connection.Close();
            }
            return id;
        }


        public bool editarPropuesta(int id,string cancion, string nota)
        {
           
            bool agregar;
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("\r\nEXEC EditarCancion @id ="+id+", @nameSong = '"+cancion+"', @musicalScale = '"+nota+"'", connection))
                {
                    try
                    {
                        /*                        insert into proposals values('','',4,0)*/
                        
                        command.ExecuteNonQuery();
                        
                        agregar = true;
                        
                    }
                    catch
                    {
                        
                        agregar = false;

                    }


                }
                connection.Close();
            }
           
            return agregar;
        }


        /********* operaciones en la tabla cantantes ********************************************************/


        public bool agregarCantante(string nombre,string apellido,int clave,string texitura,int edad)
        {
            bool agregar;
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("insert into singers values ('"+nombre+"','"+apellido+"',"+clave+",'"+texitura+"',"+edad+",0)", connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        agregar = true;
                    }
                    catch
                    {
                        agregar = false;
                    }


                }
                connection.Close();
            }
            return agregar;
        }

        public bool eliminarCantante(int id)
        {
            bool eliminado;
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EXEC EliminarCantante @CantanteID = "+id+";", connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        eliminado = true;
                      
                    }
                    catch
                    {
                        eliminado = false;
                       
                    }


                }
                connection.Close();
            }
            return eliminado;
        }







        public DataTable cantantesActivos(DataTable dataTable)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select id,nombre,apellido,singerCode,texituraVocal,edad from singers", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }
        public DataTable seleccionarCantantesActivos(DataTable dataTable,int id)
        {
            //DataTable dataTable = new DataTable();

            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select nombre, apellido, singerCode, texituraVocal, edad from singers\r\n\twhere id = "+id+"", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }

            return dataTable;
        }


        public bool editarUsuario(int id,string nombre,string apellido,int code,string texitura,int edad)
        {
          /*  MessageBox.Show("No entro" + id + nombre + code);*/
            bool agregar;
            using (SqlConnection connection = DbDate.inf.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("exec actualizarCantante @id = "+id+",@nombreA = '"+nombre+"',@apellidoA = '"+apellido+"', @singerCodeA = "+code+", @texituraVocalA = '"+texitura+"', @edadA = "+edad+";", connection))
                {
                    try
                    {
                        /*                        insert into proposals values('','',4,0)*/

                        command.ExecuteNonQuery();

                        agregar = true;

                    }
                    catch
                    {

                        agregar = false;

                    }


                }
                connection.Close();
            }

            return agregar;
        }


    }
}
