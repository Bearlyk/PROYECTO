namespace MENU_DE_TORNEOS_1._0
{
    partial class MENU
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            Bt_Jugadores = new System.Windows.Forms.Button();
            Bt_Partidas = new System.Windows.Forms.Button();
            Bt_Clasificacion = new System.Windows.Forms.Button();
            Bt_Estadistica = new System.Windows.Forms.Button();
            Bt_Historial = new System.Windows.Forms.Button();
            Bt_Salir = new System.Windows.Forms.Button();
            Bt_Torneos = new System.Windows.Forms.Button();
            LblTorneoActual = new System.Windows.Forms.Label();
            SuspendLayout();
            Bt_Torneos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            Bt_Torneos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bt_Torneos.Font = new System.Drawing.Font("OCR A Extended", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Bt_Torneos.ForeColor = System.Drawing.Color.White;
            Bt_Torneos.Location = new System.Drawing.Point(44, 37);
            Bt_Torneos.Name = "Bt_Torneos";
            Bt_Torneos.Size = new System.Drawing.Size(220, 55);
            Bt_Torneos.TabIndex = 0;
            Bt_Torneos.Text = "TORNEOS";
            Bt_Torneos.UseVisualStyleBackColor = false;
            Bt_Torneos.Click += new System.EventHandler(Bt_Torneos_Click);
            Bt_Jugadores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            Bt_Jugadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Jugadores.BackgroundImage")));
            Bt_Jugadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bt_Jugadores.Font = new System.Drawing.Font("OCR A Extended", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Bt_Jugadores.ForeColor = System.Drawing.Color.Black;
            Bt_Jugadores.Location = new System.Drawing.Point(137, 110);
            Bt_Jugadores.Name = "Bt_Jugadores";
            Bt_Jugadores.Size = new System.Drawing.Size(220, 55);
            Bt_Jugadores.TabIndex = 1;
            Bt_Jugadores.UseVisualStyleBackColor = false;
            Bt_Jugadores.Click += new System.EventHandler(Bt_Jugadores_Click);
            Bt_Partidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Partidas.BackgroundImage")));
            Bt_Partidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bt_Partidas.Location = new System.Drawing.Point(233, 180);
            Bt_Partidas.Name = "Bt_Partidas";
            Bt_Partidas.Size = new System.Drawing.Size(220, 55);
            Bt_Partidas.TabIndex = 2;
            Bt_Partidas.UseVisualStyleBackColor = true;
            Bt_Partidas.Click += new System.EventHandler(Bt_Partidas_Click);
            Bt_Clasificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Clasificacion.BackgroundImage")));
            Bt_Clasificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bt_Clasificacion.Location = new System.Drawing.Point(337, 250);
            Bt_Clasificacion.Name = "Bt_Clasificacion";
            Bt_Clasificacion.Size = new System.Drawing.Size(220, 55);
            Bt_Clasificacion.TabIndex = 3;
            Bt_Clasificacion.UseVisualStyleBackColor = true;
            Bt_Clasificacion.Click += new System.EventHandler(Bt_Clasificacion_Click);
            Bt_Estadistica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Estadistica.BackgroundImage")));
            Bt_Estadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bt_Estadistica.Location = new System.Drawing.Point(448, 320);
            Bt_Estadistica.Name = "Bt_Estadistica";
            Bt_Estadistica.Size = new System.Drawing.Size(220, 55);
            Bt_Estadistica.TabIndex = 4;
            Bt_Estadistica.UseVisualStyleBackColor = true;
            Bt_Estadistica.Click += new System.EventHandler(Bt_Estadistica_Click);
            Bt_Historial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Historial.BackgroundImage")));
            Bt_Historial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bt_Historial.Location = new System.Drawing.Point(560, 390);
            Bt_Historial.Name = "Bt_Historial";
            Bt_Historial.Size = new System.Drawing.Size(220, 55);
            Bt_Historial.TabIndex = 5;
            Bt_Historial.UseVisualStyleBackColor = true;
            Bt_Historial.Click += new System.EventHandler(Bt_Historial_Click);
            Bt_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Salir.BackgroundImage")));
            Bt_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Bt_Salir.Location = new System.Drawing.Point(746, 470);
            Bt_Salir.Name = "Bt_Salir";
            Bt_Salir.Size = new System.Drawing.Size(220, 55);
            Bt_Salir.TabIndex = 6;
            Bt_Salir.UseVisualStyleBackColor = true;
            Bt_Salir.Click += new System.EventHandler(Bt_Salir_Click);
            LblTorneoActual.BackColor = System.Drawing.Color.Transparent;
            LblTorneoActual.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblTorneoActual.ForeColor = System.Drawing.Color.White;
            LblTorneoActual.Location = new System.Drawing.Point(300, 37);
            LblTorneoActual.Name = "LblTorneoActual";
            LblTorneoActual.Size = new System.Drawing.Size(600, 45);
            LblTorneoActual.TabIndex = 7;
            LblTorneoActual.Text = "TORNEO ACTUAL: SIN TORNEO";
            LblTorneoActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(LblTorneoActual);
            Controls.Add(Bt_Salir);
            Controls.Add(Bt_Historial);
            Controls.Add(Bt_Estadistica);
            Controls.Add(Bt_Clasificacion);
            Controls.Add(Bt_Partidas);
            Controls.Add(Bt_Jugadores);
            Controls.Add(Bt_Torneos);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MENU";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MENU";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_Jugadores;
        private System.Windows.Forms.Button Bt_Partidas;
        private System.Windows.Forms.Button Bt_Clasificacion;
        private System.Windows.Forms.Button Bt_Estadistica;
        private System.Windows.Forms.Button Bt_Historial;
        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.Button Bt_Torneos;
        private System.Windows.Forms.Label LblTorneoActual;
    }
}


