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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        Operaciones operacion = new Operaciones();
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (txtNombres.Text != "")
                {
                    if (txtApellidos.Text != "")
                    {
                        Boolean registrado = operacion.Registro(txtID.Text, txtNombres.Text, txtApellidos.Text, dtpFecha.Value.Date.ToString());
                        if (registrado)
                        {
                            MessageBox.Show("Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        txtID.Text = txtNombres.Text = txtApellidos.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el campo Apellidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el campo Nombres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el campo ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
