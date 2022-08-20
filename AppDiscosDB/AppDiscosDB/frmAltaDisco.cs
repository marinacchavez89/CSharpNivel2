using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace AppDiscosDB
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos disc = new Discos();
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                disc.Titulo = txtTitulo.Text;
                disc.FechaLanzamiento = DateTime.Parse(txtFechaLanzamiento.Text);
                disc.CantidadCanciones = int.Parse(txtCantidadCanciones.Text);
                disc.UrlImagenTapa = txtUrlImagen.Text;
                disc.TiposEstilos = (Estilo)cbEstilo.SelectedItem;
                disc.TiposEdicion = (Edicion)cbTipoEdicion.SelectedItem;

                negocio.agregar(disc);
                MessageBox.Show("Disco agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            EdicionNegocio edicionNegocio = new EdicionNegocio();

            try
            {
                cbEstilo.DataSource = estiloNegocio.listar();
                cbTipoEdicion.DataSource = edicionNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbDiscos.Load(imagen);
            }
            catch (Exception)
            {
                pbDiscos.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }

        }
    }
}
