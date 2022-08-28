using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace AppDiscosDB
{
    public partial class frmAltaDisco : Form
    {
        private Discos discos = null;
        private OpenFileDialog archivo = null;
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        public frmAltaDisco(Discos discos)
        {
            InitializeComponent();
            this.discos = discos;
            Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (discos == null)
                    discos = new Discos();
                discos.Titulo = txtTitulo.Text;
                discos.FechaLanzamiento = DateTime.Parse(txtFechaLanzamiento.Text);
                discos.CantidadCanciones = int.Parse(txtCantidadCanciones.Text);
                discos.UrlImagenTapa = txtUrlImagen.Text;
                discos.TiposEstilos = (Estilo)cbEstilo.SelectedItem;
                discos.TiposEdicion = (Edicion)cbTipoEdicion.SelectedItem;

                if (discos.Id != 0)
                {
                    negocio.modificar(discos);
                    MessageBox.Show("Disco modificado exitosamente.");
                }
                else
                {
                    negocio.agregar(discos);
                    MessageBox.Show("Disco agregado exitosamente.");
                }

                //Guardo img si la levantó localmente:
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }

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
                cbEstilo.ValueMember = "Id";
                cbEstilo.DisplayMember = "Descripcion";
                cbTipoEdicion.DataSource = edicionNegocio.listar();
                cbTipoEdicion.ValueMember = "Id";
                cbTipoEdicion.DisplayMember = "Descripcion";

                if (discos != null)
                {
                    txtTitulo.Text = discos.Titulo;
                    txtFechaLanzamiento.Text = discos.FechaLanzamiento.ToString();
                    txtCantidadCanciones.Text = discos.CantidadCanciones.ToString();
                    txtUrlImagen.Text = discos.UrlImagenTapa;
                    cargarImagen(discos.UrlImagenTapa);
                    cbEstilo.SelectedValue = discos.TiposEstilos.Id;
                    cbTipoEdicion.SelectedValue = discos.TiposEdicion.Id;
                }
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            archivo.ShowDialog();
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //Guardar imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }
    }
}
