using RestSharp;

namespace ClienteComputador
{
    public partial class GUIAgregarComputador : Form
    {
        public GUIAgregarComputador()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtMarca.Text == "")
            {
                MessageBox.Show("El codigo y la marca son obligatorios.", "Aviso");
                return;
            }

            try
            {
                // Armar lista de perifericos separados por coma
                var perifericos = new List<string>();
                if (txtPerifericos.Text.Trim() != "")
                {
                    foreach (var p in txtPerifericos.Text.Split(','))
                        perifericos.Add(p.Trim());
                }

                var client = new RestClient("http://localhost:8080");
                var request = new RestRequest("/computadores", Method.Post);
                request.AddHeader("Content-Type", "application/json");

                // El JSON exacto que espera el servidor
                request.AddJsonBody(new
                {
                    codigo = int.Parse(txtCodigo.Text),
                    marca = txtMarca.Text,
                    fechaFabricacion = dtpFecha.Value.ToString("yyyy-MM-dd") + "T00:00:00",
                    estado = txtEstado.Text,
                    portatil = chkPortatil.Checked,
                    costoMantenimiento = double.Parse(txtCosto.Text),
                    perifericos = perifericos,
                    activo = true
                });

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Computador agregado correctamente.", "Exito");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode + "\n" + response.Content, "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtMarca.Text = "";
            txtEstado.Text = "";
            txtCosto.Text = "";
            txtPerifericos.Text = "";
            chkPortatil.Checked = false;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
