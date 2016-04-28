using System;

namespace PracticaTres {
  abstract class CuentaBancaria {
    int numero;
    string titular;
    double saldo, interes;

    public int Numero {
      get { return numero;  }
      set { numero = value; }
    } public string Titular {
      get { return titular;  }
      set { titular = value; }
    } public double Saldo {
      get { return saldo;  }
      set { saldo = value; }
    } public double Interes {
      get { return interes;  }
      set { interes = value; }
    } // Fin de getters y setters

    public CuentaBancaria() {}
    public CuentaBancaria(int n, string t, double s, double i) {
      numero = n; titular = t; saldo = s; interes = i;
    } // Fin de constructor sobrecargado

    public void Deposito(double monto) {
      saldo += monto;
      Console.WriteLine("Depósito de {0:C2} pesos realizado.", monto);
      DepositoInteresMes();
      Console.WriteLine("Te quedan {0:C2} en tu cuenta.", saldo);
    } // Fin de depositar dinero

    abstract public void DepositoInteresMes();
  } // Fin de clase CuentaBancaria
} // Fin de espacio de nombre