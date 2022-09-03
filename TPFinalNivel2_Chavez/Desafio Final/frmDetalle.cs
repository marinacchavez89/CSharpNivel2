using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace Desafio_Final
{
    public partial class frmDetalle : Form
    {
        private Articulo seleccionado;

        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulo seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            Text = "Detalle del artículo";
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                cargarImagen(seleccionado.ImagenUrl);
                txtNombreDetalle.Text = seleccionado.Nombre;
                txtDescripcionDetalle.Text = seleccionado.Descripcion;
                txtMarcaDetalle.Text = seleccionado.TipoMarca.ToString();
                txtCategoriaDetalle.Text = seleccionado.TipoCategoria.ToString();
                txtPrecioDetalle.Text = seleccionado.Precio.ToString(); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxImagen.Load("https://bocashop.vteximg.com.br/arquivos/ids/163215-1000-1000/not-available-es.png?v=637443433440730000");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
