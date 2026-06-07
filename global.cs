using System;
using System.IO;

namespace MENU_DE_TORNEOS_1._0
{
    public struct Torneo
    {
        public string id;
        public string nombre;
        public string tipo;
        public string fechaInicio;
        public string estado;
    }

    public struct Jugador
    {
        public string idTorneo;
        public string id;
        public string nombre;
        public string apodo;
        public int puntaje;
        public int ganados;
        public int empatados;
        public int perdidos;
        public int partidasJugadas;
        public int puntosAFavor;
        public int puntosEnContra;
    }

    public struct Partida
    {
        public string idTorneo;
        public string id;
        public string idJugador1;
        public string idJugador2;
        public string nombreJugador1;
        public string nombreJugador2;
        public int puntajeJugador1;
        public int puntajeJugador2;
        public string ganador;
        public string fecha;
        public string estado;
        public string tipoTorneo;
    }

    public struct DatosGlobales
    {
        public static Torneo[] torneos = new Torneo[0];
        public static Jugador[] jugadores = new Jugador[0];
        public static Partida[] partidas = new Partida[0];
        public static int totalTorneos = 0;
        public static int totalJugadores = 0;
        public static int totalPartidas = 0;
        public static int torneoSeleccionado = -1;

        public static string archivoTorneos = "datosTorneos.txt";
        public static string archivoJugadores = "datosJugador.txt";
        public static string archivoPartidas = "datosPartidas.txt";

        public static void AgregarTorneo(Torneo torneo)
        {
            Torneo[] nuevoVector = new Torneo[totalTorneos + 1];
            int i;

            for (i = 0; i < totalTorneos; i++)
            {
                nuevoVector[i] = torneos[i];
            }

            nuevoVector[totalTorneos] = torneo;
            torneos = nuevoVector;
            totalTorneos++;
        }

        public static void AgregarJugador(Jugador jugador)
        {
            Jugador[] nuevoVector = new Jugador[totalJugadores + 1];
            int i;

            for (i = 0; i < totalJugadores; i++)
            {
                nuevoVector[i] = jugadores[i];
            }

            nuevoVector[totalJugadores] = jugador;
            jugadores = nuevoVector;
            totalJugadores++;
        }

        public static void AgregarPartida(Partida partida)
        {
            Partida[] nuevoVector = new Partida[totalPartidas + 1];
            int i;

            for (i = 0; i < totalPartidas; i++)
            {
                nuevoVector[i] = partidas[i];
            }

            nuevoVector[totalPartidas] = partida;
            partidas = nuevoVector;
            totalPartidas++;
        }

        public static string ObtenerIdTorneoActual()
        {
            if (torneoSeleccionado < 0 || torneoSeleccionado >= totalTorneos)
            {
                return "";
            }

            return torneos[torneoSeleccionado].id;
        }

        public static string ObtenerTipoTorneoActual()
        {
            if (torneoSeleccionado < 0 || torneoSeleccionado >= totalTorneos)
            {
                return "";
            }

            return torneos[torneoSeleccionado].tipo;
        }

        public static string ObtenerNombreTorneoActual()
        {
            if (torneoSeleccionado < 0 || torneoSeleccionado >= totalTorneos)
            {
                return "SIN TORNEO";
            }

            return torneos[torneoSeleccionado].nombre;
        }

        public static string GenerarIdTorneo()
        {
            int numero = 1;
            string id = "TOR-" + numero.ToString("D2");

            while (BuscarTorneoPorId(id) != -1)
            {
                numero++;
                id = "TOR-" + numero.ToString("D2");
            }

            return id;
        }

        public static string GenerarIdJugador()
        {
            int numero = 1;
            string id = "JUG-" + numero.ToString("D2");
            string idTorneo = ObtenerIdTorneoActual();

            while (BuscarJugadorPorIdEnTorneo(id, idTorneo) != -1)
            {
                numero++;
                id = "JUG-" + numero.ToString("D2");
            }

            return id;
        }

        public static string GenerarIdPartida()
        {
            int numero = 1;
            string id = "PAR-" + numero.ToString("D2");
            string idTorneo = ObtenerIdTorneoActual();

            while (BuscarPartidaPorIdEnTorneo(id, idTorneo) != -1)
            {
                numero++;
                id = "PAR-" + numero.ToString("D2");
            }

            return id;
        }

