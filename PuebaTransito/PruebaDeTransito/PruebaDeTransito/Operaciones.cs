using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace PruebaDeTransito
{
    class Operaciones
    {
        //Clase encargada de hacer las operaciones necesarias para el programa con la base de datos
        string SQL;
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable tabla = new DataTable();

        //Metodo utilizado para buscar el estudiante y traer el id, puntaje y los intentos
        public DataTable BuscarAcceso(string id)
        {
            tabla.Clear();
            SQL = "select idEstudiante, Puntaje, Intentos from tbEstudiantes where idEstudiante = '" + id + "'";
            Adaptador = new OleDbDataAdapter(SQL, Conexion.conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }

        //Metodo utilizado para insertar el nuevo resultado de la prueba hecha en la base de datos
        public void insertarResultado(string id, int acertadas, int incorrectas, int intentos,Boolean aprobo)
        {
            tabla.Clear();
            SQL = "INSERT INTO tbResultados(idEstudiante, Acertadas, Incorrectas, Intento, Aprobado) VALUES('" + id + "', " + acertadas + ", " + incorrectas + ", " + intentos + ", " + aprobo + ");";
            Adaptador = new OleDbDataAdapter(SQL, Conexion.conexion);
            Adaptador.Fill(tabla);
        }

        //Metodo utilizado para registrar un estudiante en la base de datos
        public Boolean Registro(string id, string nombre, string apellidos, string fecha)
        {
            try
            {
                tabla.Clear();
                SQL = "INSERT INTO tbEstudiantes VALUES('" + id + "','" + nombre + "','" + apellidos + "','" + fecha + "', 0, 0);";
                Adaptador = new OleDbDataAdapter(SQL, Conexion.conexion);
                Adaptador.Fill(tabla);
                return true;
            }
            catch (System.Data.OleDb.OleDbException)
            {
                Form1 mensaje = new Form1();
                mensaje.Mensajes(1);
                return false;
            }
        }

        //Metodo utilizado para buscar todos los estudiantes registrados
        public DataTable TodosLosEstudiantes()
        {
            tabla.Clear();
            SQL = "select * from tbEstudiantes;";
            Adaptador = new OleDbDataAdapter(SQL, Conexion.conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }

        //Metodo utilizado para buscaar todas las preguntas de la base de datos
        public DataTable TodasLasPreguntas()
        {
            tabla.Clear();
            SQL = "select * from tbPreguntas;";
            Adaptador = new OleDbDataAdapter(SQL, Conexion.conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }

        //Metodo utiliado para buscar todos los resultados de las pruebas hechas 
        public DataTable TodosLosResultados()
        {
            tabla.Clear();
            SQL = "select idEstudiante, Acertadas, Incorrectas, Intento, Aprobado from tbResultados;";
            Adaptador = new OleDbDataAdapter(SQL, Conexion.conexion);
            Adaptador.Fill(tabla);
            return tabla;
        }

        //Metodo utilizado para actualizar en la base de datos al puntaje y a los intentos de el estudiante  
        public void actualizarPuntajeEIntentos(int puntaje, int intento, string id)
        {
            tabla.Clear();
            SQL = "Update tbEstudiantes set Puntaje = " + puntaje + ", Intentos= " + intento + " where idEstudiante = '" + id + "';";
            Adaptador = new OleDbDataAdapter(SQL, Conexion.conexion);
            Adaptador.Fill(tabla);
        }
    }
}