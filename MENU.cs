using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
            PrepararBotonTorneos();
            MostrarTorneoActual();
        }

        private void PrepararBotonTorneos()
        {
            Bt_Torneos.Text = "";
            Bt_Torneos.BackgroundImage = CrearImagenBotonTorneos();
            Bt_Torneos.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private Bitmap CrearImagenBotonTorneos()
        {
            Bitmap imagen = new Bitmap(1584, 396);
            Graphics grafico = Graphics.FromImage(imagen);
            Rectangle area = new Rectangle(0, 0, imagen.Width, imagen.Height);
            LinearGradientBrush fondo = new LinearGradientBrush(
                area,
                Color.FromArgb(8, 20, 55),
                Color.FromArgb(255, 185, 188),
                LinearGradientMode.Horizontal);
            Font fuente = new Font("OCR A Extended", 155, FontStyle.Bold);
            SolidBrush letra = new SolidBrush(Color.White);

            grafico.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            grafico.SmoothingMode = SmoothingMode.None;
            grafico.FillRectangle(fondo, area);
            grafico.DrawString("TORNEOS", fuente, letra, 28, 72);

            letra.Dispose();
            fuente.Dispose();
            fondo.Dispose();
            grafico.Dispose();

            return imagen;
        }

        private void MostrarTorneoActual()
        {
            LblTorneoActual.Text = "TORNEO ACTUAL: " + DatosGlobales.ObtenerNombreTorneoActual();
        }

        private bool ValidarTorneoSeleccionado()
        {
            if (DatosGlobales.torneoSeleccionado < 0)
            {
                MessageBox.Show("Primero debe crear o seleccionar un torneo.");
                return false;
            }

            return true;
        }

        private void Bt_Torneos_Click(object sender, EventArgs e)
        {
            TORNEOS torneos = new TORNEOS();
            torneos.Show();
            Hide();
        }

        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt_Jugadores_Click(object sender, EventArgs e)
        {
            if (ValidarTorneoSeleccionado() == false)
            {
                return;
            }

            JUGADORES jugadores = new JUGADORES();
            jugadores.Show();
            Hide();
        }

        private void Bt_Partidas_Click(object sender, EventArgs e)
        {
            if (ValidarTorneoSeleccionado() == false)
            {
                return;
            }

            PARTIDAS partidas = new PARTIDAS();
            partidas.Show();
            Hide();
        }

        private void Bt_Clasificacion_Click(object sender, EventArgs e)
        {
            if (ValidarTorneoSeleccionado() == false)
            {
                return;
            }

            POSICIONES posiciones = new POSICIONES();
            posiciones.Show();
            Hide();
        }

        private void Bt_Estadistica_Click(object sender, EventArgs e)
        {
            if (ValidarTorneoSeleccionado() == false)
            {
                return;
            }

            ESTADISTICAS estadisticas = new ESTADISTICAS();
            estadisticas.Show();
            Hide();
        }

        private void Bt_Historial_Click(object sender, EventArgs e)
        {
            if (ValidarTorneoSeleccionado() == false)
            {
                return;
            }

            HISTORIAL historial = new HISTORIAL();
            historial.Show();
            Hide();
        }
    }
}

