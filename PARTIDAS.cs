using System;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class PARTIDAS : Form
    {
        private int[] posicionesJugadores;

        public PARTIDAS()
        {
            InitializeComponent();
            CmbTipoTorneo.Items.Clear();
            CmbTipoTorneo.Items.Add(DatosGlobales.ObtenerTipoTorneoActual());
            CmbTipoTorneo.SelectedIndex = 0;
            CargarJugadoresEnCombos();
            MostrarPartidas();
        }

        private void CargarJugadoresEnCombos()
        {
            int i;
            int contador = 0;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            posicionesJugadores = new int[DatosGlobales.ContarJugadoresTorneoActual()];
            CmbJugador1.Items.Clear();
            CmbJugador2.Items.Clear();

            for (i = 0; i < DatosGlobales.totalJugadores; i++)
            {
                if (DatosGlobales.jugadores[i].idTorneo == idTorneo)
                {
                    posicionesJugadores[contador] = i;
                    contador++;
                    CmbJugador1.Items.Add(DatosGlobales.jugadores[i].id + " - " + DatosGlobales.jugadores[i].nombre);
                    CmbJugador2.Items.Add(DatosGlobales.jugadores[i].id + " - " + DatosGlobales.jugadores[i].nombre);
                }
            }

            if (posicionesJugadores.Length > 0)
            {
                CmbJugador1.SelectedIndex = 0;
            }

            if (posicionesJugadores.Length > 1)
            {
                CmbJugador2.SelectedIndex = 1;
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarPartida();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Hide();
        }

        private void RegistrarPartida()
        {
            int puntos1;
            int puntos2;
            int pos1;
            int pos2;

            if (ValidarPartida() == false)
            {
                return;
            }

            puntos1 = Convert.ToInt32(TxtPuntos1.Text);
            puntos2 = Convert.ToInt32(TxtPuntos2.Text);
            pos1 = posicionesJugadores[CmbJugador1.SelectedIndex];
            pos2 = posicionesJugadores[CmbJugador2.SelectedIndex];

            Partida partida;
            partida.idTorneo = DatosGlobales.ObtenerIdTorneoActual();
            partida.id = DatosGlobales.GenerarIdPartida();
            partida.idJugador1 = DatosGlobales.jugadores[pos1].id;
            partida.idJugador2 = DatosGlobales.jugadores[pos2].id;
            partida.nombreJugador1 = DatosGlobales.jugadores[pos1].nombre;
            partida.nombreJugador2 = DatosGlobales.jugadores[pos2].nombre;
            partida.puntajeJugador1 = puntos1;
            partida.puntajeJugador2 = puntos2;
            partida.ganador = CalcularGanador(partida.nombreJugador1, partida.nombreJugador2, puntos1, puntos2);
            partida.fecha = DateTime.Now.ToShortDateString();
            partida.estado = "FINALIZADA";
            partida.tipoTorneo = CmbTipoTorneo.Text;

            ActualizarJugadores(pos1, pos2, puntos1, puntos2);
            DatosGlobales.AgregarPartida(partida);
            DatosGlobales.GuardarDatos();

            MostrarPartidas();
            Limpiar();
            MessageBox.Show("Partida registrada.");
        }

        private bool ValidarPartida()
        {
            int numero;

            if (DatosGlobales.ContarJugadoresTorneoActual() < 2)
            {
                MessageBox.Show("Debe registrar al menos dos jugadores en este torneo.");
                return false;
            }

            if (CmbJugador1.SelectedIndex < 0 || CmbJugador2.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione ambos jugadores.");
                return false;
            }

            if (CmbJugador1.SelectedIndex == CmbJugador2.SelectedIndex)
            {
                MessageBox.Show("Los jugadores deben ser diferentes.");
                return false;
            }

            if (int.TryParse(TxtPuntos1.Text, out numero) == false ||
                int.TryParse(TxtPuntos2.Text, out numero) == false)
            {
                MessageBox.Show("Los puntajes deben ser numeros enteros.");
                return false;
            }

            if (Convert.ToInt32(TxtPuntos1.Text) < 0 || Convert.ToInt32(TxtPuntos2.Text) < 0)
            {
                MessageBox.Show("Los puntajes no pueden ser negativos.");
                return false;
            }

            return true;
        }

        private string CalcularGanador(string jugador1, string jugador2, int puntos1, int puntos2)
        {
            if (puntos1 > puntos2)
            {
                return jugador1;
            }

            if (puntos2 > puntos1)
            {
                return jugador2;
            }

            return "EMPATE";
        }

        private void ActualizarJugadores(int pos1, int pos2, int puntos1, int puntos2)
        {
            DatosGlobales.jugadores[pos1].partidasJugadas++;
            DatosGlobales.jugadores[pos2].partidasJugadas++;
            DatosGlobales.jugadores[pos1].puntosAFavor += puntos1;
            DatosGlobales.jugadores[pos1].puntosEnContra += puntos2;
            DatosGlobales.jugadores[pos2].puntosAFavor += puntos2;
            DatosGlobales.jugadores[pos2].puntosEnContra += puntos1;

            if (puntos1 > puntos2)
            {
                DatosGlobales.jugadores[pos1].ganados++;
                DatosGlobales.jugadores[pos2].perdidos++;
                DatosGlobales.jugadores[pos1].puntaje += 3;
            }
            else
            {
                if (puntos2 > puntos1)
                {
                    DatosGlobales.jugadores[pos2].ganados++;
                    DatosGlobales.jugadores[pos1].perdidos++;
                    DatosGlobales.jugadores[pos2].puntaje += 3;
                }
                else
                {
                    DatosGlobales.jugadores[pos1].empatados++;
                    DatosGlobales.jugadores[pos2].empatados++;
                    DatosGlobales.jugadores[pos1].puntaje++;
                    DatosGlobales.jugadores[pos2].puntaje++;
                }
            }
        }

        private void MostrarPartidas()
        {
            int i;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            DgvPartidas.Rows.Clear();

            for (i = 0; i < DatosGlobales.totalPartidas; i++)
            {
                if (DatosGlobales.partidas[i].idTorneo == idTorneo)
                {
                    DgvPartidas.Rows.Add(DatosGlobales.partidas[i].id,
                                          DatosGlobales.partidas[i].nombreJugador1,
                                          DatosGlobales.partidas[i].puntajeJugador1,
                                          DatosGlobales.partidas[i].puntajeJugador2,
                                          DatosGlobales.partidas[i].nombreJugador2,
                                          DatosGlobales.partidas[i].ganador,
                                          DatosGlobales.partidas[i].tipoTorneo);
                }
            }
        }

        private void Limpiar()
        {
            TxtPuntos1.Text = "";
            TxtPuntos2.Text = "";
            TxtPuntos1.Focus();
        }
    }
}

