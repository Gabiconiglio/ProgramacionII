using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Banco
{
    internal class Cuenta
    {
        private int cbu;
        private string nombre;
        private string apellido;
        private int tipo_dni;
        private int dni;
        private int tipo_cuenta;
        private int moneda;
        private int ultimo_movimiento;
        private float saldo;

        public int pCbu
        {
            get { return cbu; }
            set { cbu = value; }
        }
        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string pApellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int pTipo_dni
        {
            get { return tipo_dni; }
            set { tipo_dni = value; }
        }

        public int pDni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int pTipo_cuenta
        {
            get { return tipo_cuenta; }
            set { tipo_cuenta = value; }
        }

        public int pMoneda
        {
            get { return moneda; }
            set { moneda = value; }
        }

        public int pUltimo_movimiento
        {
            get { return ultimo_movimiento; }
            set { ultimo_movimiento = value; }
        }

        public float pSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Cuenta()
        {
            cbu = 0;
            nombre = string.Empty;
            apellido= string.Empty;
            tipo_dni = 0;
            dni = 0;
            tipo_cuenta = 0;
            moneda= 0;
            ultimo_movimiento = 0;
            saldo = 0;
        }

        public Cuenta(int cbu, string nombre, string apellido, int tipo_dni, int dni, int tipo_cuenta, int moneda, int ultimo_movimiento, float saldo)
        {
            this.cbu = cbu;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo_dni = tipo_dni;
            this.dni = dni;
            this.tipo_cuenta = tipo_cuenta;
            this.moneda = moneda;
            this.ultimo_movimiento = ultimo_movimiento;
            this.saldo = saldo;
        }

        public override string ToString()
        {
            return "|"+cbu +" "+ "|"+nombre+" "+ "|" +apellido;
        }
    }
}
