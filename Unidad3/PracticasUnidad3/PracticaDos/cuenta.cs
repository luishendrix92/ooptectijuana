using System;

namespace PracticaDos {
  class CuentaBancaria {
    int numero;
    string titular;
    double saldo;

    public int Numero {
      get { return numero;  }
      set { numero = value; }
    } public string Titular {
      get { return titular;  }
      set { titular = value; }
    } public double Saldo {
      get { return saldo;  }
      set { saldo = value; }
    } // Fin de getters y setters

    public CuentaBancaria() {}
    public CuentaBancaria(int n, string t, double s) {
      numero = n; titular = t; saldo = s;
    } // Fin de constructor sobrecargado

    public void Deposito(double monto) {
      saldo += monto;
      Console.WriteLine("Depósito de {0:C2} pesos realizado.", monto);
      DepositoInteresMes();
      Console.WriteLine("Te quedan {0:C2} en tu cuenta.", saldo);
    } // Fin de depositar dinero

    public void Retiro(double monto) {
      if (saldo >= monto) {
        saldo -= monto;
        Console.WriteLine("Se han retirado {0:C2} de la cuenta...", monto);
        Console.WriteLine("Te quedan {0:C2} en tu cuenta.", saldo);
      } else { Console.WriteLine("No se pudo retirar dinero!"); }
    } // Fin de sacar dinero de la cuenta

    public void DepositoInteresMes() {
      double descuento = 15;

      saldo -= descuento;
      Console.WriteLine("Se te descontaron {0:C2} por depositar!", descuento);
    } // Fin de depositar con interés mensual
  } // Fin de clase CuentaBancaria
} // Fin de espacio de nombre