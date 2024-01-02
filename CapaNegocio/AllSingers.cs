using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CapaDatos;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class AllSingers
    {
        private static AllSingers seeSingers;
        private AllSingers()
        {
            seeSingers = null;
        }

        public static AllSingers singers
        {
            get
            {
                if (seeSingers == null)
                {
                    seeSingers = new AllSingers();
                }
                return seeSingers;
            }
        }
        
        

        public DataTable newe(DataTable dt)
        {                    
           return DatesApp.dates.GetAllSingers(dt); 
        }

        public DataTable buscar(DataTable dt, string st) 
        {
            return DatesApp.dates.buscar(dt, st);
        
        }

        public List<string> allSingers(List<string> singer)
        {
            // mira en vez de usar DatesApp date = new DatesApp();

            // y luego               date.allSingers(singer);

            return DatesApp.dates.allSingers(singer);//Usas esto 
        }

        public DataTable buscarNombre(DataTable dt, string st)
        {
            return DatesApp.dates.buscarPorNombre(dt, st);
        }


        public DataTable buscarPorTexitura(DataTable dt,string st)
        {
            return DatesApp.dates.buscarTexitura(dt, st);
        }
        public DataTable buscarPorEscala(DataTable dt,string st)
        {
            return DatesApp.dates.buscarPorEscala(dt, st);
        }
        public List<string> todasTexituras(List<string> singer)
        {
            return DatesApp.dates.allTexitura(singer);
        }
        public List<string>todasLasEscalas(List<string> note)
        {
            return DatesApp.dates.allscales(note);
        }     


        Dictionary<string, int> datosUsuarios = new Dictionary<string, int>();

      

        public Boolean inicioDeSeccion(string buscarNombre,int clave)
        {
           /* Boolean nombreItem = false;
            Boolean passwordItem = false;*/
            List<string> listaNombres = new List<string>();
            List<int> listaPassword = new List<int>();

            listaNombres.Clear();
            listaPassword.Clear();
            listaNombres = DatesApp.dates.allSingers(listaNombres);
            listaPassword = DatesApp.dates.allPassword(listaPassword);
            // datosUsuarios = listaPassword,listaNombres;


            datosUsuarios.Clear();
            for (int i = 0; i < listaNombres.Count; i++)
            {
                datosUsuarios[listaNombres[i]] = listaPassword[i];
            }

            if (datosUsuarios.TryGetValue(buscarNombre, out int claveCorrecta))
            {
               // MessageBox.Show("Entro al if","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if(claveCorrecta == clave)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("entro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            

           
        }

        /************************************************************************************/

        public DataTable todasLasPropuestas(DataTable dt)
        {
            return DatesApp.dates.todasLasPropuestas(dt);
        }
        public bool agregarPropuesta(string cancion,string nota, int id)
        {
            return DatesApp.dates.agregarPropuesta(cancion,nota,id);
        }
        
        public int idCantante(int code)
        {
            return DatesApp.dates.idCantante(code);
        }

        public void eliminarPropuesta(int code)
        {
            DatesApp.dates.elmiminarPropuestaAgregada(code);
        }

        public DataTable buscarPropuestaPorTexitura(DataTable dt, string st)
        {
            return DatesApp.dates.buscarPropuestasTexitura(dt, st);
        }

        public DataTable buscarPropuestaPorNombre(DataTable dt, string st)
        {
            return DatesApp.dates.buscarPropuestasNombre(dt, st);
        }
        public DataTable buscarPropuestaPorEscala(DataTable dt, string st)
        {
            return DatesApp.dates.buscarPropuestasEscala(dt, st);
        }
        public DataTable buscarPropuesta(DataTable dt, string st)
        {
            return DatesApp.dates.BuscarPropuestas(dt, st);
        }

        public bool editarPropuesta(int id,string cancion, string nota)
        {

            
            return DatesApp.dates.editarPropuesta(id, cancion, nota); 
        }

        public bool aprobarPropuesta(int id)
        {
            return DatesApp.dates.aprobarPropuestas(id);
        }

        /*****************************************************************************************************/


        public DataTable seleccionarCantantesActivos(DataTable dt, int id)
        {
            return DatesApp.dates.seleccionarCantantesActivos(dt,id);
        }

        public bool editarUsuario(int id, string nombre, string apellido, int code,string texitura, int edad)
        {
            return DatesApp.dates.editarUsuario(id, nombre, apellido, code, texitura, edad);
        }
        public DataTable todosLosUsuarios(DataTable dt)
        {
            return DatesApp.dates.cantantesActivos(dt);
        }
        public bool agregarUsuario(string nombre,string apellido,int clave,string texitura,int edad)
        {
            return DatesApp.dates.agregarCantante(nombre, apellido, clave, texitura, edad);
        }

        public bool eliminarUsuario(int id)
        {
            return DatesApp.dates.eliminarCantante(id);
        }
    }
}
