namespace MENU_DE_TORNEOS_1._0
{
    partial class TORNEOS
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

        private void InitializeComponent()
        {
            LblTitulo = new System.Windows.Forms.Label();
            LblNombre = new System.Windows.Forms.Label();
            LblTipo = new System.Windows.Forms.Label();
            TxtNombre = new System.Windows.Forms.TextBox();
            CmbTipo = new System.Windows.Forms.ComboBox();
            BtnCrear = new System.Windows.Forms.Button();
            BtnSeleccionar = new System.Windows.Forms.Button();
            BtnVolver = new System.Windows.Forms.Button();
            DgvTorneos = new System.Windows.Forms.DataGridView();
            ColTorneoMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColTorneoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColTorneoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColTorneoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColTorneoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColTorneoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SuspendLayout();
            LblTitulo.BackColor = System.Drawing.Color.Transparent;
            LblTitulo.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblTitulo.ForeColor = System.Drawing.Color.White;
            LblTitulo.Location = new System.Drawing.Point(60, 25);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new System.Drawing.Size(400, 45);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "TORNEOS";
            LblNombre.BackColor = System.Drawing.Color.Transparent;
            LblNombre.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblNombre.ForeColor = System.Drawing.Color.White;
            LblNombre.Location = new System.Drawing.Point(60, 95);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new System.Drawing.Size(200, 30);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "NOMBRE";
            LblTipo.BackColor = System.Drawing.Color.Transparent;
            LblTipo.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblTipo.ForeColor = System.Drawing.Color.White;
            LblTipo.Location = new System.Drawing.Point(390, 95);
            LblTipo.Name = "LblTipo";
            LblTipo.Size = new System.Drawing.Size(200, 30);
            LblTipo.TabIndex = 2;
            LblTipo.Text = "TIPO";
            TxtNombre.Font = new System.Drawing.Font("OCR A Extended", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TxtNombre.Location = new System.Drawing.Point(60, 130);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new System.Drawing.Size(280, 29);
            TxtNombre.TabIndex = 3;
            CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbTipo.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CmbTipo.FormattingEnabled = true;
            CmbTipo.Items.AddRange(new object[] {
            "LIGA",
            "TODOS_CONTRA_TODOS",
            "ELIMINACION"});
            CmbTipo.Location = new System.Drawing.Point(390, 130);
            CmbTipo.Name = "CmbTipo";
            CmbTipo.Size = new System.Drawing.Size(250, 28);
            CmbTipo.TabIndex = 4;
            BtnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCrear.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnCrear.ForeColor = System.Drawing.Color.White;
            BtnCrear.Location = new System.Drawing.Point(690, 126);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new System.Drawing.Size(150, 40);
            BtnCrear.TabIndex = 5;
            BtnCrear.Text = "CREAR";
            BtnCrear.UseVisualStyleBackColor = false;
            BtnCrear.Click += new System.EventHandler(BtnCrear_Click);
            BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSeleccionar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            BtnSeleccionar.Location = new System.Drawing.Point(60, 475);
            BtnSeleccionar.Name = "BtnSeleccionar";
            BtnSeleccionar.Size = new System.Drawing.Size(150, 40);
            BtnSeleccionar.TabIndex = 6;
            BtnSeleccionar.Text = "SELECCIONAR";
            BtnSeleccionar.UseVisualStyleBackColor = false;
            BtnSeleccionar.Click += new System.EventHandler(BtnSeleccionar_Click);
            BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnVolver.ForeColor = System.Drawing.Color.White;
            BtnVolver.Location = new System.Drawing.Point(760, 475);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new System.Drawing.Size(150, 40);
            BtnVolver.TabIndex = 7;
            BtnVolver.Text = "VOLVER";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += new System.EventHandler(BtnVolver_Click);
            DgvTorneos.AllowUserToAddRows = false;
            DgvTorneos.AllowUserToDeleteRows = false;
            DgvTorneos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DgvTorneos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            DgvTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTorneos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColTorneoMarca,
            ColTorneoId,
            ColTorneoNombre,
            ColTorneoTipo,
            ColTorneoFecha,
            ColTorneoEstado});
            DgvTorneos.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DgvTorneos.ForeColor = System.Drawing.Color.Black;
            DgvTorneos.Location = new System.Drawing.Point(60, 190);
            DgvTorneos.MultiSelect = false;
            DgvTorneos.Name = "DgvTorneos";
            DgvTorneos.ReadOnly = true;
            DgvTorneos.RowHeadersVisible = false;
            DgvTorneos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvTorneos.Size = new System.Drawing.Size(830, 264);
            DgvTorneos.TabIndex = 8;
            ColTorneoMarca.HeaderText = "";
            ColTorneoMarca.Name = "ColTorneoMarca";
            ColTorneoMarca.ReadOnly = true;
            ColTorneoId.HeaderText = "ID";
            ColTorneoId.Name = "ColTorneoId";
            ColTorneoId.ReadOnly = true;
            ColTorneoNombre.HeaderText = "Nombre";
            ColTorneoNombre.Name = "ColTorneoNombre";
            ColTorneoNombre.ReadOnly = true;
            ColTorneoTipo.HeaderText = "Tipo";
            ColTorneoTipo.Name = "ColTorneoTipo";
            ColTorneoTipo.ReadOnly = true;
            ColTorneoFecha.HeaderText = "Fecha";
            ColTorneoFecha.Name = "ColTorneoFecha";
            ColTorneoFecha.ReadOnly = true;
            ColTorneoEstado.HeaderText = "Estado";
            ColTorneoEstado.Name = "ColTorneoEstado";
            ColTorneoEstado.ReadOnly = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(DgvTorneos);
            Controls.Add(BtnVolver);
            Controls.Add(BtnSeleccionar);
            Controls.Add(BtnCrear);
            Controls.Add(CmbTipo);
            Controls.Add(TxtNombre);
            Controls.Add(LblTipo);
            Controls.Add(LblNombre);
            Controls.Add(LblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "TORNEOS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TORNEOS";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridView DgvTorneos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTorneoMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTorneoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTorneoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTorneoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTorneoFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTorneoEstado;
    }
}

