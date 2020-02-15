using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PruebaDeTransito
{
    public partial class GestionDePreguntas : Form
    {
        public GestionDePreguntas()
        {
            InitializeComponent();
            MessageBox.Show("1. Si se va a ingresar o actualizar una pregunta recuerde primero" 
                                +" guardar la imagen en la carpeta imagenes del archivo del proyecto,"
                                +" luego en la base de datos poner el nombre de la imagen más el"
                                + @"tipo de imagen (.jpg, .png, ...).
2. Al poner la respuesta recuerde poner la misma que alguna de las 4"
                                + " opciones que le diste, se pone lo que se introdujo en el campo mas no"
                                + " el nombre del campo", "RECORDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GestionDePreguntas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPrueba1DataSet.tbPreguntas' table. You can move, or remove it, as needed.
            this.tbPreguntasTableAdapter.Fill(this.bDPrueba1DataSet.tbPreguntas);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tbPreguntasBindingSource.EndEdit();
                this.tbPreguntasTableAdapter.Update(this.bDPrueba1DataSet.tbPreguntas);
                MessageBox.Show("Datos actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
