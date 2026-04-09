namespace ClienteComputador
{
    partial class GUIPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            computadoresToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            lblBienvenida = new Label();
            lblInstruccion = new Label();

            menuStrip1.SuspendLayout();
            SuspendLayout();

            // menuStrip1
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                computadoresToolStripMenuItem,
                ayudaToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(600, 24);
            menuStrip1.BackColor = Color.FromArgb(70, 130, 180);
            menuStrip1.ForeColor = Color.White;

            // computadoresToolStripMenuItem
            computadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                agregarToolStripMenuItem,
                buscarToolStripMenuItem,
                listarToolStripMenuItem,
                toolStripSeparator1,
                eliminarToolStripMenuItem,
                actualizarToolStripMenuItem
            });
            computadoresToolStripMenuItem.Name = "computadoresToolStripMenuItem";
            computadoresToolStripMenuItem.Text = "Computadores";
            computadoresToolStripMenuItem.ForeColor = Color.White;

            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += new EventHandler(agregarToolStripMenuItem_Click);

            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Text = "Buscar";
            buscarToolStripMenuItem.Click += new EventHandler(buscarToolStripMenuItem_Click);

            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += new EventHandler(listarToolStripMenuItem_Click);

            toolStripSeparator1.Name = "toolStripSeparator1";

            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += new EventHandler(eliminarToolStripMenuItem_Click);

            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += new EventHandler(actualizarToolStripMenuItem_Click);

            // ayudaToolStripMenuItem
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                acercaDeToolStripMenuItem
            });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.ForeColor = Color.White;

            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += new EventHandler(acercaDeToolStripMenuItem_Click);

            // lblBienvenida
            lblBienvenida.AutoSize = false;
            lblBienvenida.Dock = DockStyle.None;
            lblBienvenida.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(70, 130, 180);
            lblBienvenida.Location = new Point(0, 80);
            lblBienvenida.Size = new Size(600, 40);
            lblBienvenida.Text = "Gestion de Computadores";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;

            // lblInstruccion
            lblInstruccion.AutoSize = false;
            lblInstruccion.Dock = DockStyle.None;
            lblInstruccion.Font = new Font("Segoe UI", 10F);
            lblInstruccion.ForeColor = Color.Gray;
            lblInstruccion.Location = new Point(0, 130);
            lblInstruccion.Size = new Size(600, 30);
            lblInstruccion.Text = "Use el menu para navegar";
            lblInstruccion.TextAlign = ContentAlignment.MiddleCenter;

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 350);
            Controls.Add(lblBienvenida);
            Controls.Add(lblInstruccion);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GUIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Computadores";

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem computadoresToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label lblBienvenida;
        private Label lblInstruccion;
    }
}
