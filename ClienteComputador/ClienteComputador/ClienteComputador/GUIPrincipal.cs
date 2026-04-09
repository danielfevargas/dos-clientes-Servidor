namespace ClienteComputador
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarComputador frm = new GUIAgregarComputador();
            frm.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarComputador frm = new GUIBuscarComputador();
            frm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListarComputador frm = new GUIListarComputador();
            frm.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIEliminarComputador frm = new GUIEliminarComputador();
            frm.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIActualizarComputador frm = new GUIActualizarComputador();
            frm.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Gestion de Computadores\nVersion 1.0\n\n" +
                "Integrantes:\n- Nombre 1\n- Nombre 2\n- Nombre 3",
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
