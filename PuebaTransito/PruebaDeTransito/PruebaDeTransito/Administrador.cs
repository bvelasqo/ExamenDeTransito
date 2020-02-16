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
    /*Formulario utilizado para dar los controles del administrador ya sea 
     * manipular preguntas o ver resultados de la prueba e informacion de
     * estudiantes*/
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        Operaciones operacion = new Operaciones();

        //Muestra el manejo de las preguntas
        private void BtnPreguntas_Click(object sender, EventArgs e)
        {
            GestionDePreguntas gp = new GestionDePreguntas();
            gp.Show();
            dgvEstudiantes.Visible = false;

        }

        //Muestra la informacion de los estudiantes
        private void BtnEYR_Click(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            dgvEstudiantes.DataSource = operacion.TodosLosEstudiantes();
            dgvEstudiantes.Visible = true;
        }

        //muestra los resultados de las pruebas
        private void BtnResultados_Click(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            dgvEstudiantes.DataSource = operacion.TodosLosResultados();
            dgvEstudiantes.Visible = true;
        }
    }
}
