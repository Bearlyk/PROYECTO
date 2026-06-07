using System;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class JUGADORES : Form
    {
        private int[] posicionesJugadores;

        public JUGADORES()
        {
            InitializeComponent();
            ConectarBotones();
        }

        private void ConectarBotones()
        {
            BtnRegistrarJu.Click += new EventHandler(BtnRegistrarJu_Click);
            BtnEliminarJu.Click += new EventHandler(BtnEliminarJu_Click);
            BtnBuscarJu.Click += new EventHandler(BtnBuscarJu_Click);
        }

        private void BtnVolverJu_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Hide();
        }

        private void JUGADORES_Load(object sender, EventArgs e)
        {
            MostrarJugadores();
        }

        private void BtnRegistrarJu_Click(object sender, EventArgs e)
        {
            RegistrarJugador();
        }

        private void BtnEliminarJu_Click(object sender, EventArgs e)
        {
            EliminarJugador();
        }

        private void BtnBuscarJu_Click(object sender, EventArgs e)
        {
            BuscarJugador();
        }

        public void RegistrarJugador()
        {
            if (TxtNom.Text.Trim() == "" || TxtApo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar nombre y apodo.");
                return;
            }

            Jugador nuevoJugador;
            nuevoJugador.idTorneo = DatosGlobales.ObtenerIdTorneoActual();
            nuevoJugador.id = DatosGlobales.GenerarIdJugador();
            nuevoJugador.nombre = TxtNom.Text.Trim().ToUpper();
            nuevoJugador.apodo = TxtApo.Text.Trim().ToUpper();
            nuevoJugador.puntaje = 0;
            nuevoJugador.ganados = 0;
            nuevoJugador.empatados = 0;
            nuevoJugador.perdidos = 0;
            nuevoJugador.partidasJugadas = 0;
            nuevoJugador.puntosAFavor = 0;
            nuevoJugador.puntosEnContra = 0;

            DatosGlobales.AgregarJugador(nuevoJugador);
            DatosGlobales.GuardarJugadores();

            LimpiarCampos();
            MostrarJugadores();
            MessageBox.Show("Jugador registrado.");
        }

        private void BuscarJugador()
        {
            string texto = TxtNom.Text.Trim();
            int posicion;

            if (texto == "")
            {
                texto = TxtApo.Text.Trim();
            }

            if (texto == "")
            {
                MessageBox.Show("Ingrese nombre, apodo o ID para buscar.");
                return;
            }

            posicion = DatosGlobales.BuscarJugadorPorTexto(texto);

            if (posicion == -1)
            {
                MessageBox.Show("Jugador no encontrado.");
                return;
            }

            SeleccionarFila(BuscarPosicionEnLista(posicion));
            TxtNom.Text = DatosGlobales.jugadores[posicion].nombre;
            TxtApo.Text = DatosGlobales.jugadores[posicion].apodo;
        }

        private void EliminarJugador()
        {
            int posicionLista = ObtenerFilaSeleccionada();
            int posicion;

            if (posicionLista < 0)
            {
                MessageBox.Show("Seleccione un jugador de la lista.");
                return;
            }

            posicion = posicionesJugadores[posicionLista];

            if (DatosGlobales.jugadores[posicion].partidasJugadas > 0)
            {
                MessageBox.Show("No se puede eliminar un jugador con partidas registradas.");
                return;
            }

            DatosGlobales.EliminarJugador(posicion);
            DatosGlobales.GuardarJugadores();
            LimpiarCampos();
            MostrarJugadores();
            MessageBox.Show("Jugador eliminado.");
        }

        private void MostrarJugadores()
        {
            int i;
            int contador = 0;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            posicionesJugadores = new int[DatosGlobales.ContarJugadoresTorneoActual()];
            DgvJugadores.Rows.Clear();

            for (i = 0; i < DatosGlobales.totalJugadores; i++)
            {
                if (DatosGlobales.jugadores[i].idTorneo == idTorneo)
                {
                    posicionesJugadores[contador] = i;
                    contador++;

                    DgvJugadores.Rows.Add(DatosGlobales.jugadores[i].id,
                                           DatosGlobales.jugadores[i].nombre,
                                           DatosGlobales.jugadores[i].apodo,
                                           DatosGlobales.jugadores[i].puntaje);
                }
            }

            DgvJugadores.ClearSelection();
            DgvJugadores.CurrentCell = null;
        }

        private int BuscarPosicionEnLista(int posicionGlobal)
        {
            int i;

            for (i = 0; i < posicionesJugadores.Length; i++)
            {
                if (posicionesJugadores[i] == posicionGlobal)
                {
                    return i;
                }
            }

            return -1;
        }

        private int ObtenerFilaSeleccionada()
        {
            if (DgvJugadores.CurrentRow == null)
            {
                return -1;
            }

            return DgvJugadores.CurrentRow.Index;
        }

        private void SeleccionarFila(int fila)
        {
            if (fila < 0 || fila >= DgvJugadores.Rows.Count)
            {
                return;
            }

            DgvJugadores.ClearSelection();
            DgvJugadores.Rows[fila].Selected = true;
            DgvJugadores.CurrentCell = DgvJugadores.Rows[fila].Cells[0];
        }

        private void LimpiarCampos()
        {
            TxtNom.Text = "";
            TxtApo.Text = "";
            TxtNom.Focus();
        }
    }
}

