namespace Periodoacademico26
{
    partial class InscripcionesControl
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
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.cardPaso1 = new System.Windows.Forms.Panel();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.lblCarreraDeseada = new System.Windows.Forms.Label();
            this.cmbCarreraDeseada = new System.Windows.Forms.ComboBox();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.btnContinuar = new Periodoacademico26.RoundedButton();

            this.cardPaso2 = new System.Windows.Forms.Panel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblAsignaturasTitulo = new System.Windows.Forms.Label();
            this.clbAsignaturas = new System.Windows.Forms.CheckedListBox();
            this.btnAtras = new Periodoacademico26.RoundedButton();
            this.btnInscribir = new Periodoacademico26.RoundedButton();

            this.lblMensaje = new System.Windows.Forms.Label();

            this.cardGrid = new System.Windows.Forms.Panel();
            this.lblListado = new System.Windows.Forms.Label();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();

            this.cardPaso1.SuspendLayout();
            this.cardPaso2.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.SuspendLayout();
            //
            // lblTituloModulo
            //
            this.lblTituloModulo.AutoSize = true;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.lblTituloModulo.Location = new System.Drawing.Point(30, 20);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(300, 32);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Text = "Inscripciones";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(430, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Selecciona tu carrera y las asignaturas del primer cuatrimestre para inscribirte.";
            //
            // cardPaso1
            //
            this.cardPaso1.BackColor = System.Drawing.Color.White;
            this.cardPaso1.Controls.Add(this.lblEstudiante);
            this.cardPaso1.Controls.Add(this.cmbEstudiante);
            this.cardPaso1.Controls.Add(this.lblCarreraDeseada);
            this.cardPaso1.Controls.Add(this.cmbCarreraDeseada);
            this.cardPaso1.Controls.Add(this.lblFechaInscripcion);
            this.cardPaso1.Controls.Add(this.dtpFechaInscripcion);
            this.cardPaso1.Controls.Add(this.btnContinuar);
            this.cardPaso1.Location = new System.Drawing.Point(30, 90);
            this.cardPaso1.Name = "cardPaso1";
            this.cardPaso1.Size = new System.Drawing.Size(1050, 150);
            this.cardPaso1.TabIndex = 2;
            this.cardPaso1.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            //
            // lblEstudiante
            //
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEstudiante.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstudiante.Location = new System.Drawing.Point(20, 18);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(120, 15);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Estudiante (ya registrado)";
            //
            // cmbEstudiante
            //
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstudiante.Location = new System.Drawing.Point(20, 38);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(320, 25);
            this.cmbEstudiante.TabIndex = 1;
            //
            // lblCarreraDeseada
            //
            this.lblCarreraDeseada.AutoSize = true;
            this.lblCarreraDeseada.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCarreraDeseada.ForeColor = System.Drawing.Color.DimGray;
            this.lblCarreraDeseada.Location = new System.Drawing.Point(360, 18);
            this.lblCarreraDeseada.Name = "lblCarreraDeseada";
            this.lblCarreraDeseada.Size = new System.Drawing.Size(150, 15);
            this.lblCarreraDeseada.TabIndex = 2;
            this.lblCarreraDeseada.Text = "Carrera que deseas estudiar";
            //
            // cmbCarreraDeseada
            //
            this.cmbCarreraDeseada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarreraDeseada.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCarreraDeseada.Location = new System.Drawing.Point(360, 38);
            this.cmbCarreraDeseada.Name = "cmbCarreraDeseada";
            this.cmbCarreraDeseada.Size = new System.Drawing.Size(320, 25);
            this.cmbCarreraDeseada.TabIndex = 3;
            //
            // lblFechaInscripcion
            //
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaInscripcion.ForeColor = System.Drawing.Color.DimGray;
            this.lblFechaInscripcion.Location = new System.Drawing.Point(700, 18);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(100, 15);
            this.lblFechaInscripcion.TabIndex = 20;
            this.lblFechaInscripcion.Text = "Fecha de inscripción";
            //
            // dtpFechaInscripcion
            //
            this.dtpFechaInscripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(700, 38);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(180, 25);
            this.dtpFechaInscripcion.TabIndex = 21;
            //
            // btnContinuar
            //
            this.btnContinuar.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A227");
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.btnContinuar.Location = new System.Drawing.Point(20, 105);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.RadioBorde = 10;
            this.btnContinuar.Size = new System.Drawing.Size(160, 38);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            //
            // cardPaso2
            //
            this.cardPaso2.BackColor = System.Drawing.Color.White;
            this.cardPaso2.Controls.Add(this.lblResumen);
            this.cardPaso2.Controls.Add(this.lblAsignaturasTitulo);
            this.cardPaso2.Controls.Add(this.clbAsignaturas);
            this.cardPaso2.Controls.Add(this.btnAtras);
            this.cardPaso2.Controls.Add(this.btnInscribir);
            this.cardPaso2.Location = new System.Drawing.Point(30, 90);
            this.cardPaso2.Name = "cardPaso2";
            this.cardPaso2.Size = new System.Drawing.Size(1050, 310);
            this.cardPaso2.TabIndex = 3;
            this.cardPaso2.Visible = false;
            this.cardPaso2.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            //
            // lblResumen
            //
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResumen.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.lblResumen.Location = new System.Drawing.Point(20, 15);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(200, 20);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "Estudiante — Carrera";
            //
            // lblAsignaturasTitulo
            //
            this.lblAsignaturasTitulo.AutoSize = true;
            this.lblAsignaturasTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAsignaturasTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblAsignaturasTitulo.Location = new System.Drawing.Point(20, 50);
            this.lblAsignaturasTitulo.Name = "lblAsignaturasTitulo";
            this.lblAsignaturasTitulo.Size = new System.Drawing.Size(300, 15);
            this.lblAsignaturasTitulo.TabIndex = 1;
            this.lblAsignaturasTitulo.Text = "Asignaturas del primer cuatrimestre:";
            //
            // clbAsignaturas
            //
            this.clbAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbAsignaturas.CheckOnClick = true;
            this.clbAsignaturas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clbAsignaturas.Location = new System.Drawing.Point(20, 75);
            this.clbAsignaturas.Name = "clbAsignaturas";
            this.clbAsignaturas.Size = new System.Drawing.Size(1010, 180);
            this.clbAsignaturas.TabIndex = 2;
            //
            // btnAtras
            //
            this.btnAtras.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAtras.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.btnAtras.Location = new System.Drawing.Point(20, 265);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.RadioBorde = 10;
            this.btnAtras.Size = new System.Drawing.Size(120, 38);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            //
            // btnInscribir
            //
            this.btnInscribir.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A227");
            this.btnInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnInscribir.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.btnInscribir.Location = new System.Drawing.Point(150, 265);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.RadioBorde = 10;
            this.btnInscribir.Size = new System.Drawing.Size(160, 38);
            this.btnInscribir.TabIndex = 4;
            this.btnInscribir.Text = "Inscribirme";
            this.btnInscribir.Click += new System.EventHandler(this.BtnInscribir_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblMensaje.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2E8B57");
            this.lblMensaje.Location = new System.Drawing.Point(30, 405);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 4;
            //
            // cardGrid
            //
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.Controls.Add(this.dgvInscripciones);
            this.cardGrid.Controls.Add(this.lblListado);
            this.cardGrid.Location = new System.Drawing.Point(30, 430);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Size = new System.Drawing.Size(1050, 220);
            this.cardGrid.TabIndex = 5;
            this.cardGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            //
            // lblListado
            //
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0B2545");
            this.lblListado.Location = new System.Drawing.Point(20, 15);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(180, 21);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Inscripciones registradas";
            //
            // dgvInscripciones
            //
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AllowUserToDeleteRows = false;
            this.dgvInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInscripciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvInscripciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInscripciones.ColumnHeadersHeight = 36;
            this.dgvInscripciones.EnableHeadersVisualStyles = false;
            this.dgvInscripciones.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvInscripciones.Location = new System.Drawing.Point(20, 50);
            this.dgvInscripciones.MultiSelect = false;
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.RowHeadersVisible = false;
            this.dgvInscripciones.RowTemplate.Height = 32;
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(1010, 150);
            this.dgvInscripciones.TabIndex = 1;
            //
            // InscripcionesControl
            //
            this.AutoScroll = true;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F4F6F9");
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cardPaso2);
            this.Controls.Add(this.cardPaso1);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTituloModulo);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "InscripcionesControl";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.Size = new System.Drawing.Size(950, 681);
            this.cardPaso1.ResumeLayout(false);
            this.cardPaso1.PerformLayout();
            this.cardPaso2.ResumeLayout(false);
            this.cardPaso2.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel cardPaso1;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.Label lblCarreraDeseada;
        private System.Windows.Forms.ComboBox cmbCarreraDeseada;
        private System.Windows.Forms.Label lblFechaInscripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private RoundedButton btnContinuar;

        private System.Windows.Forms.Panel cardPaso2;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblAsignaturasTitulo;
        private System.Windows.Forms.CheckedListBox clbAsignaturas;
        private RoundedButton btnAtras;
        private RoundedButton btnInscribir;

        private System.Windows.Forms.Label lblMensaje;

        private System.Windows.Forms.Panel cardGrid;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dgvInscripciones;
    }
}
