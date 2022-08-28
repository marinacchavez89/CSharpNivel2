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
    public partial class Form1 : Form
    {
        private List<Discos> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Cantidad Canciones");
            cboCampo.Items.Add("Estilo");
            cboCampo.Items.Add("Edicion");
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {   
            if(dgvDiscos.CurrentRow != null)
            {
                Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
            
        }

        private void cargar()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                ocultarColumnas();
                cargarImagen(listaDiscos[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado;
            seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            frmAltaDisco modificar = new frmAltaDisco(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
        
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {   
            DiscosNegocio negocio = new DiscosNegocio();
            Discos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que deseea eliminar el registro?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //En este ejemplo tambien muestra eliminar logico, permitiendo resguardar la base de datos. Lo hace con una columna BIT
        //de tipo boolean con "Activo" 1 o 0 pero en la base de datos no hay esta columna de activos.

        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el campo para filtrar, por favor.");
                return true;
            }
            if(cboCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el criterio para filtrar, por favor.");
                return true;
            }
            if(cboCampo.SelectedItem.ToString() == "Cantidad Canciones")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingrese un valor para filtrar Cantidad Canciones, por favor.");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Ingrese solo números para Cantidad Canciones, por favor.");
                    return true;
                }
            }
                

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {   
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvDiscos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Discos> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.TiposEstilos.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaDiscos;
            }

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Cantidad Canciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
