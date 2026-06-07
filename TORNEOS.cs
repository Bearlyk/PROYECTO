using System;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class TORNEOS : Form
    {
        public TORNEOS()
        {
            InitializeComponent();
            MostrarTorneos();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CrearTorneo();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarTorneo();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Hide();
        }

        private void CrearTorneo()
        {
            if (TxtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del torneo.");
                return;
            }

            Torneo torneo;
            torneo.id = DatosGlobales.GenerarIdTorneo();
            torneo.nombre = TxtNombre.Text.Trim().ToUpper();
            torneo.tipo = CmbTipo.Text;
            torneo.fechaInicio = DateTime.Now.ToShortDateString();
            torneo.estado = "ACTIVO";

            DatosGlobales.AgregarTorneo(torneo);
            DatosGlobales.torneoSeleccionado = DatosGlobales.totalTorneos - 1;
            DatosGlobales.GuardarTorneos();

            TxtNombre.Text = "";
            MostrarTorneos();
            MessageBox.Show("Torneo creado y seleccionado.");
        }

        private void SeleccionarTorneo()
        {
            if (DgvTorneos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            DatosGlobales.torneoSeleccionado = DgvTorneos.CurrentRow.Index;
            MostrarTorneos();
            MessageBox.Show("Torneo seleccionado: " + DatosGlobales.ObtenerNombreTorneoActual());
        }

        private void MostrarTorneos()
        {
            int i;
            string marca;

            DgvTorneos.Rows.Clear();

            for (i = 0; i < DatosGlobales.totalTorneos; i++)
            {
                marca = "  ";

                if (i == DatosGlobales.torneoSeleccionado)
                {
                    marca = "* ";
                }

                DgvTorneos.Rows.Add(marca,
                                     DatosGlobales.torneos[i].id,
                                     DatosGlobales.torneos[i].nombre,
                                     DatosGlobales.torneos[i].tipo,
                                     DatosGlobales.torneos[i].fechaInicio,
                                     DatosGlobales.torneos[i].estado);
            }

            if (DatosGlobales.torneoSeleccionado >= 0 &&
                DatosGlobales.torneoSeleccionado < DgvTorneos.Rows.Count)
            {
                DgvTorneos.ClearSelection();
                DgvTorneos.Rows[DatosGlobales.torneoSeleccionado].Selected = true;
                DgvTorneos.CurrentCell = DgvTorneos.Rows[DatosGlobales.torneoSeleccionado].Cells[0];
            }
        }
    }
}

