using System;

namespace Estados
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Jorge Sanchez");

            cuenta.Depositar(500.0);
            cuenta.Depositar(1000.0);
            cuenta.Depositar(5000.0);
            cuenta.Depositar(200.0);
            cuenta.Depositar(1200.0);
            cuenta.Extraer(40000.0);
        }
    }

    class Cuenta
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }
        public Estado Estado { get; set; }

        public Cuenta(string nombre)
        {
            this.Nombre = nombre;
            this.Estado = new EstadoRegular(0.0, this);
        }

        public void Depositar(double monto)
        {
            this.Estado.Depositar(monto);
        }

        public void Extraer(double monto)
        {
            this.Estado.Extraer(monto);
        }
    }

    abstract class Estado
    {
        public double Saldo { get; set; }
        public Cuenta Cuenta { get; set; }
        protected double LimiteInferior { get; set; }
        protected double LimiteSuperior { get; set; }

        public abstract void Depositar(double monto);
        public abstract void Extraer(double monto);
    }

    class EstadoDeudor : Estado
    {
        private EstadoRegular estadoRegular;

        public EstadoDeudor(EstadoRegular estadoRegular)
        {
            this.estadoRegular = estadoRegular;
        }

        public override void Depositar(double monto)
        {
            throw new NotImplementedException();
        }

        public override void Extraer(double monto)
        {
            throw new NotImplementedException();
        }
    }

    class EstadoRegular : Estado
    {

        public EstadoRegular(double monto, Cuenta cuenta)
        {
            this.Saldo = monto;
            this.Cuenta = cuenta;
            Inicializar();
        }

        public override void Depositar(double monto)
        {
            this.Saldo = this.Saldo + monto;
            VerificarCambioDeEstado();
        }

        private void VerificarCambioDeEstado()
        {
            if (this.Saldo < LimiteInferior)
            {
                this.Cuenta.Estado = new EstadoDeudor(this);
            }
            else if (this.Saldo > LimiteSuperior)
            {
                this.Cuenta.Estado = new EstadoVip(this);
            }
        }

        public override void Extraer(double monto)
        {
            this.Saldo = Saldo - monto;
            VerificarCambioDeEstado();
        }

        private void Inicializar()
        {
            LimiteInferior = 0.0;
            LimiteSuperior = 1000000;
        }
    }

    class EstadoVip : Estado
    {
        private Estado estado;
        
        public EstadoVip(Estado estado) : this(estado.Saldo, estado.Cuenta)
        {
            this.estado = estado;
        }

        public EstadoVip(double saldo, Cuenta cuenta)
        {
            this.Saldo = saldo;
            this.Cuenta = cuenta;
            Inicializar();
        }

        private void Inicializar()
        {
            LimiteInferior = 100000;
            LimiteSuperior = 2000000; 
        }

        public override void Depositar(double monto)
        {
            throw new NotImplementedException();
        }

        public override void Extraer(double monto)
        {
            throw new NotImplementedException();
        }
    }
}
