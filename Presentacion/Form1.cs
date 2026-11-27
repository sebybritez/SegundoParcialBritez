using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private BLL.CuerpoCeleste gestorCuerpo = new BLL.CuerpoCeleste();
        private BLL.Tipo gestorTipo = new BLL.Tipo();
        private BLL.Satelite gestorSatelite = new BLL.Satelite();
        private BE.CuerpoCeleste cuerpoSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = gestorTipo.Listar();
            cmbTipo.DisplayMember = "Nombre";
            cmbTipo.ValueMember = "ID";
            Enlazar();
        }

        private void Enlazar()
        {
            txtNombre.Text = "";
            if (cmbTipo.Items.Count > 0)
            {
                cmbTipo.SelectedIndex = 0;
            }
            cuerpoSeleccionado = null;

            dgvCuerpos.DataSource = null;
            dgvCuerpos.DataSource = gestorCuerpo.Listar();
            dgvCuerpos.ClearSelection();

            cmbPlaneta.DataSource = null;
            cmbPlaneta.DataSource = gestorCuerpo.Listar();
            cmbPlaneta.DisplayMember = "Nombre";
            cmbPlaneta.ValueMember = "ID";

            cmbSatelite.DataSource = null;
            cmbSatelite.DataSource = gestorCuerpo.Listar();
            cmbSatelite.DisplayMember = "Nombre";
            cmbSatelite.ValueMember = "ID";

            dgvSatelites.DataSource = null;
            dgvSatelites.DataSource = gestorSatelite.Listar();
            dgvSatelites.ClearSelection();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el cuerpo celeste.", "Validación");
            }
            else if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo.", "Validación");
            }
            else
            {
                BE.CuerpoCeleste nuevo = new BE.CuerpoCeleste();
                nuevo.Nombre = txtNombre.Text.Trim();
                nuevo.Tipo = (BE.Tipo)cmbTipo.SelectedItem;

                gestorCuerpo.Grabar(nuevo);
                Enlazar();
                MessageBox.Show("Cuerpo celeste registrado correctamente.", "Alta");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cuerpoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cuerpo celeste de la grilla para modificar.", "Validación");
            }
            else if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el cuerpo celeste.", "Validación");
            }
            else if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo.", "Validación");
            }
            else
            {
                cuerpoSeleccionado.Nombre = txtNombre.Text.Trim();
                cuerpoSeleccionado.Tipo = (BE.Tipo)cmbTipo.SelectedItem;

                gestorCuerpo.Grabar(cuerpoSeleccionado);
                Enlazar();
                MessageBox.Show("Cuerpo celeste modificado correctamente.", "Modificación");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cuerpoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cuerpo celeste de la grilla para dar de baja.", "Validación");
            }
            else
            {
                gestorCuerpo.Baja(cuerpoSeleccionado);
                Enlazar();
            }
        }

        private void btnAltaSatelite_Click(object sender, EventArgs e)
        {
            if (cmbPlaneta.SelectedItem == null || cmbSatelite.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un planeta y un satélite.", "Validación");
            }
            else
            {
                BE.CuerpoCeleste planeta = (BE.CuerpoCeleste)cmbPlaneta.SelectedItem;
                BE.CuerpoCeleste satelite = (BE.CuerpoCeleste)cmbSatelite.SelectedItem;

                string error = gestorSatelite.Insertar(planeta, satelite);
                if (error != "")
                {
                    MessageBox.Show(error, "Validación");
                }
                else
                {
                    Enlazar();
                    MessageBox.Show("Satélite asociado correctamente al planeta.", "Alta de Satélite");
                }
            }
        }

        private void dgvCuerpos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cuerpoSeleccionado = dgvCuerpos.CurrentRow.DataBoundItem as BE.CuerpoCeleste;
                if (cuerpoSeleccionado != null)
                {
                    txtNombre.Text = cuerpoSeleccionado.Nombre;
                    if (cuerpoSeleccionado.Tipo != null)
                    {
                        cmbTipo.SelectedValue = cuerpoSeleccionado.Tipo.ID;
                    }
                }
            }
        }
    }
}
