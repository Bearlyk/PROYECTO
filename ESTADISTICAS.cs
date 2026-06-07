using System;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class ESTADISTICAS : Form
    {
        public ESTADISTICAS()
        {
            InitializeComponent();
            MostrarEstadisticas();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            MostrarEstadisticas();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Hide();
        }

        private void MostrarEstadisticas()
        {
            Jugador[] jugadoresTorneo = CopiarJugadoresTorneo();
            int i;

            DgvEstadisticas.Rows.Clear();
            DgvMatriz.Rows.Clear();
            DgvMatriz.Columns.Clear();

            DgvEstadisticas.Rows.Add("Torneo", DatosGlobales.ObtenerNombreTorneoActual());
            DgvEstadisticas.Rows.Add("Jugadores", jugadoresTorneo.Length);
            DgvEstadisticas.Rows.Add("Partidas", ContarPartidasTorneo());
            DgvEstadisticas.Rows.Add("Media puntos", CalcularMedia(jugadoresTorneo).ToString("0.00"));
            DgvEstadisticas.Rows.Add("Mediana puntos", CalcularMediana(jugadoresTorneo).ToString("0.00"));
            DgvEstadisticas.Rows.Add("Moda puntos", CalcularModa(jugadoresTorneo));
            DgvEstadisticas.Rows.Add("Mas victorias", BuscarMayorGanador(jugadoresTorneo));
            DgvEstadisticas.Rows.Add("Mas derrotas", BuscarMayorPerdedor(jugadoresTorneo));

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                DgvEstadisticas.Rows.Add(jugadoresTorneo[i].nombre + " victorias",
                    CalcularPorcentaje(jugadoresTorneo[i].ganados, jugadoresTorneo[i].partidasJugadas).ToString("0.00") + "%");
                DgvEstadisticas.Rows.Add(jugadoresTorneo[i].nombre + " empates",
                    CalcularPorcentaje(jugadoresTorneo[i].empatados, jugadoresTorneo[i].partidasJugadas).ToString("0.00") + "%");
                DgvEstadisticas.Rows.Add(jugadoresTorneo[i].nombre + " derrotas",
                    CalcularPorcentaje(jugadoresTorneo[i].perdidos, jugadoresTorneo[i].partidasJugadas).ToString("0.00") + "%");
            }

            MostrarMatrizResultados(jugadoresTorneo);
        }

        private Jugador[] CopiarJugadoresTorneo()
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

        private int ContarPartidasTorneo()
        {
            int i;
            int contador = 0;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            for (i = 0; i < DatosGlobales.totalPartidas; i++)
            {
                if (DatosGlobales.partidas[i].idTorneo == idTorneo)
                {
                    contador++;
                }
            }

            return contador;
        }

        private double CalcularMedia(Jugador[] jugadoresTorneo)
        {
            int suma = 0;
            int i;

            if (jugadoresTorneo.Length == 0)
            {
                return 0;
            }

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                suma += jugadoresTorneo[i].puntaje;
            }

            return (double)suma / jugadoresTorneo.Length;
        }

        private double CalcularMediana(Jugador[] jugadoresTorneo)
        {
            int[] puntos = CopiarPuntajes(jugadoresTorneo);
            int mitad;

            if (puntos.Length == 0)
            {
                return 0;
            }

            OrdenarNumeros(puntos);
            mitad = puntos.Length / 2;

            if (puntos.Length % 2 == 0)
            {
                return (double)(puntos[mitad - 1] + puntos[mitad]) / 2;
            }

            return puntos[mitad];
        }

        private int CalcularModa(Jugador[] jugadoresTorneo)
        {
            int[] puntos = CopiarPuntajes(jugadoresTorneo);
            int i;
            int j;
            int contador;
            int mayorContador = 0;
            int moda = 0;

            for (i = 0; i < puntos.Length; i++)
            {
                contador = 0;

                for (j = 0; j < puntos.Length; j++)
                {
                    if (puntos[i] == puntos[j])
                    {
                        contador++;
                    }
                }

                if (contador > mayorContador)
                {
                    mayorContador = contador;
                    moda = puntos[i];
                }
            }

            return moda;
        }

        private int[] CopiarPuntajes(Jugador[] jugadoresTorneo)
        {
            int[] puntos = new int[jugadoresTorneo.Length];
            int i;

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                puntos[i] = jugadoresTorneo[i].puntaje;
            }

            return puntos;
        }

        private void OrdenarNumeros(int[] vector)
        {
            int i;
            int j;
            int aux;

            for (i = 0; i < vector.Length - 1; i++)
            {
                for (j = i + 1; j < vector.Length; j++)
                {
                    if (vector[j] < vector[i])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }

        private string BuscarMayorGanador(Jugador[] jugadoresTorneo)
        {
            int i;
            int pos = -1;
            int mayor = -1;

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                if (jugadoresTorneo[i].ganados > mayor)
                {
                    mayor = jugadoresTorneo[i].ganados;
                    pos = i;
                }
            }

            if (pos == -1)
            {
                return "Sin datos";
            }

            return jugadoresTorneo[pos].nombre + " (" + mayor + ")";
        }

        private string BuscarMayorPerdedor(Jugador[] jugadoresTorneo)
        {
            int i;
            int pos = -1;
            int mayor = -1;

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                if (jugadoresTorneo[i].perdidos > mayor)
                {
                    mayor = jugadoresTorneo[i].perdidos;
                    pos = i;
                }
            }

            if (pos == -1)
            {
                return "Sin datos";
            }

            return jugadoresTorneo[pos].nombre + " (" + mayor + ")";
        }

        private double CalcularPorcentaje(int valor, int total)
        {
            if (total == 0)
            {
                return 0;
            }

            return (double)valor * 100 / total;
        }

        private void MostrarMatrizResultados(Jugador[] jugadoresTorneo)
        {
            int i;
            int j;
            int[,] matriz = CrearMatrizPuntajes(jugadoresTorneo);
            DgvMatriz.Columns.Add("Jugador", "Jugador");

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                DgvMatriz.Columns.Add(jugadoresTorneo[i].id, jugadoresTorneo[i].id);
            }

            DgvMatriz.Columns.Add("Suma", "Suma fila");

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                object[] fila = new object[jugadoresTorneo.Length + 2];
                fila[0] = jugadoresTorneo[i].id;

                for (j = 0; j < jugadoresTorneo.Length; j++)
                {
                    if (i == j)
                    {
                        fila[j + 1] = "-";
                    }
                    else
                    {
                        fila[j + 1] = matriz[i, j].ToString("D2");
                    }
                }

                fila[jugadoresTorneo.Length + 1] = SumarFila(matriz, i, jugadoresTorneo.Length);
                DgvMatriz.Rows.Add(fila);
            }
        }

        private int[,] CrearMatrizPuntajes(Jugador[] jugadoresTorneo)
        {
            int[,] matriz = new int[jugadoresTorneo.Length, jugadoresTorneo.Length];
            int i;
            int pos1;
            int pos2;
            string idTorneo = DatosGlobales.ObtenerIdTorneoActual();

            for (i = 0; i < DatosGlobales.totalPartidas; i++)
            {
                if (DatosGlobales.partidas[i].idTorneo == idTorneo)
                {
                    pos1 = BuscarJugadorEnVector(jugadoresTorneo, DatosGlobales.partidas[i].idJugador1);
                    pos2 = BuscarJugadorEnVector(jugadoresTorneo, DatosGlobales.partidas[i].idJugador2);

                    if (pos1 >= 0 && pos2 >= 0)
                    {
                        matriz[pos1, pos2] += DatosGlobales.partidas[i].puntajeJugador1;
                        matriz[pos2, pos1] += DatosGlobales.partidas[i].puntajeJugador2;
                    }
                }
            }

            return matriz;
        }

        private int BuscarJugadorEnVector(Jugador[] jugadoresTorneo, string idJugador)
        {
            int i;

            for (i = 0; i < jugadoresTorneo.Length; i++)
            {
                if (jugadoresTorneo[i].id == idJugador)
                {
                    return i;
                }
            }

            return -1;
        }

        private int SumarFila(int[,] matriz, int fila, int total)
        {
            int suma = 0;
            int j;

            for (j = 0; j < total; j++)
            {
                suma += matriz[fila, j];
            }

            return suma;
        }
    }
}

