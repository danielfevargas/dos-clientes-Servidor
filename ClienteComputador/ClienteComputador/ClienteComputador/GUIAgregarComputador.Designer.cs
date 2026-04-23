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
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(70, 130, 180);
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Computador";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 55);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(120, 52);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 2;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(12, 90);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(120, 87);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(200, 23);
            txtMarca.TabIndex = 4;
            txtMarca.TextChanged += txtMarca_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 125);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(103, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha fabricacion:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(120, 122);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(12, 160);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(120, 157);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Ej: bueno, malo, regular";
            txtEstado.Size = new Size(200, 23);
            txtEstado.TabIndex = 8;
            // 
            // lblPortatil
            // 
            lblPortatil.AutoSize = true;
            lblPortatil.Location = new Point(12, 195);
            lblPortatil.Name = "lblPortatil";
            lblPortatil.Size = new Size(62, 15);
            lblPortatil.TabIndex = 9;
            lblPortatil.Text = "Es portatil:";
            // 
            // chkPortatil
            // 
            chkPortatil.Location = new Point(120, 193);
            chkPortatil.Name = "chkPortatil";
            chkPortatil.Size = new Size(80, 23);
            chkPortatil.TabIndex = 10;
            chkPortatil.Text = "Si";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(12, 230);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(75, 15);
            lblCosto.TabIndex = 11;
            lblCosto.Text = "Costo mant.:";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(120, 227);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(150, 23);
            txtCosto.TabIndex = 12;
            txtCosto.Text = "0";
            // 
            // lblPerifericos
            // 
            lblPerifericos.AutoSize = true;
            lblPerifericos.Location = new Point(12, 265);
            lblPerifericos.Name = "lblPerifericos";
            lblPerifericos.Size = new Size(65, 15);
            lblPerifericos.TabIndex = 13;
            lblPerifericos.Text = "Perifericos:";
            // 
            // txtPerifericos
            // 
            txtPerifericos.Location = new Point(120, 262);
            txtPerifericos.Name = "txtPerifericos";
            txtPerifericos.PlaceholderText = "teclado, mouse, monitor";
            txtPerifericos.Size = new Size(280, 23);
            txtPerifericos.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(70, 130, 180);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(180, 305);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(290, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // GUIAgregarComputador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 355);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblEstado);
            Controls.Add(txtEstado);
            Controls.Add(lblPortatil);
            Controls.Add(chkPortatil);
            Controls.Add(lblCosto);
            Controls.Add(txtCosto);
            Controls.Add(lblPerifericos);
            Controls.Add(txtPerifericos);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
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