        public static int BuscarTorneoPorId(string id)
        {
            int i;

            for (i = 0; i < totalTorneos; i++)
            {
                if (torneos[i].id == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BuscarJugadorPorId(string id)
        {
            return BuscarJugadorPorIdEnTorneo(id, ObtenerIdTorneoActual());
        }

        public static int BuscarJugadorPorIdEnTorneo(string id, string idTorneo)
        {
            int i;

            for (i = 0; i < totalJugadores; i++)
            {
                if (jugadores[i].id == id && jugadores[i].idTorneo == idTorneo)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BuscarPartidaPorIdEnTorneo(string id, string idTorneo)
        {
            int i;

            for (i = 0; i < totalPartidas; i++)
            {
                if (partidas[i].id == id && partidas[i].idTorneo == idTorneo)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BuscarJugadorPorTexto(string texto)
        {
            int i;
            string buscar = texto.ToUpper();
            string idTorneo = ObtenerIdTorneoActual();

            for (i = 0; i < totalJugadores; i++)
            {
                if (jugadores[i].idTorneo == idTorneo &&
                    (jugadores[i].id.ToUpper() == buscar ||
                    jugadores[i].nombre.ToUpper() == buscar ||
                    jugadores[i].apodo.ToUpper() == buscar))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int ContarJugadoresTorneoActual()
        {
            int i;
            int contador = 0;
            string idTorneo = ObtenerIdTorneoActual();

            for (i = 0; i < totalJugadores; i++)
            {
                if (jugadores[i].idTorneo == idTorneo)
                {
                    contador++;
                }
            }

            return contador;
        }

        public static int ObtenerJugadorPorNumeroEnTorneo(int numero)
        {
            int i;
            int contador = 0;
            string idTorneo = ObtenerIdTorneoActual();

            for (i = 0; i < totalJugadores; i++)
            {
                if (jugadores[i].idTorneo == idTorneo)
                {
                    if (contador == numero)
                    {
                        return i;
                    }

                    contador++;
                }
            }

            return -1;
        }

        public static void EliminarJugador(int posicion)
        {
            Jugador[] nuevoVector = new Jugador[totalJugadores - 1];
            int i;
            int j = 0;

            for (i = 0; i < totalJugadores; i++)
            {
                if (i != posicion)
                {
                    nuevoVector[j] = jugadores[i];
                    j++;
                }
            }

            jugadores = nuevoVector;
            totalJugadores--;
        }

        public static void GuardarTorneos()
        {
            StreamWriter archivo = new StreamWriter(archivoTorneos, false);
            int i;

            for (i = 0; i < totalTorneos; i++)
            {
                archivo.WriteLine(torneos[i].id + "|" +
                                  torneos[i].nombre + "|" +
                                  torneos[i].tipo + "|" +
                                  torneos[i].fechaInicio + "|" +
                                  torneos[i].estado);
            }

            archivo.Close();
        }

        public static void CargarTorneos()
        {
            torneos = new Torneo[0];
            totalTorneos = 0;
            torneoSeleccionado = -1;

            if (File.Exists(archivoTorneos) == false)
            {
                return;
            }

            string[] lineas = File.ReadAllLines(archivoTorneos);
            int i;

            for (i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split('|');

                if (partes.Length >= 5)
                {
                    Torneo torneo;
                    torneo.id = partes[0];
                    torneo.nombre = partes[1];
                    torneo.tipo = partes[2];
                    torneo.fechaInicio = partes[3];
                    torneo.estado = partes[4];
                    AgregarTorneo(torneo);
                }
            }
        }

        public static void GuardarJugadores()
        {
            StreamWriter archivo = new StreamWriter(archivoJugadores, false);
            int i;

            for (i = 0; i < totalJugadores; i++)
            {
                archivo.WriteLine(jugadores[i].idTorneo + "|" +
                                  jugadores[i].id + "|" +
                                  jugadores[i].nombre + "|" +
                                  jugadores[i].apodo + "|" +
                                  jugadores[i].puntaje + "|" +
                                  jugadores[i].ganados + "|" +
                                  jugadores[i].empatados + "|" +
                                  jugadores[i].perdidos + "|" +
                                  jugadores[i].partidasJugadas + "|" +
                                  jugadores[i].puntosAFavor + "|" +
                                  jugadores[i].puntosEnContra);
            }

            archivo.Close();
        }

        public static void CargarJugadores()
        {
            jugadores = new Jugador[0];
            totalJugadores = 0;

            if (File.Exists(archivoJugadores) == false)
            {
                return;
            }

            string[] lineas = File.ReadAllLines(archivoJugadores);
            int i;

            for (i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split('|');

                if (partes.Length >= 11)
                {
                    Jugador jugador;
                    jugador.idTorneo = partes[0];
                    jugador.id = partes[1];
                    jugador.nombre = partes[2];
                    jugador.apodo = partes[3];
                    jugador.puntaje = Convert.ToInt32(partes[4]);
                    jugador.ganados = Convert.ToInt32(partes[5]);
                    jugador.empatados = Convert.ToInt32(partes[6]);
                    jugador.perdidos = Convert.ToInt32(partes[7]);
                    jugador.partidasJugadas = Convert.ToInt32(partes[8]);
                    jugador.puntosAFavor = Convert.ToInt32(partes[9]);
                    jugador.puntosEnContra = Convert.ToInt32(partes[10]);
                    AgregarJugador(jugador);
                }
                else
                {
                    if (partes.Length >= 10)
                    {
                        Jugador jugadorAnterior;
                        jugadorAnterior.idTorneo = "";
                        jugadorAnterior.id = partes[0];
                        jugadorAnterior.nombre = partes[1];
                        jugadorAnterior.apodo = partes[2];
                        jugadorAnterior.puntaje = Convert.ToInt32(partes[3]);
                        jugadorAnterior.ganados = Convert.ToInt32(partes[4]);
                        jugadorAnterior.empatados = Convert.ToInt32(partes[5]);
                        jugadorAnterior.perdidos = Convert.ToInt32(partes[6]);
                        jugadorAnterior.partidasJugadas = Convert.ToInt32(partes[7]);
                        jugadorAnterior.puntosAFavor = Convert.ToInt32(partes[8]);
                        jugadorAnterior.puntosEnContra = Convert.ToInt32(partes[9]);
                        AgregarJugador(jugadorAnterior);
                    }
                }
            }
        }

        public static void GuardarPartidas()
        {
            StreamWriter archivo = new StreamWriter(archivoPartidas, false);
            int i;

            for (i = 0; i < totalPartidas; i++)
            {
                archivo.WriteLine(partidas[i].idTorneo + "|" +
                                  partidas[i].id + "|" +
                                  partidas[i].idJugador1 + "|" +
                                  partidas[i].idJugador2 + "|" +
                                  partidas[i].nombreJugador1 + "|" +
                                  partidas[i].nombreJugador2 + "|" +
                                  partidas[i].puntajeJugador1 + "|" +
                                  partidas[i].puntajeJugador2 + "|" +
                                  partidas[i].ganador + "|" +
                                  partidas[i].fecha + "|" +
                                  partidas[i].estado + "|" +
                                  partidas[i].tipoTorneo);
            }

            archivo.Close();
        }

        public static void CargarPartidas()
        {
            partidas = new Partida[0];
            totalPartidas = 0;

            if (File.Exists(archivoPartidas) == false)
            {
                return;
            }

            string[] lineas = File.ReadAllLines(archivoPartidas);
            int i;

            for (i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split('|');

                if (partes.Length >= 12)
                {
                    Partida partida;
                    partida.idTorneo = partes[0];
                    partida.id = partes[1];
                    partida.idJugador1 = partes[2];
                    partida.idJugador2 = partes[3];
                    partida.nombreJugador1 = partes[4];
                    partida.nombreJugador2 = partes[5];
                    partida.puntajeJugador1 = Convert.ToInt32(partes[6]);
                    partida.puntajeJugador2 = Convert.ToInt32(partes[7]);
                    partida.ganador = partes[8];
                    partida.fecha = partes[9];
                    partida.estado = partes[10];
                    partida.tipoTorneo = partes[11];
                    AgregarPartida(partida);
                }
                else
                {
                    if (partes.Length >= 11)
                    {
                        Partida partidaAnterior;
                        partidaAnterior.idTorneo = "";
                        partidaAnterior.id = partes[0];
                        partidaAnterior.idJugador1 = partes[1];
                        partidaAnterior.idJugador2 = partes[2];
                        partidaAnterior.nombreJugador1 = partes[3];
                        partidaAnterior.nombreJugador2 = partes[4];
                        partidaAnterior.puntajeJugador1 = Convert.ToInt32(partes[5]);
                        partidaAnterior.puntajeJugador2 = Convert.ToInt32(partes[6]);
                        partidaAnterior.ganador = partes[7];
                        partidaAnterior.fecha = partes[8];
                        partidaAnterior.estado = partes[9];
                        partidaAnterior.tipoTorneo = partes[10];
                        AgregarPartida(partidaAnterior);
                    }
                }
            }
        }

        public static void CargarDatos()
        {
            CargarTorneos();
            CargarJugadores();
            CargarPartidas();
        }

        public static void GuardarDatos()
        {
            GuardarTorneos();
            GuardarJugadores();
            GuardarPartidas();
        }
    }
}

