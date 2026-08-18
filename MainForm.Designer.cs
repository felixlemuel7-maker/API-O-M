namespace Periodoacademico26
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelSidebar = new Panel();
            navPeriodos = new Label();
            navAsignaturas = new Label();
            navCarreras = new Label();
            navInscripciones = new Label();
            navRegistro = new Label();
            lblTituloApp = new Label();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelContenido = new Panel();
            pictureBox1 = new PictureBox();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(11, 37, 69);
            panelSidebar.Controls.Add(navPeriodos);
            panelSidebar.Controls.Add(navAsignaturas);
            panelSidebar.Controls.Add(navCarreras);
            panelSidebar.Controls.Add(navInscripciones);
            panelSidebar.Controls.Add(navRegistro);
            panelSidebar.Controls.Add(lblTituloApp);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(230, 681);
            panelSidebar.TabIndex = 0;
            // 
            // navPeriodos
            // 
            navPeriodos.BackColor = Color.FromArgb(19, 49, 92);
            navPeriodos.Cursor = Cursors.Hand;
            navPeriodos.Dock = DockStyle.Top;
            navPeriodos.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            navPeriodos.ForeColor = Color.FromArgb(201, 162, 39);
            navPeriodos.Location = new Point(0, 370);
            navPeriodos.Name = "navPeriodos";
            navPeriodos.Size = new Size(230, 55);
            navPeriodos.TabIndex = 6;
            navPeriodos.Tag = "Periodos";
            navPeriodos.Text = "  📅  Períodos\r\n       Académicos";
            navPeriodos.TextAlign = ContentAlignment.MiddleLeft;
            navPeriodos.Click += NavItem_Click;
            // 
            // navAsignaturas
            // 
            navAsignaturas.Cursor = Cursors.Hand;
            navAsignaturas.Dock = DockStyle.Top;
            navAsignaturas.Font = new Font("Segoe UI", 10F);
            navAsignaturas.ForeColor = Color.Gainsboro;
            navAsignaturas.Location = new Point(0, 325);
            navAsignaturas.Name = "navAsignaturas";
            navAsignaturas.Size = new Size(230, 45);
            navAsignaturas.TabIndex = 5;
            navAsignaturas.Tag = "Asignaturas";
            navAsignaturas.Text = "  📚  Asignaturas";
            navAsignaturas.TextAlign = ContentAlignment.MiddleLeft;
            navAsignaturas.Click += NavItem_Click;
            navAsignaturas.MouseEnter += NavItem_MouseEnter;
            navAsignaturas.MouseLeave += NavItem_MouseLeave;
            // 
            // navCarreras
            // 
            navCarreras.Cursor = Cursors.Hand;
            navCarreras.Dock = DockStyle.Top;
            navCarreras.Font = new Font("Segoe UI", 10F);
            navCarreras.ForeColor = Color.Gainsboro;
            navCarreras.Location = new Point(0, 280);
            navCarreras.Name = "navCarreras";
            navCarreras.Size = new Size(230, 45);
            navCarreras.TabIndex = 4;
            navCarreras.Tag = "Carreras";
            navCarreras.Text = "  🏛️  Carreras";
            navCarreras.TextAlign = ContentAlignment.MiddleLeft;
            navCarreras.Click += NavItem_Click;
            navCarreras.MouseEnter += NavItem_MouseEnter;
            navCarreras.MouseLeave += NavItem_MouseLeave;
            // 
            // navInscripciones
            // 
            navInscripciones.Cursor = Cursors.Hand;
            navInscripciones.Dock = DockStyle.Top;
            navInscripciones.Font = new Font("Segoe UI", 10F);
            navInscripciones.ForeColor = Color.Gainsboro;
            navInscripciones.Location = new Point(0, 235);
            navInscripciones.Name = "navInscripciones";
            navInscripciones.Size = new Size(230, 45);
            navInscripciones.TabIndex = 2;
            navInscripciones.Tag = "Inscripciones";
            navInscripciones.Text = "  📝  Inscripciones";
            navInscripciones.TextAlign = ContentAlignment.MiddleLeft;
            navInscripciones.Click += NavItem_Click;
            navInscripciones.MouseEnter += NavItem_MouseEnter;
            navInscripciones.MouseLeave += NavItem_MouseLeave;
            // 
            // navRegistro
            // 
            navRegistro.Cursor = Cursors.Hand;
            navRegistro.Dock = DockStyle.Top;
            navRegistro.Font = new Font("Segoe UI", 10F);
            navRegistro.ForeColor = Color.Gainsboro;
            navRegistro.Location = new Point(0, 190);
            navRegistro.Name = "navRegistro";
            navRegistro.Size = new Size(230, 45);
            navRegistro.TabIndex = 3;
            navRegistro.Tag = "Registro";
            navRegistro.Text = "  🎓  Registro";
            navRegistro.TextAlign = ContentAlignment.MiddleLeft;
            navRegistro.Click += NavItem_Click;
            navRegistro.MouseEnter += NavItem_MouseEnter;
            navRegistro.MouseLeave += NavItem_MouseLeave;
            // 
            // lblTituloApp
            // 
            lblTituloApp.Dock = DockStyle.Top;
            lblTituloApp.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTituloApp.ForeColor = Color.White;
            lblTituloApp.Location = new Point(0, 130);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Padding = new Padding(10, 5, 10, 0);
            lblTituloApp.Size = new Size(230, 60);
            lblTituloApp.TabIndex = 1;
            lblTituloApp.Text = "Universidad\r\nDominicana O&M";
            lblTituloApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(11, 37, 69);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(230, 130);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += PanelLogo_Paint;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Georgia", 22F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(201, 162, 39);
            lblLogo.Location = new Point(70, 15);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(90, 90);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "O&M";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(244, 246, 249);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(230, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(950, 681);
            panelContenido.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1180, 681);
            Controls.Add(panelContenido);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(1096, 720);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Universidad O&M - Sistema Académico";
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label navInscripciones;
        private System.Windows.Forms.Label navAsignaturas;
        private System.Windows.Forms.Label navCarreras;
        private System.Windows.Forms.Label navRegistro;
        private System.Windows.Forms.Label navPeriodos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Panel panelContenido;
        private PictureBox pictureBox1;
    }
}
