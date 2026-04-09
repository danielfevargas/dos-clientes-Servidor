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
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(70, 130, 180);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { computadoresToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(686, 30);
            menuStrip1.TabIndex = 2;
            // 
            // computadoresToolStripMenuItem
            // 
            computadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, buscarToolStripMenuItem, listarToolStripMenuItem, toolStripSeparator1, eliminarToolStripMenuItem, actualizarToolStripMenuItem });
            computadoresToolStripMenuItem.ForeColor = Color.White;
            computadoresToolStripMenuItem.Name = "computadoresToolStripMenuItem";
            computadoresToolStripMenuItem.Size = new Size(121, 24);
            computadoresToolStripMenuItem.Text = "Computadores";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(158, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(158, 26);
            buscarToolStripMenuItem.Text = "Buscar";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(158, 26);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(158, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(158, 26);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.ForeColor = Color.White;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(224, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(70, 130, 180);
            lblBienvenida.Location = new Point(0, 107);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(686, 53);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Gestion de Computadores";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstruccion
            // 
            lblInstruccion.Font = new Font("Segoe UI", 10F);
            lblInstruccion.ForeColor = Color.Gray;
            lblInstruccion.Location = new Point(0, 173);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(686, 40);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Use el menu para navegar";
            lblInstruccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GUIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 467);
            Controls.Add(lblBienvenida);
            Controls.Add(lblInstruccion);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
