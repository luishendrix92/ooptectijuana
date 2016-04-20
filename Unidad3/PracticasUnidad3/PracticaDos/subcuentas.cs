using System;

namespace PracticaDos {
  class CuentaCorriente : CuentaBancaria {
    public CuentaCorriente():base() {}
    public CuentaCorriente(int n, string t, double s)
    :base(n, t, s) {} // Fin de constructor sobrecargado

    public double BalanceActual() {
      return Saldo;
    } // Fin de obtener saldo actual
  } // Fin de clase CuentaCorriente

  class CuentaAhorroFijo : CuentaBancaria {
    string fechaVencimiento;

    public string Vencimiento {
      get { return fechaVencimiento;  }
      set { fechaVencimiento = value; }
    } // Fin de getters y setters

    public CuentaAhorroFijo():base() {}
    public CuentaAhorroFijo(int n, string t, double s, string f)
    :base(n, t, s) {
      fechaVencimiento = f;
    } // Fin de constructor sobrecargado

    public double DepositoMes() {
      return 500;
    } // Fin de regresar el depósito mensual
  } // Fin de clase CuentaAhorroFijo

  class PlanPensiones : CuentaBancaria {
    string fechaVencimiento, cotizacion;
    int numCuentaOrigen;

    public string Vencimiento {
      get { return fechaVencimiento;  }
      set { fechaVencimiento = value; }
    } public string Cotizacion {
      get { return cotizacion;  }
      set { cotizacion = value; }
    } public int Origen {
      get { return numCuentaOrigen;  }
      set { numCuentaOrigen = value; }
    } // Fin de getters y setters

    public PlanPensiones():base() {}
    public PlanPensiones(int n, string t, double s, string f, string c)
    :base(n, t, s) {
      fechaVencimiento = f; cotizacion = c; numCuentaOrigen = n;
    } // Fin de constructor sobrecargado
  } // Fin de clase PlanPensiones
} // Fin de espacio de nombre