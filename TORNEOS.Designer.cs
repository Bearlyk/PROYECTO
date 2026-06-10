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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.DgvTorneos = new System.Windows.Forms.DataGridView();
            this.ColTorneoMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTorneoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTorneoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTorneoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTorneoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTorneoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTorneos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(45, 20);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(300, 37);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "TORNEOS";
            // 
            // LblNombre
            // 
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(45, 77);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(150, 24);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "NOMBRE";
            // 
            // LblTipo
            // 
            this.LblTipo.BackColor = System.Drawing.Color.Transparent;
            this.LblTipo.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.Color.White;
            this.LblTipo.Location = new System.Drawing.Point(292, 77);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(150, 24);
            this.LblTipo.TabIndex = 2;
            this.LblTipo.Text = "TIPO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("OCR A Extended", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(45, 106);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(211, 23);
            this.TxtNombre.TabIndex = 3;
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "LIGA",
            "TODOS_CONTRA_TODOS",
            "ELIMINACION"});
            this.CmbTipo.Location = new System.Drawing.Point(292, 106);
            this.CmbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(188, 21);
            this.CmbTipo.TabIndex = 4;
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.White;
            this.BtnCrear.Location = new System.Drawing.Point(518, 102);
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(112, 32);
            this.BtnCrear.TabIndex = 5;
            this.BtnCrear.Text = "CREAR";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.Location = new System.Drawing.Point(83, 386);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(112, 32);
            this.BtnSeleccionar.TabIndex = 6;
            this.BtnSeleccionar.Text = "SELECCIONAR";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(570, 386);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(112, 32);
            this.BtnVolver.TabIndex = 7;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // DgvTorneos
            // 
            this.DgvTorneos.AllowUserToAddRows = false;
            this.DgvTorneos.AllowUserToDeleteRows = false;
            this.DgvTorneos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTorneos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DgvTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTorneos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTorneoMarca,
            this.ColTorneoId,
            this.ColTorneoNombre,
            this.ColTorneoTipo,
            this.ColTorneoFecha,
            this.ColTorneoEstado});
            this.DgvTorneos.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvTorneos.Location = new System.Drawing.Point(45, 154);
            this.DgvTorneos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvTorneos.MultiSelect = false;
            this.DgvTorneos.Name = "DgvTorneos";
            this.DgvTorneos.ReadOnly = true;
            this.DgvTorneos.RowHeadersVisible = false;
            this.DgvTorneos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTorneos.Size = new System.Drawing.Size(622, 214);
            this.DgvTorneos.TabIndex = 8;
            // 
            // ColTorneoMarca
            // 
            this.ColTorneoMarca.HeaderText = "";
            this.ColTorneoMarca.Name = "ColTorneoMarca";
            this.ColTorneoMarca.ReadOnly = true;
            // 
            // ColTorneoId
            // 
            this.ColTorneoId.HeaderText = "ID";
            this.ColTorneoId.Name = "ColTorneoId";
            this.ColTorneoId.ReadOnly = true;
            // 
            // ColTorneoNombre
            // 
            this.ColTorneoNombre.HeaderText = "Nombre";
            this.ColTorneoNombre.Name = "ColTorneoNombre";
            this.ColTorneoNombre.ReadOnly = true;
            // 
            // ColTorneoTipo
            // 
            this.ColTorneoTipo.HeaderText = "Tipo";
            this.ColTorneoTipo.Name = "ColTorneoTipo";
            this.ColTorneoTipo.ReadOnly = true;
            // 
            // ColTorneoFecha
            // 
            this.ColTorneoFecha.HeaderText = "Fecha";
            this.ColTorneoFecha.Name = "ColTorneoFecha";
            this.ColTorneoFecha.ReadOnly = true;
            // 
            // ColTorneoEstado
            // 
            this.ColTorneoEstado.HeaderText = "Estado";
            this.ColTorneoEstado.Name = "ColTorneoEstado";
            this.ColTorneoEstado.ReadOnly = true;
            // 
            // TORNEOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(732, 444);
            this.Controls.Add(this.DgvTorneos);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TORNEOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TORNEOS";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTorneos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

