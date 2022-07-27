using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")            
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = Color.White;

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red; 
            else
                txtNombre.BackColor = Color.White;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = Color.White;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = Color.White;
            

            if (txtApellido.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtDireccion.Text != "") 
            {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;

             txtResultado.Text = "Apellido y nombre: " + apellido + ", " + nombre + Environment.NewLine + "Edad: " + edad +
             Environment.NewLine + "Dirección: " + direccion;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                {
                e.Handled = false;
                }
            else if (Char.IsControl(e.KeyChar))
                {
                e.Handled = false;
                }
            else if (Char.IsSeparator(e.KeyChar))
                {
                e.Handled = false;
                }
            else
                {
                 e.Handled = true;
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }
    }
}
