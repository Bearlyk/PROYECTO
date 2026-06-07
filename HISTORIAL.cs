using System;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class HISTORIAL : Form
    {
        public HISTORIAL()
        {
            InitializeComponent();
            MostrarTodo();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Hide();
        }

        private void MostrarTodo()
        {
            int i;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            DgvHistorial.Rows.Clear();

            for (i = 0; i < DatosGlobales.totalPartidas; i++)
            {
                if (DatosGlobales.partidas[i].idTorneo == idTorneo)
                {
                    AgregarPartida(i);
                }
            }
        }

        private void Buscar()
        {
            string texto = TxtBuscar.Text.Trim().ToUpper();
            int i;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            if (texto == "")
            {
                MessageBox.Show("Ingrese un texto para buscar.");
                return;
            }

            DgvHistorial.Rows.Clear();

            for (i = 0; i < DatosGlobales.totalPartidas; i++)
            {
                if (DatosGlobales.partidas[i].idTorneo == idTorneo &&
                    (DatosGlobales.partidas[i].nombreJugador1.ToUpper().IndexOf(texto) >= 0 ||
                    DatosGlobales.partidas[i].nombreJugador2.ToUpper().IndexOf(texto) >= 0 ||
                    DatosGlobales.partidas[i].ganador.ToUpper().IndexOf(texto) >= 0))
                {
                    AgregarPartida(i);
                }
            }
        }

        private void AgregarPartida(int i)
        {
            DgvHistorial.Rows.Add(DatosGlobales.partidas[i].fecha,
                                  DatosGlobales.partidas[i].id,
                                  DatosGlobales.partidas[i].nombreJugador1,
                                  DatosGlobales.partidas[i].puntajeJugador1,
                                  DatosGlobales.partidas[i].puntajeJugador2,
                                  DatosGlobales.partidas[i].nombreJugador2,
                                  DatosGlobales.partidas[i].ganador,
                                  DatosGlobales.partidas[i].tipoTorneo);
        }
    }
}

