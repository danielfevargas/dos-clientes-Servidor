namespace ClienteComputador
{
    partial class GUIBuscarComputador
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnBuscar = new Button();
            dgvResultado = new DataGridView();
            btnCerrar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();

            lblTitulo.AutoSize = false;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(70, 130, 180);
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Size = new Size(560, 30);
            lblTitulo.Text = "Buscar Computador";

            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 55);
            lblCodigo.Text = "Codigo:";

            txtCodigo.Location = new Point(70, 52);
            txtCodigo.Size = new Size(120, 23);

            btnBuscar.BackColor = Color.FromArgb(70, 130, 180);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(200, 50);
            btnBuscar.Size = new Size(90, 27);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += new EventHandler(btnBuscar_Click);

            dgvResultado.Location = new Point(12, 90);
            dgvResultado.Size = new Size(560, 200);
            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultado.ReadOnly = true;
            dgvResultado.AllowUserToAddRows = false;
            dgvResultado.RowHeadersVisible = false;
            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultado.BackgroundColor = Color.White;
            dgvResultado.BorderStyle = BorderStyle.Fixed3D;

            btnCerrar.Location = new Point(480, 305);
            btnCerrar.Size = new Size(90, 27);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += new EventHandler(btnCerrar_Click);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 350);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo); Controls.Add(txtCodigo);
            Controls.Add(btnBuscar);
            Controls.Add(dgvResultado);
            Controls.Add(btnCerrar);
            Name = "GUIBuscarComputador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Computador";

            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo, lblCodigo;
        private TextBox txtCodigo;
        private Button btnBuscar, btnCerrar;
        private DataGridView dgvResultado;
    }
}
