using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace PruebaDeTransito
{
    //formulario encargado de hacer la prueba de transito a los estudiantes matriculados
    public partial class prueba : Form
    {
        public int cont1 = 0;
        public int malas = 0;
        public int puntaje = 0;
        public int preguntas;
        public string idActual;
        Operaciones operacion = new Operaciones();
        DataTable dataTable;
        DataRow dataRow;

        //Contructor con parametro utilizado para saber quien está realizando la prueba
        public prueba(string id)
        {
            idActual = id;
            InitializeComponent();
            dataTable = operacion.TodasLasPreguntas();
            preguntas = dataTable.Rows.Count;
            MessageBox.Show("Esta prueba consta de " + preguntas + " preguntas, si contestas 5 o más preguntas"
                                           + " de forma erronea perderás la prueba, esta prueba tiene intentos"
                                           + " ilimitados, mucha suerte", "INSTRUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo utilizado para pasar de pregunta y llenar los datos del formulario en base a la base de datos
        void actualizar()
        {
            if (preguntas == 0)
            {
                MessageBox.Show("No hay preguntas registradas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                try
                {
                    if (preguntas == cont1)
                    {
                        btnSiguiente.Text = "Finalizar";
                    }
                    dataRow = dataTable.Rows[cont1];
                    cbxOpciones.Items.Clear();
                    cbxOpciones.Text = "";
                    cbxOpciones.Items.Add(dataRow["Opcion1"].ToString());
                    cbxOpciones.Items.Add(dataRow["Opcion2"].ToString());
                    cbxOpciones.Items.Add(dataRow["Opcion3"].ToString());
                    cbxOpciones.Items.Add(dataRow["Opcion4"].ToString());
                    PXImagen.BackgroundImage = Image.FromFile("../../../Imagenes/" + dataRow["Imagen"].ToString());
                    PXImagen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (System.ArgumentException)
                {
                    PXImagen.BackgroundImage = PXImagen.ErrorImage;
                    MessageBox.Show("Dile a tu asesor que no existe la imagen dada", "Error en la imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    Boolean aprobo;
                    if (malas > 4)
                    {
                        MessageBox.Show("Puntaje " + puntaje + @"
"
                                        +"No Aprobaste", "Estado De Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aprobo = false;
                    }
                    else
                    {
                        MessageBox.Show("Puntaje " + puntaje + @"
"
                                        + "Aprobaste", "Estado De Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aprobo = true;
                    }
                    this.Close();
                    Form1 f = new Form1();
                    f.Show();
                    f.puntaje(puntaje, malas, aprobo, idActual);
                    f.Close();
                }
            }
        }

        //Evento para pasar de pregunta o terminar la prueba
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxOpciones.Text == "")
                {
                    MessageBox.Show("Seleccione una respuesta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!(dataRow["Respuesta"].ToString() == cbxOpciones.Text))
                    {
                        malas++;
                    }
                    else
                    {
                        puntaje++;
                    }
                    cont1++;
                    actualizar();
                }
        }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
}

        //Evento para comenzar la prueba
        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            actualizar();
            lblOpciones.Visible = true;
            lblPregunta.Visible = true;
            PXImagen.Visible = true;
            cbxOpciones.Visible = true;
            btnSiguiente.Visible = true;
            btnComenzar.Visible = false;
        }
    }
}
