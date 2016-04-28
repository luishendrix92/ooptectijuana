using System;

namespace PracticaTres {
  class CuentaCorriente : CuentaBancaria, IPresentar {
    public CuentaCorriente():base() {}
    public CuentaCorriente(int n, string t, double s, double i)
    :base(n, t, s, i) {} // Fin de constructor sobrecargado
    
    public double BalanceActual() {
      return Saldo;
    } // Fin de obtener saldo actual
    
    public override void DepositoInteresMes() {
      double descuento = 15;

      Saldo -= descuento;
      Console.WriteLine("Se te descontaron {0:C2} por depositar!",
        descuento);
    } // Fin de depositar con interés mensual
    
    public void PresentarDatos() {
      Console.WriteLine("CUENTA CORRIENTE");
      Console.WriteLine("====================================");
      Console.WriteLine("N° {0} de cuenta.", Numero);
      Console.WriteLine("Titular: {0}.", Titular);
      Console.WriteLine("Saldo: {0:C2}.", Saldo);
      Console.WriteLine("Interés: {0}%", Interes);
    } // Fin de mostrar datos de cuenta
  } // Fin de clase CuentaCorriente

  class CuentaAhorroFijo : CuentaBancaria, IPresentar {
    string fechaVencimiento;

    public string Vencimiento {
      get { return fechaVencimiento;  }
      set { fechaVencimiento = value; }
    } // Fin de getters y setters

    public CuentaAhorroFijo():base() {}
    public CuentaAhorroFijo(int n, string t, double s, double i, string f)
    :base(n, t, s, i) {
      fechaVencimiento = f;
    } // Fin de constructor sobrecargado

    public double DepositoMes() {
      return 500;
    } // Fin de regresar el depósito mensual
    
    public override void DepositoInteresMes() {
      double descuento = 7;

      Saldo -= descuento;
      Console.WriteLine("Se te descontaron {0:C2} por depositar!",
        descuento);
    } // Fin de depositar con interés mensual
    
    public void PresentarDatos() {
      Console.WriteLine("\nCUENTA DE AHORRO FIJO");
      Console.WriteLine("====================================");
      Console.WriteLine("N° {0} de cuenta.", Numero);
      Console.WriteLine("Titular: {0}.", Titular);
      Console.WriteLine("Saldo: {0:C2}.", Saldo);
      Console.WriteLine("Interés: {0}%", Interes);
      Console.WriteLine("Vence el: {0}.", fechaVencimiento);
      Console.WriteLine("Depósito mensual: {0:C2}.", DepositoMes());
    } // Fin de mostrar datos en pantalla
  } // Fin de clase CuentaAhorroFijo

  class PlanPensiones : CuentaBancaria, IPresentar {
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
    public PlanPensiones(int n, string t, double s, double i, string f, string c)
    :base(n, t, s, i) {
      fechaVencimiento = f; cotizacion = c; numCuentaOrigen = n;
    } // Fin de constructor sobrecargado
    
    public override void DepositoInteresMes() {
      Console.WriteLine("No hubo interés por depósito!");
    } // Fin de depositar con interés mensual
    
    public void PresentarDatos() {
      Console.WriteLine("\nPLAN DE PENSIONES");
      Console.WriteLine("====================================");
      Console.WriteLine("N° {0} de cuenta.", Origen);
      Console.WriteLine("Titular: {0}.", Titular);
      Console.WriteLine("Saldo: {0:C2}.", Saldo);
      Console.WriteLine("Interés: {0}%", Interes);
      Console.WriteLine("Vence el: {0}.", fechaVencimiento);
      Console.WriteLine("Cotización: {0}.", cotizacion);
    } // Fin de mostrar datos en pantalla
  } // Fin de clase PlanPensiones
} // Fin de espacio de nombre