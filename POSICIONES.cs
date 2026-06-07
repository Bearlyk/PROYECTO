using System;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class POSICIONES : Form
    {
        public POSICIONES()
        {
            InitializeComponent();
            MostrarPosiciones();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MostrarPosiciones();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Hide();
        }

        private void MostrarPosiciones()
        {
            Jugador[] ordenados = CopiarJugadores();
            int i;
            int diferencia;

            OrdenarJugadores(ordenados);
            DgvPosiciones.Rows.Clear();

            for (i = 0; i < ordenados.Length; i++)
            {
                diferencia = ordenados[i].puntosAFavor - ordenados[i].puntosEnContra;
                DgvPosiciones.Rows.Add((i + 1).ToString("D2"),
                                        ordenados[i].id,
                                        ordenados[i].nombre,
                                        ordenados[i].puntaje,
                                        ordenados[i].ganados,
                                        ordenados[i].empatados,
                                        ordenados[i].perdidos,
                                        diferencia);
            }
        }

        private Jugador[] CopiarJugadores()
        {
            Jugador[] copia = new Jugador[DatosGlobales.ContarJugadoresTorneoActual()];
            int i;
            int contador = 0;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            for (i = 0; i < DatosGlobales.totalJugadores; i++)
            {
                if (DatosGlobales.jugadores[i].idTorneo == idTorneo)
                {
                    copia[contador] = DatosGlobales.jugadores[i];
                    contador++;
                }
            }

            return copia;
        }

        private void OrdenarJugadores(Jugador[] vector)
        {
            int i;
            int j;
            Jugador aux;

            for (i = 0; i < vector.Length - 1; i++)
            {
                for (j = i + 1; j < vector.Length; j++)
                {
                    if (DebeCambiar(vector[i], vector[j]))
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }

        private bool DebeCambiar(Jugador actual, Jugador siguiente)
        {
            int diferenciaActual = actual.puntosAFavor - actual.puntosEnContra;
            int diferenciaSiguiente = siguiente.puntosAFavor - siguiente.puntosEnContra;

            if (siguiente.puntaje > actual.puntaje)
            {
                return true;
            }

            if (siguiente.puntaje == actual.puntaje && siguiente.ganados > actual.ganados)
            {
                return true;
            }

            if (siguiente.puntaje == actual.puntaje &&
                siguiente.ganados == actual.ganados &&
                diferenciaSiguiente > diferenciaActual)
            {
                return true;
            }

            return false;
        }

    }
}

