namespace Form_Banco
{
    partial class TxtNombre
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCbu = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTipo_dni = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblTipo_cuenta = new System.Windows.Forms.Label();
            this.LblMoneda = new System.Windows.Forms.Label();
            this.LblUltimo_movimiento = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtCbu = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.CmbTipo_dni = new System.Windows.Forms.ComboBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.CmbTipo_Cuenta = new System.Windows.Forms.ComboBox();
            this.CmbMoneda = new System.Windows.Forms.ComboBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.RbtDeposito = new System.Windows.Forms.RadioButton();
            this.RbtExtraccion = new System.Windows.Forms.RadioButton();
            this.LtsCuenta = new System.Windows.Forms.ListBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtCajasAhorro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPesos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEuros = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCuentasCorrientes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCbu
            // 
            this.LblCbu.AutoSize = true;
            this.LblCbu.Location = new System.Drawing.Point(87, 15);
            this.LblCbu.Name = "LblCbu";
            this.LblCbu.Size = new System.Drawing.Size(29, 15);
            this.LblCbu.TabIndex = 0;
            this.LblCbu.Text = "Cbu";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(65, 44);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(51, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(65, 73);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(51, 15);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            this.LblApellido.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblTipo_dni
            // 
            this.LblTipo_dni.AutoSize = true;
            this.LblTipo_dni.Location = new System.Drawing.Point(65, 102);
            this.LblTipo_dni.Name = "LblTipo_dni";
            this.LblTipo_dni.Size = new System.Drawing.Size(51, 15);
            this.LblTipo_dni.TabIndex = 3;
            this.LblTipo_dni.Text = "Tipo Dni";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(91, 131);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(25, 15);
            this.LblDni.TabIndex = 4;
            this.LblDni.Text = "Dni";
            // 
            // LblTipo_cuenta
            // 
            this.LblTipo_cuenta.AutoSize = true;
            this.LblTipo_cuenta.Location = new System.Drawing.Point(29, 160);
            this.LblTipo_cuenta.Name = "LblTipo_cuenta";
            this.LblTipo_cuenta.Size = new System.Drawing.Size(87, 15);
            this.LblTipo_cuenta.TabIndex = 5;
            this.LblTipo_cuenta.Text = "Tipo de Cuenta";
            // 
            // LblMoneda
            // 
            this.LblMoneda.AutoSize = true;
            this.LblMoneda.Location = new System.Drawing.Point(65, 189);
            this.LblMoneda.Name = "LblMoneda";
            this.LblMoneda.Size = new System.Drawing.Size(51, 15);
            this.LblMoneda.TabIndex = 6;
            this.LblMoneda.Text = "Moneda";
            // 
            // LblUltimo_movimiento
            // 
            this.LblUltimo_movimiento.AutoSize = true;
            this.LblUltimo_movimiento.Location = new System.Drawing.Point(5, 217);
            this.LblUltimo_movimiento.Name = "LblUltimo_movimiento";
            this.LblUltimo_movimiento.Size = new System.Drawing.Size(111, 15);
            this.LblUltimo_movimiento.TabIndex = 7;
            this.LblUltimo_movimiento.Text = "Ultimo Movimiento";
            this.LblUltimo_movimiento.Click += new System.EventHandler(this.LblUltimo_movimiento_Click);
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Location = new System.Drawing.Point(80, 247);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(36, 15);
            this.LblSaldo.TabIndex = 8;
            this.LblSaldo.Text = "Saldo";
            // 
            // TxtCbu
            // 
            this.TxtCbu.Location = new System.Drawing.Point(131, 12);
            this.TxtCbu.Name = "TxtCbu";
            this.TxtCbu.Size = new System.Drawing.Size(191, 23);
            this.TxtCbu.TabIndex = 9;
            this.TxtCbu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtCbu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCbu_KeyPress);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(131, 41);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(191, 23);
            this.TxtNombres.TabIndex = 10;
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(131, 70);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(191, 23);
            this.TxtApellido.TabIndex = 11;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // CmbTipo_dni
            // 
            this.CmbTipo_dni.FormattingEnabled = true;
            this.CmbTipo_dni.Location = new System.Drawing.Point(130, 99);
            this.CmbTipo_dni.Name = "CmbTipo_dni";
            this.CmbTipo_dni.Size = new System.Drawing.Size(192, 23);
            this.CmbTipo_dni.TabIndex = 12;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(131, 128);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(191, 23);
            this.TxtDni.TabIndex = 13;
            this.TxtDni.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
            // 
            // CmbTipo_Cuenta
            // 
            this.CmbTipo_Cuenta.FormattingEnabled = true;
            this.CmbTipo_Cuenta.Location = new System.Drawing.Point(131, 157);
            this.CmbTipo_Cuenta.Name = "CmbTipo_Cuenta";
            this.CmbTipo_Cuenta.Size = new System.Drawing.Size(191, 23);
            this.CmbTipo_Cuenta.TabIndex = 14;
            // 
            // CmbMoneda
            // 
            this.CmbMoneda.FormattingEnabled = true;
            this.CmbMoneda.Location = new System.Drawing.Point(131, 186);
            this.CmbMoneda.Name = "CmbMoneda";
            this.CmbMoneda.Size = new System.Drawing.Size(191, 23);
            this.CmbMoneda.TabIndex = 15;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(130, 244);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(192, 23);
            this.TxtSaldo.TabIndex = 18;
            this.TxtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldo_KeyPress);
            // 
            // RbtDeposito
            // 
            this.RbtDeposito.AutoSize = true;
            this.RbtDeposito.Location = new System.Drawing.Point(131, 215);
            this.RbtDeposito.Name = "RbtDeposito";
            this.RbtDeposito.Size = new System.Drawing.Size(83, 19);
            this.RbtDeposito.TabIndex = 16;
            this.RbtDeposito.TabStop = true;
            this.RbtDeposito.Text = "1-Deposito";
            this.RbtDeposito.UseVisualStyleBackColor = true;
            // 
            // RbtExtraccion
            // 
            this.RbtExtraccion.AutoSize = true;
            this.RbtExtraccion.Location = new System.Drawing.Point(231, 215);
            this.RbtExtraccion.Name = "RbtExtraccion";
            this.RbtExtraccion.Size = new System.Drawing.Size(91, 19);
            this.RbtExtraccion.TabIndex = 17;
            this.RbtExtraccion.TabStop = true;
            this.RbtExtraccion.Text = "2-Extracción";
            this.RbtExtraccion.UseVisualStyleBackColor = true;
            // 
            // LtsCuenta
            // 
            this.LtsCuenta.FormattingEnabled = true;
            this.LtsCuenta.ItemHeight = 15;
            this.LtsCuenta.Location = new System.Drawing.Point(344, 12);
            this.LtsCuenta.Name = "LtsCuenta";
            this.LtsCuenta.Size = new System.Drawing.Size(267, 259);
            this.LtsCuenta.TabIndex = 24;
            this.LtsCuenta.SelectedIndexChanged += new System.EventHandler(this.LtsCuenta_SelectedIndexChanged);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(41, 303);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 19;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(122, 303);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 20;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(203, 303);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 21;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(284, 303);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 22;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(365, 303);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(536, 303);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 25;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtCajasAhorro
            // 
            this.TxtCajasAhorro.Enabled = false;
            this.TxtCajasAhorro.Location = new System.Drawing.Point(655, 38);
            this.TxtCajasAhorro.Name = "TxtCajasAhorro";
            this.TxtCajasAhorro.ReadOnly = true;
            this.TxtCajasAhorro.Size = new System.Drawing.Size(100, 23);
            this.TxtCajasAhorro.TabIndex = 26;
            this.TxtCajasAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCajasAhorro.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cantidad Cajas de Ahorro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Promedio de pesos depositados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtPesos
            // 
            this.TxtPesos.Enabled = false;
            this.TxtPesos.Location = new System.Drawing.Point(655, 151);
            this.TxtPesos.Name = "TxtPesos";
            this.TxtPesos.ReadOnly = true;
            this.TxtPesos.Size = new System.Drawing.Size(100, 23);
            this.TxtPesos.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Euros Depositados";
            // 
            // TxtEuros
            // 
            this.TxtEuros.Enabled = false;
            this.TxtEuros.Location = new System.Drawing.Point(655, 209);
            this.TxtEuros.Name = "TxtEuros";
            this.TxtEuros.ReadOnly = true;
            this.TxtEuros.Size = new System.Drawing.Size(100, 23);
            this.TxtEuros.TabIndex = 31;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(6, 12);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 32;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cantidad Cuentas Corrientes";
            // 
            // TxtCuentasCorrientes
            // 
            this.TxtCuentasCorrientes.Enabled = false;
            this.TxtCuentasCorrientes.Location = new System.Drawing.Point(655, 96);
            this.TxtCuentasCorrientes.Name = "TxtCuentasCorrientes";
            this.TxtCuentasCorrientes.ReadOnly = true;
            this.TxtCuentasCorrientes.Size = new System.Drawing.Size(100, 23);
            this.TxtCuentasCorrientes.TabIndex = 34;
            this.TxtCuentasCorrientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCuentasCorrientes.TextChanged += new System.EventHandler(this.TxtCuentasCorrientes_TextChanged);
            // 
            // TxtNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 336);
            this.Controls.Add(this.TxtCuentasCorrientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.TxtEuros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCajasAhorro);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.LtsCuenta);
            this.Controls.Add(this.RbtExtraccion);
            this.Controls.Add(this.RbtDeposito);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.CmbMoneda);
            this.Controls.Add(this.CmbTipo_Cuenta);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.CmbTipo_dni);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.TxtCbu);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.LblUltimo_movimiento);
            this.Controls.Add(this.LblMoneda);
            this.Controls.Add(this.LblTipo_cuenta);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblTipo_dni);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCbu);
            this.Name = "TxtNombre";
            this.Text = "ABM Banco";
            this.Load += new System.EventHandler(this.TxtNombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblCbu;
        private Label LblNombre;
        private Label LblApellido;
        private Label LblTipo_dni;
        private Label LblDni;
        private Label LblTipo_cuenta;
        private Label LblMoneda;
        private Label LblUltimo_movimiento;
        private Label LblSaldo;
        private TextBox TxtCbu;
        private TextBox TxtNombres;
        private TextBox TxtApellido;
        private ComboBox CmbTipo_dni;
        private TextBox TxtDni;
        private ComboBox CmbTipo_Cuenta;
        private ComboBox CmbMoneda;
        private TextBox TxtSaldo;
        private RadioButton RbtDeposito;
        private RadioButton RbtExtraccion;
        private ListBox LtsCuenta;
        private Button BtnNuevo;
        private Button BtnEditar;
        private Button BtnBorrar;
        private Button BtnGrabar;
        private Button BtnCancelar;
        private Button BtnSalir;
        private TextBox TxtCajasAhorro;
        private Label label1;
        private Label label2;
        private TextBox TxtPesos;
        private Label label3;
        private TextBox TxtEuros;
        private Button BtnVerificar;
        private Label label4;
        private TextBox TxtCuentasCorrientes;
    }
}