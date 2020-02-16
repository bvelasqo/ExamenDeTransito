using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeTransito
{
    public partial class Form1 : Form
    {
        //Formulario principal utilizado para contener todas las funciones del programa
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo encargado de dar un mensaje de aviso por si hay algun error en el registro
        public void Mensajes(int excepcion)
        {
            switch (excepcion)
            {
                case 1:
                    MessageBox.Show("ID existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        } 

        Operaciones operacion = new Operaciones();

        //Metodo encargado de guardar en la base de datos los resultados de la prueba
        public void puntaje(int puntosGanados, int incorrectas, Boolean aprobo, string id)
        {
            DataTable dataTable = operacion.BuscarAcceso(id);
            DataRow dataRow = dataTable.Rows[0];
            int puntaje = Convert.ToInt32(dataRow["Puntaje"].ToString()) + puntosGanados;
            int intentos = Convert.ToInt32(dataRow["Intentos"].ToString()) + 1;
            operacion.actualizarPuntajeEIntentos(puntaje, intentos, id);
            operacion.insertarResultado(id, puntosGanados, incorrectas, intentos, aprobo);
        }

        //Entrar a la prueba
        private void AccesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso(true,this);
            acceso.MdiParent = this;
            acceso.Show();
        }

        //Entrar al panel de administradores
        private void AdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso(false,this);
            acceso.MdiParent = this;
            acceso.Show();
        }

        //Ingresar al formulario registro
        private void RegistrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.MdiParent = this;
            r.Show();
        }
    }
}
