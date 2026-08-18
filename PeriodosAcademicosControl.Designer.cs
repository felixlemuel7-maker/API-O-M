namespace Periodoacademico26
{
    partial class PeriodosAcademicosControl
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

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            lblTituloModulo = new Label();
            lblSubtitulo = new Label();
            cardFormulario = new Panel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTipo = new Label();
            cmbTipoPeriodo = new ComboBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnNuevo = new RoundedButton();
            btnGuardar = new RoundedButton();
            btnEliminar = new RoundedButton();
            btnLimpiar = new RoundedButton();
            lblMensaje = new Label();
            cardGrid = new Panel();
            dgvPeriodos = new DataGridView();
            txtBuscar = new TextBox();
            lblListado = new Label();
            cardFormulario.SuspendLayout();
            cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeriodos).BeginInit();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.AutoSize = true;
            lblTituloModulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloModulo.ForeColor = Color.FromArgb(11, 37, 69);
            lblTituloModulo.Location = new Point(30, 20);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(569, 48);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Text = "Módulo de Períodos Académicos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(30, 55);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(638, 28);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestiona los ciclos lectivos en los que los estudiantes pueden inscribirse.";
            // 
            // cardFormulario
            // 
            cardFormulario.BackColor = Color.White;
            cardFormulario.Controls.Add(lblNombre);
            cardFormulario.Controls.Add(txtNombre);
            cardFormulario.Controls.Add(lblTipo);
            cardFormulario.Controls.Add(cmbTipoPeriodo);
            cardFormulario.Controls.Add(lblFechaInicio);
            cardFormulario.Controls.Add(dtpFechaInicio);
            cardFormulario.Controls.Add(lblFechaFin);
            cardFormulario.Controls.Add(dtpFechaFin);
            cardFormulario.Controls.Add(lblEstado);
            cardFormulario.Controls.Add(cmbEstado);
            cardFormulario.Controls.Add(btnNuevo);
            cardFormulario.Controls.Add(btnGuardar);
            cardFormulario.Controls.Add(btnEliminar);
            cardFormulario.Controls.Add(btnLimpiar);
            cardFormulario.Location = new Point(30, 90);
            cardFormulario.Name = "cardFormulario";
            cardFormulario.Size = new Size(1050, 150);
            cardFormulario.TabIndex = 2;
            cardFormulario.Paint += Card_Paint;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 8.5F);
            lblNombre.ForeColor = Color.DimGray;
            lblNombre.Location = new Point(20, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(165, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del período";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(20, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 34);
            txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 8.5F);
            lblTipo.ForeColor = Color.DimGray;
            lblTipo.Location = new Point(260, 18);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(131, 23);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de período";
            // 
            // cmbTipoPeriodo
            // 
            cmbTipoPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPeriodo.Font = new Font("Segoe UI", 10F);
            cmbTipoPeriodo.Items.AddRange(new object[] { "Semestre", "Cuatrimestre", "Trimestre" });
            cmbTipoPeriodo.Location = new Point(260, 38);
            cmbTipoPeriodo.Name = "cmbTipoPeriodo";
            cmbTipoPeriodo.Size = new Size(160, 36);
            cmbTipoPeriodo.TabIndex = 3;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 8.5F);
            lblFechaInicio.ForeColor = Color.DimGray;
            lblFechaInicio.Location = new Point(440, 18);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(123, 23);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(440, 38);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(150, 34);
            dtpFechaInicio.TabIndex = 5;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 8.5F);
            lblFechaFin.ForeColor = Color.DimGray;
            lblFechaFin.Location = new Point(610, 18);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(168, 23);
            lblFechaFin.TabIndex = 6;
            lblFechaFin.Text = "Fecha de finalización";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(610, 38);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(150, 34);
            dtpFechaFin.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 8.5F);
            lblEstado.ForeColor = Color.DimGray;
            lblEstado.Location = new Point(780, 18);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(61, 23);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 10F);
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(780, 38);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(130, 36);
            cmbEstado.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(19, 49, 92);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(20, 105);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.RadioBorde = 10;
            btnNuevo.Size = new Size(110, 38);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += BtnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(201, 162, 39);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(11, 37, 69);
            btnGuardar.Location = new Point(140, 105);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.RadioBorde = 10;
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 57, 43);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(260, 105);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.RadioBorde = 10;
            btnEliminar.Size = new Size(110, 38);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gainsboro;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(11, 37, 69);
            btnLimpiar.Location = new Point(380, 105);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.RadioBorde = 10;
            btnLimpiar.Size = new Size(110, 38);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblMensaje.ForeColor = Color.FromArgb(46, 139, 87);
            lblMensaje.Location = new Point(30, 250);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 25);
            lblMensaje.TabIndex = 3;
            // 
            // cardGrid
            // 
            cardGrid.BackColor = Color.White;
            cardGrid.Controls.Add(dgvPeriodos);
            cardGrid.Controls.Add(txtBuscar);
            cardGrid.Controls.Add(lblListado);
            cardGrid.Location = new Point(30, 280);
            cardGrid.Name = "cardGrid";
            cardGrid.Size = new Size(1050, 380);
            cardGrid.TabIndex = 4;
            cardGrid.Paint += Card_Paint;
            // 
            // dgvPeriodos
            // 
            dgvPeriodos.AllowUserToAddRows = false;
            dgvPeriodos.AllowUserToDeleteRows = false;
            dgvPeriodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeriodos.BackgroundColor = Color.White;
            dgvPeriodos.BorderStyle = BorderStyle.None;
            dgvPeriodos.ColumnHeadersHeight = 36;
            dgvPeriodos.EnableHeadersVisualStyles = false;
            dgvPeriodos.Font = new Font("Segoe UI", 9.5F);
            dgvPeriodos.Location = new Point(20, 50);
            dgvPeriodos.MultiSelect = false;
            dgvPeriodos.Name = "dgvPeriodos";
            dgvPeriodos.ReadOnly = true;
            dgvPeriodos.RowHeadersVisible = false;
            dgvPeriodos.RowHeadersWidth = 62;
            dgvPeriodos.RowTemplate.Height = 32;
            dgvPeriodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeriodos.Size = new Size(1010, 310);
            dgvPeriodos.TabIndex = 0;
            dgvPeriodos.CellClick += DgvPeriodos_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(830, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 33);
            txtBuscar.TabIndex = 1;
            txtBuscar.Text = "Buscar por nombre...";
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            txtBuscar.Enter += TxtBuscar_Enter;
            txtBuscar.Leave += TxtBuscar_Leave;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListado.ForeColor = Color.FromArgb(11, 37, 69);
            lblListado.Location = new Point(20, 15);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(250, 32);
            lblListado.TabIndex = 2;
            lblListado.Text = "Períodos registrados";
            // 
            // PeriodosAcademicosControl
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 246, 249);
            Controls.Add(cardGrid);
            Controls.Add(lblMensaje);
            Controls.Add(cardFormulario);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTituloModulo);
            Font = new Font("Segoe UI", 9.5F);
            Name = "PeriodosAcademicosControl";
            Padding = new Padding(30, 20, 30, 20);
            Size = new Size(2497, 1209);
            cardFormulario.ResumeLayout(false);
            cardFormulario.PerformLayout();
            cardGrid.ResumeLayout(false);
            cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeriodos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel cardFormulario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoPeriodo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private RoundedButton btnNuevo;
        private RoundedButton btnGuardar;
        private RoundedButton btnEliminar;
        private RoundedButton btnLimpiar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel cardGrid;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvPeriodos;
    }
}
