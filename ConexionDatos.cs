using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Banco
{
    internal class ConexionDatos
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-QH3VDO7\SQLEXPRESS;Initial Catalog=Banco;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        Cuenta oCuenta = new Cuenta();

        private void ConectarBD()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void DesconectarBD()
        {
            conexion.Close();
        }

        public DataTable CargarBd(string consulta)
        {
            DataTable tabla = new DataTable();
            ConectarBD();
            comando.CommandText = consulta;
            tabla.Load(comando.ExecuteReader());
            DesconectarBD();
            return tabla;
        }

        public int ingresoBD(Cuenta oCuenta)
        {
            int filasAfectadas = 0;
            ConectarBD();
            comando.CommandText = "INSERT INTO Cuentas ([cbu],[nombre],[apellido],[id_tipo_dni],[dni],[id_tipo_cuenta],[id_tipo_moneda],[id_ultimo_movimiento],[saldo]) VALUES(@cbu,@nombre,@apellido,@id_tipo_dni,@dni,@id_tipo_cuenta,@id_tipo_moneda,@id_ultimo_movimiento,@saldo)";
            parametros(oCuenta);
            filasAfectadas = comando.ExecuteNonQuery();
            DesconectarBD();
            return filasAfectadas;
        }

        public int edicionBD(Cuenta oCuenta)
        {
            int filasAfectadas = 0;
            ConectarBD();
            comando.CommandText = "UPDATE Cuentas SET nombre=@nombre, apellido=@apellido, id_tipo_dni=@id_tipo_dni, dni=@dni, id_tipo_cuenta=@id_tipo_cuenta, id_tipo_moneda=@id_tipo_moneda, id_ultimo_movimiento=@id_ultimo_movimiento, saldo=@saldo WHERE cbu=" + oCuenta.pCbu;
            parametros(oCuenta);
            filasAfectadas = comando.ExecuteNonQuery();
            DesconectarBD();
            return filasAfectadas;
        }

        public int borrarBD(Cuenta oCuenta)
        {
            int filasAfectadas = 0;
            ConectarBD();
            comando.CommandText = "DELETE Cuentas WHERE cbu=" + oCuenta.pCbu;
            parametros(oCuenta);
            filasAfectadas = comando.ExecuteNonQuery();
            DesconectarBD();
            return filasAfectadas;
        }

        public DataTable sp(string Comando)
        {
            
            ConectarBD();
            DataTable tabla = new DataTable();
            comando.CommandText = Comando;
            tabla.Load(comando.ExecuteReader());
            DesconectarBD();
            return tabla; 
        }



        /* public DataTable ComboSp(string nombreSp)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(nombreSp, conexion);
            DataTable tabla = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
       */

    public void prueba(string nombreSp,TextBox txt)
    {
        conexion.Open();
        SqlCommand comando = new SqlCommand(nombreSp, conexion);
        
        comando.CommandType = CommandType.StoredProcedure;
        SqlDataReader registro= comando.ExecuteReader();
            if (registro.Read())
            {
                txt.Text = registro.ToString();
            }
    }


private void parametros(Cuenta oCuenta)
{
   comando.Parameters.Clear();
   comando.Parameters.AddWithValue("@cbu", oCuenta.pCbu);
   comando.Parameters.AddWithValue("@nombre", oCuenta.pNombre);
   comando.Parameters.AddWithValue("@apellido", oCuenta.pApellido);
   comando.Parameters.AddWithValue("@id_tipo_dni", oCuenta.pTipo_dni);
   comando.Parameters.AddWithValue("@dni", oCuenta.pDni);
   comando.Parameters.AddWithValue("@id_tipo_cuenta", oCuenta.pTipo_cuenta);
   comando.Parameters.AddWithValue("@id_tipo_moneda", oCuenta.pMoneda);
   comando.Parameters.AddWithValue("@id_ultimo_movimiento", oCuenta.pUltimo_movimiento);
   comando.Parameters.AddWithValue("@saldo", oCuenta.pSaldo);
}
}
}
