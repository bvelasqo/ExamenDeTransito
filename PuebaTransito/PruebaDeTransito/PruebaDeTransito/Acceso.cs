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
    // Formulario encargado del acceso ya sea a la prueba de transito o al panel de administrador
    public partial class Acceso : Form
    {
        Form1 Form1;
        Operaciones operacion = new Operaciones();

        //contructor con parametros utilizados para la gestión de diseño del formulario
        public Acceso(Boolean tipo, Form1 form1)
        {
            InitializeComponent();
            mostrar(tipo);
            Form1 = form1;
        }

        //Dependiendo de lo que se da en el contructor es el tipo de acceso(Estudiante-administrador)
        void mostrar(Boolean tipo)
        {
            if (tipo)
            {
                lblCedula.Visible = true;
                txtCedula.Visible = true;
            }
            else
            {
                lblContraseña.Visible = true;
                txtContraseña.Visible = true;
            }
        }

        //Evento click
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (lblCedula.Visible)
            {
                if (!(txtCedula.Text == ""))
                {
                    string id = txtCedula.Text;
                    DataTable dataTable = new DataTable();
                    dataTable = operacion.BuscarAcceso(id);
                    try
                    {
                        DataRow dataRow = dataTable.Rows[0];
                        if (dataRow["idEstudiante"].ToString() == txtCedula.Text)
                        {
                            prueba p = new prueba(id);
                            p.MdiParent = Form1;
                            p.Show();
                            txtCedula.Text = "";
                           
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Registrate primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCedula.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Llene el campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string contraseña = "12345";
                if (contraseña == txtContraseña.Text)
                {
                    Administrador a = new Administrador();
                    a.MdiParent = Form1;
                    a.Show();
                    txtContraseña.Text = "";
                }
                else
                {
                    MessageBox.Show("CONTRASEÑA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Text = "";
                }
            }
            this.Close();
        }
    }
}
