using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Service_Music
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service2 : IService2
    {
        public void Guardar(string NC, string NA, string Colb, string Gene, string Disqu, string FC)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-OP33RST;Initial Catalog=Musica;Integrated Security=false;user=Aaron;password=123");
            con.Open();
            cadena = "insert into  BibliotecaM values('" + NC + "','" + NA + "','" + Colb + "','" + Gene + "','" + Disqu + "','" + FC + "')";
            cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //BORRAR
        public bool Borrar(int idc)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-OP33RST;Initial Catalog=Musica;Integrated Security=false;user=Aaron;password=123");
            con.Open();
            cadena = "delete from BibliotecaM where IDArtista=" + idc;
            cmd = new SqlCommand(cadena, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();
        }

        public bool editar( string NC, string NA, string Colb, string Gene, string Disqu, string fc)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-OP33RST;Initial Catalog=Musica;Integrated Security=false;user=Aaron;password=123");
            con.Open();
            cadena = "UPDATE BibliotecaM SET  Nombre_Cancion= ('" + NC + "'), Nombre_Album= ('" + NA + "')  , Colaboradores= ('" + Colb + "'), Genero= ('" + Gene + "'), Disquera= ('" + Disqu + "') , Fecha_Creacion= ('" + fc + "')where Nombre_Cancion= ('" + NC + "') ";
            cmd = new SqlCommand(cadena, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();
        }

               //VERIFICACION
        public bool verificar(string art, string contra)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            SqlDataReader datos;
            DataTable tabla = new DataTable();
            bool res = false;
            con = new SqlConnection("Data Source=DESKTOP-OP33RST;Initial Catalog=Musica;Integrated Security=false;user=Aaron;password=123");
            con.Open();
            cadena = string.Format("select * from Usuarios where Artis_Nom ='{0}' and Pass='{1}'",  art, contra);

            cmd = new SqlCommand(cadena, con);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                res = true;
            }
            con.Close();
            return res;

        }
        //CIERRA 
        //GUARDAR USUARIO
        public bool Regi_guar(string art, string pas, string corr)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source = DESKTOP-OP33RST; Initial Catalog = Musica; Integrated Security = false; user = Aaron; password = 123");
            con.Open();
            cadena = "insert into Usuarios values ('" + art + "','" + pas + "','" + corr + "' )";
            cmd = new SqlCommand(cadena, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
            con.Close();
        
        //CERRAR USUSARIO

    }
        //BUSQUEDA
        public string[] buscar(string nom)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dato;
            string cadena = "";
            string[] datos = new string[6];
            con = new SqlConnection("Data Source=DESKTOP-OP33RST;Initial Catalog=Musica;Integrated Security=false;user=Aaron;password=123");
            con.Open();
            cadena = "select * from BibliotecaM where Nombre_Cancion ='" + nom + "'";
            cmd = new SqlCommand(cadena, con);
            dato = cmd.ExecuteReader();
            if (dato.Read())
            {


                datos[0] = Convert.ToString(dato.GetInt32(0));
                datos[1] = dato.GetString(1);
                datos[2] = dato.GetString(2);
                datos[3] = dato.GetString(3);
                datos[4] = dato.GetString(4);
                datos[5] = dato.GetString(5);
                datos[6] = dato.GetString(6);
               


            }

            con.Close();
            return datos;


        }
    }//CIERRA

}//CIERRA
