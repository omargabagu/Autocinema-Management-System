using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Tarjeta
    {
        float saldo;
        string numTarjeta;
        string TipoTarjeta;
        string banco;
        string codigoVerificacion;

        public Tarjeta()
        {

        }

        public Tarjeta(float saldo, string numTarjeta, string TipoTarjeta, string banco, string codigoVerificacion)
        {
            this.Saldo = saldo;
            this.NumTarjeta = numTarjeta;
            this.TipoTarjeta1 = TipoTarjeta;
            this.Banco = banco;
            this.CodigoVerificacion = codigoVerificacion;
        }

        public float Saldo { get => saldo; set => saldo = value; }
        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }
        public string TipoTarjeta1 { get => TipoTarjeta; set => TipoTarjeta = value; }
        public string Banco { get => banco; set => banco = value; }
        public string CodigoVerificacion { get => codigoVerificacion; set => codigoVerificacion = value; }
    }
}
