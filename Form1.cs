using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Form_Banco
{
    public partial class TxtNombre : Form
    {
        bool nuevo = false;
        List<Cuenta> CuentaLst = new List<Cuenta>();
        ConexionDatos oBD = new ConexionDatos();
        public TxtNombre()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_Load(object sender, EventArgs e)
        {
            habilitar(false);
            TxtCbu.Enabled = true;
            limpiar();
            cargarCombo("tipos_dni", "id_tipo_dni", "tipo_dni", CmbTipo_dni);
            cargarCombo("tipo_moneda", "id_tipo_moneda", "tipo_moneda", CmbMoneda);
            //cargarCombo_sp();
            Sp();
            //CargarLista();
            cargarlista_Sp();
            cantidadCajas();
            CantidadCuentas();

        }

        private void habilitar(bool x)
        {
            TxtCbu.Enabled = x;
            TxtNombres.Enabled = x;
            TxtApellido.Enabled = x;
            CmbTipo_dni.Enabled = x;
            TxtDni.Enabled = x;
            CmbTipo_Cuenta.Enabled = x;
            CmbMoneda.Enabled = x;
            RbtDeposito.Enabled = x;
            RbtExtraccion.Enabled = x;
            TxtSaldo.Enabled = x;
            BtnNuevo.Enabled = !x;
            BtnEditar.Enabled = !x;
            BtnBorrar.Enabled = !x;
            BtnGrabar.Enabled = x;
            BtnCancelar.Enabled = x;
            BtnSalir.Enabled = !x;    
        }

        private void limpiar()
        {
            TxtCbu.Text = "";
            TxtNombres.Text = "";
            TxtApellido.Text = "";
            CmbTipo_dni.SelectedIndex = -1;
            TxtDni.Text = "";
            CmbTipo_Cuenta.SelectedIndex = -1;
            CmbMoneda.SelectedIndex = -1;
            RbtDeposito.Checked = false;
            RbtExtraccion.Checked = false;
            TxtSaldo.Text = "";
        }

        private void cargarCombo(string Tabla, string valueMember, string displayMember, ComboBox cbo)
        {
            DataTable tabla = oBD.CargarBd("Select * from " + Tabla);
            cbo.DataSource = tabla;
            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
        }

        /* este carga con las variables de salida que definimos en el sp*/
        private void Sp()
        {
            DataTable tabla = oBD.sp("declare  @id int ,@tipos_cuenta varchar exec sp_tipos_cuentas @id output, @tipos_cuenta output");
            CmbTipo_Cuenta.DataSource = tabla;
            CmbTipo_Cuenta.DisplayMember = "tipo_cuenta";
            CmbTipo_Cuenta.ValueMember = "id_tipo_cuenta";
            
        }


        /*
        private void cargarCombo_sp()
        {
            DataTable tabla = oBD.ComboSp("Sp_Cuenta");
            CmbTipo_Cuenta.DataSource = tabla;
            CmbTipo_Cuenta.ValueMember = "id_tipo_cuenta";
            CmbTipo_Cuenta.DisplayMember = "tipo_cuenta";
        }
        este carga sin parametros de salida
        */


        private void LblUltimo_movimiento_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiar();
            nuevo = true;
            TxtCbu.Focus();
        }

        private void CargarLista()
        { 
            CuentaLst.Clear();
            LtsCuenta.Items.Clear();
            DataTable tabla = oBD.CargarBd("Select * from Cuentas");
            foreach (DataRow fila in tabla.Rows)
            {
                Cuenta ocuenta = new Cuenta();
                ocuenta.pCbu = Convert.ToInt32(fila["cbu"].ToString());
                ocuenta.pNombre = fila["nombre"].ToString();
                ocuenta.pApellido = fila["apellido"].ToString();
                ocuenta.pTipo_dni = Convert.ToInt32(fila["id_tipo_dni"].ToString());
                ocuenta.pDni = Convert.ToInt32(fila["dni"].ToString());
                ocuenta.pTipo_cuenta = Convert.ToInt32(fila["id_tipo_cuenta"].ToString());
                ocuenta.pMoneda = Convert.ToInt32(fila["id_tipo_moneda"].ToString());
                ocuenta.pUltimo_movimiento = Convert.ToInt32(fila["id_ultimo_movimiento"].ToString());
                ocuenta.pSaldo = float.Parse(fila["saldo"].ToString());
                CuentaLst.Add(ocuenta);
                LtsCuenta.Items.Add(ocuenta);
            }
        }
        //carga la lista a partir de un sp que hacemos de la tabla cuentas
        private void cargarlista_Sp()
        {
            LtsCuenta.Items.Clear();
            CuentaLst.Clear();
            DataTable tabla = oBD.CargarBd("exec lista_cuentas");
            for (int i=0; i < tabla.Rows.Count; i++)
            {
                Cuenta ocuenta = new Cuenta();
                ocuenta.pCbu = Convert.ToInt32(tabla.Rows[i][0].ToString());
                ocuenta.pNombre = tabla.Rows[i][1].ToString();
                ocuenta.pApellido = tabla.Rows[i][2].ToString();
                ocuenta.pTipo_dni = Convert.ToInt32(tabla.Rows[i][3].ToString());
                ocuenta.pDni = Convert.ToInt32(tabla.Rows[i][4].ToString());
                ocuenta.pTipo_cuenta = Convert.ToInt32(tabla.Rows[i][5].ToString());
                ocuenta.pMoneda = Convert.ToInt32(tabla.Rows[i][6].ToString());
                ocuenta.pUltimo_movimiento = Convert.ToInt32(tabla.Rows[i][7].ToString());
                ocuenta.pSaldo = float.Parse(tabla.Rows[i][8].ToString());
                CuentaLst.Add(ocuenta);
                LtsCuenta.Items.Add(ocuenta);

            }



        }
        private void LtsCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LtsCuenta.SelectedIndex != -1)
            {
                Cuenta oCuenta = (Cuenta)LtsCuenta.SelectedItem;
                TxtCbu.Text = oCuenta.pCbu.ToString();
                TxtNombres.Text = oCuenta.pNombre.ToString();
                TxtApellido.Text = oCuenta.pApellido.ToString();
                CmbTipo_dni.SelectedValue = oCuenta.pTipo_cuenta.ToString();
                TxtDni.Text= oCuenta.pDni.ToString();
                CmbTipo_Cuenta.SelectedValue = oCuenta.pTipo_cuenta.ToString();
                CmbMoneda.SelectedValue = oCuenta.pMoneda.ToString();
                if (oCuenta.pUltimo_movimiento == 1)
                {
                    RbtDeposito.Checked = true;
                }
                else 
                {
                    RbtExtraccion.Checked = true;
                }
                TxtSaldo.Text = oCuenta.pSaldo.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar(false);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                Cuenta oCuenta = new Cuenta();
                if (TxtCbu.Text != "")
                {
                    oCuenta.pCbu = Convert.ToInt32(TxtCbu.Text);
                }
                oCuenta.pNombre = TxtNombres.Text;
                oCuenta.pApellido = TxtApellido.Text;
                oCuenta.pTipo_dni = Convert.ToInt32(CmbTipo_dni.SelectedValue);
                oCuenta.pDni = Convert.ToInt32(TxtDni.Text);
                oCuenta.pTipo_cuenta = Convert.ToInt32(CmbTipo_Cuenta.SelectedValue);
                oCuenta.pMoneda = Convert.ToInt32(CmbMoneda.SelectedValue);
                if (RbtDeposito.Checked)
                {
                    oCuenta.pUltimo_movimiento = 1;
                }
                else
                {
                    oCuenta.pUltimo_movimiento = 2;
                }
                oCuenta.pSaldo = float.Parse(TxtSaldo.Text);

                if (nuevo)
                {
                    if (oBD.ingresoBD(oCuenta) > 0)
                    {
                        MessageBox.Show("Se ingreso Correctamente la Cuenta!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        habilitar(false);
                        limpiar();
                        CargarLista();
                        nuevo = false;
                    }
                }
                else
                {
                    if (LtsCuenta.SelectedIndex != -1)
                    {
                        if (oBD.edicionBD(oCuenta) > 0)
                        {
                            MessageBox.Show("Se modifico la cuenta correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            habilitar(false);
                            limpiar();
                            CargarLista();
                        }
                    }
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            TxtCbu.Enabled = false;
            nuevo = false;
            TxtNombres.Focus();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (LtsCuenta.SelectedIndex != -1)
            { 
                Cuenta oCuenta = (Cuenta)LtsCuenta.SelectedItem;
                {
                    if (MessageBox.Show("Esta seguro que quiere borrar la cuenta " + oCuenta + "?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (oBD.borrarBD(oCuenta) > 0)
                        { 
                            MessageBox.Show("Se borro la cuenta correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            habilitar(false);
                            limpiar();
                            CargarLista();
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cantidadCajas()
        {
            DataTable tabla = oBD.CargarBd("declare @cantidad int exec pa_cantidad_cajas_ahorro @cantidad output select @cantidad 'Cantidad de Cajas de Ahorro'");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                TxtCajasAhorro.Text = tabla.Rows[i][0].ToString();

            }
        }

        private void CantidadCuentas()
        {
            DataTable tabla = oBD.CargarBd("declare @cantidad int exec pa_cantidad_cuentas_corrientes @cantidad output select @cantidad 'Cantidad cuentas corrientes'");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                TxtCuentasCorrientes.Text = tabla.Rows[i][0].ToString();

            }
        }

        //si conocemos el cbu del cliente lo colocamos y nos muestra todos los datos
        private void BtnVerificar_Click(object sender, EventArgs e)
        {

            if (TxtCbu.Text !="")
            {
                string p = TxtCbu.Text;
                
                DataTable tabla = oBD.CargarBd("declare @ap varchar exec sp_datos "+p+", @ap output");
                foreach (DataRow fila in tabla.Rows)
                {
                    string aux = "";
                    TxtNombres.Text = fila["nombre"].ToString();
                    TxtApellido.Text = fila["apellido"].ToString();
                    CmbTipo_dni.SelectedValue = fila["id_tipo_dni"].ToString();
                    TxtDni.Text = fila["dni"].ToString();
                    CmbTipo_Cuenta.SelectedValue = fila["id_tipo_dni"].ToString();
                    CmbMoneda.SelectedValue=fila["id_tipo_moneda"].ToString();
                    aux= fila["id_ultimo_movimiento"].ToString();
                    if (aux.Equals("1"))
                    {
                        RbtDeposito.Checked = true;
                    }
                    else
                    {
                        RbtExtraccion.Checked = true;
                    }
                    TxtSaldo.Text =fila["saldo"].ToString();
                }
            }            
        }

        private bool validar()
        {
            bool resultado = true;
            if (string.IsNullOrEmpty(TxtCbu.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso el Cbu de la cuenta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(TxtApellido.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso el Apellido del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso el Nombre del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CmbTipo_dni.SelectedIndex==-1)
            {
                resultado = false;
                MessageBox.Show("No se selecciono el tipo de Dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(TxtDni.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso el Dni del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CmbTipo_Cuenta.SelectedIndex==-1)
            {
                resultado = false;
                MessageBox.Show("No se selecciono el Tipo de Cuenta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CmbMoneda.SelectedIndex==-1)
            {
                resultado = false;
                MessageBox.Show("No se selecciono el Tipo de Moneda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(TxtSaldo.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso un Importe en la Transacción!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!RbtDeposito.Checked&&!RbtExtraccion.Checked)
            {
                resultado = false;
                MessageBox.Show("No se seleccion el tipo de Transacción!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        private void TxtCbu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled=true; ;
            }
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true; ;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true; ;
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; ;
            }
        }

        private void TxtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; ;
            }
        }

        private void TxtCuentasCorrientes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}