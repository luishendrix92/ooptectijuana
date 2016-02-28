using System;

namespace Tarea6 {
  class CuentaBancaria {
    private int    numero ;
    private float  saldo  ;
    private string titular;
    static  int    cuentas;

    public int NumeroCuenta {
      get { return numero;  }
      set { numero = value; }
    } public float Saldo {
      // No estoy seguro si sea
      // buena idea dar acceso
      // a esta propiedad...
      get { return saldo;  }
      set { saldo = value; }
    } public string Titular {
      get { return titular;  }
      set { titular = value; }
    } // Fin de getters y setters

    public CuentaBancaria() {
      cuentas += 1;
      numero   = cuentas;
    } public CuentaBancaria(float s, string t) {
      cuentas += 1;
      numero   = cuentas;
      saldo    = s;
      titular  = t;
    } // Fin de constructor sobrecargado

    public void Deposito(float monto) {
      if (monto > 0) {
        saldo += monto;
        Console.WriteLine("Depósito realizado ({0}).", saldo);
        Console.WriteLine("Cuenta: {0}", titular);
        Console.WriteLine("> Balance: {0:C2}\n", saldo);
      } else { // Monto fue de 0 o negativo
        Console.WriteLine("El monto debe ser positivo.");
        Console.WriteLine("Cuenta: {0}\n", titular);
      } // Fin de comprobar monto positivo
    } // Fin de depositar saldo a cuenta

    public float Retiro(float monto) {
      if (saldo >= monto && monto > 0) {
        saldo -= monto;
        Console.WriteLine("Retiro realizado ({0}).", saldo);
        Console.WriteLine("Cuenta: {0}", titular);
        Console.WriteLine("> Balance: {0:C2}\n", saldo);
        return monto;
      } else { // No hay dinero suficiente
        Console.WriteLine("Retiro fallido.");
        Console.WriteLine("Cuenta: {0}\n", titular);
        return 0;
      } // Fin de ver si hay dinero
    } // Fin de retirar saldo de la cuenta
  } // Fin de clase CuentaBancaria
} // Fin de espacio de nombre