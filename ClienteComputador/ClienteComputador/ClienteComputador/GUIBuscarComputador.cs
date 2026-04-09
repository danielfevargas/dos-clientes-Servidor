using RestSharp;

namespace ClienteComputador
{
    public partial class GUIBuscarComputador : Form
    {
        public GUIBuscarComputador()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un codigo.", "Aviso");
                return;
            }

            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                var client = new RestClient("http://localhost:8080");
                var request = new RestRequest("/computadores/" + codigo, Method.Get);
                var response = client.Get<Computador>(request);

                if (response != null)
                {
                    var lista = new List<Computador> { response };
                    dgvResultado.DataSource = lista;
                    OcultarColumnas();
                }
                else
                {
                    MessageBox.Show("No se encontro ningun computador con ese codigo.", "Aviso");
                    dgvResultado.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void OcultarColumnas()
        {
            // Ocultar columnas internas o de baja utilidad
            string[] ocultar = { "activo", "perifericos", "portatil" };
            foreach (var col in ocultar)
                if (dgvResultado.Columns.Contains(col))
                    dgvResultado.Columns[col].Visible = false;

            // Renombrar las bonitas
            if (dgvResultado.Columns.Contains("codigo"))
                dgvResultado.Columns["codigo"].HeaderText = "Codigo";
            if (dgvResultado.Columns.Contains("marca"))
                dgvResultado.Columns["marca"].HeaderText = "Marca";
            if (dgvResultado.Columns.Contains("fechaFabricacion"))
                dgvResultado.Columns["fechaFabricacion"].HeaderText = "Fecha";
            if (dgvResultado.Columns.Contains("estado"))
                dgvResultado.Columns["estado"].HeaderText = "Estado";
            if (dgvResultado.Columns.Contains("costoMantenimiento"))
                dgvResultado.Columns["costoMantenimiento"].HeaderText = "Costo";
            if (dgvResultado.Columns.Contains("PortatilStr"))
                dgvResultado.Columns["PortatilStr"].HeaderText = "Portatil";
            if (dgvResultado.Columns.Contains("ActivoStr"))
                dgvResultado.Columns["ActivoStr"].HeaderText = "Activo";
            if (dgvResultado.Columns.Contains("PericosStr"))
                dgvResultado.Columns["PericosStr"].HeaderText = "Perifericos";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
