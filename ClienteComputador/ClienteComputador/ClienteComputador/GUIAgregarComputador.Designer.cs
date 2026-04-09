namespace ClienteComputador
{
    partial class GUIAgregarComputador
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
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblPortatil = new Label();
            chkPortatil = new CheckBox();
            lblCosto = new Label();
            txtCosto = new TextBox();
            lblPerifericos = new Label();
            txtPerifericos = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();

            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = false;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(70, 130, 180);
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Size = new Size(450, 30);
            lblTitulo.Text = "Agregar Computador";

            // lblCodigo
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 55);
            lblCodigo.Text = "Codigo:";

            txtCodigo.Location = new Point(120, 52);
            txtCodigo.Size = new Size(120, 23);

            // lblMarca
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(12, 90);
            lblMarca.Text = "Marca:";

            txtMarca.Location = new Point(120, 87);
            txtMarca.Size = new Size(200, 23);

            // lblFecha
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 125);
            lblFecha.Text = "Fecha fabricacion:";

            dtpFecha.Location = new Point(120, 122);
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.Format = DateTimePickerFormat.Short;

            // lblEstado
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(12, 160);
            lblEstado.Text = "Estado:";

            txtEstado.Location = new Point(120, 157);
            txtEstado.Size = new Size(200, 23);
            txtEstado.PlaceholderText = "Ej: bueno, malo, regular";

            // lblPortatil
            lblPortatil.AutoSize = true;
            lblPortatil.Location = new Point(12, 195);
            lblPortatil.Text = "Es portatil:";

            chkPortatil.Location = new Point(120, 193);
            chkPortatil.Size = new Size(80, 23);
            chkPortatil.Text = "Si";

            // lblCosto
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(12, 230);
            lblCosto.Text = "Costo mant.:";

            txtCosto.Location = new Point(120, 227);
            txtCosto.Size = new Size(150, 23);
            txtCosto.Text = "0";

            // lblPerifericos
            lblPerifericos.AutoSize = true;
            lblPerifericos.Location = new Point(12, 265);
            lblPerifericos.Text = "Perifericos:";

            txtPerifericos.Location = new Point(120, 262);
            txtPerifericos.Size = new Size(280, 23);
            txtPerifericos.PlaceholderText = "teclado, mouse, monitor";

            // btnGuardar
            btnGuardar.BackColor = Color.FromArgb(70, 130, 180);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(180, 305);
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.Text = "Guardar";
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Click += new EventHandler(btnGuardar_Click);

            // btnCancelar
            btnCancelar.Location = new Point(290, 305);
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += new EventHandler(btnCancelar_Click);

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 355);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo); Controls.Add(txtCodigo);
            Controls.Add(lblMarca); Controls.Add(txtMarca);
            Controls.Add(lblFecha); Controls.Add(dtpFecha);
            Controls.Add(lblEstado); Controls.Add(txtEstado);
            Controls.Add(lblPortatil); Controls.Add(chkPortatil);
            Controls.Add(lblCosto); Controls.Add(txtCosto);
            Controls.Add(lblPerifericos); Controls.Add(txtPerifericos);
            Controls.Add(btnGuardar); Controls.Add(btnCancelar);
            Name = "GUIAgregarComputador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Computador";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo, lblCodigo, lblMarca, lblFecha, lblEstado, lblPortatil, lblCosto, lblPerifericos;
        private TextBox txtCodigo, txtMarca, txtEstado, txtCosto, txtPerifericos;
        private DateTimePicker dtpFecha;
        private CheckBox chkPortatil;
        private Button btnGuardar, btnCancelar;
    }
}
