using System;

namespace Pagos {
  class Credito : Pago {
    string noTarjeta;
    string titular;
    float saldo;

    public string Tarjeta      {
      get { return noTarjeta;  }
      set { noTarjeta = value; }
    } public string Titular {
      get { return titular;    }
      set { titular = value;   }
    } public float Saldo    {
      get { return saldo;      }
      set { saldo = value;     }
    } // Fin de getters y setters

    public Credito():base() {}
    public Credito(
      string m, DateTime f, float c,
      string n, string t, float s
    ):base(m, f, c) {
      noTarjeta = n; titular = t; saldo = s;
    } public Credito(
      string m, float c,
      string n, string t, float s
    ):base(m, c) {
      noTarjeta = n; titular = t; saldo = s;
    } public Credito(
      DateTime f, float c,
      string n, string t, float s
    ):base() {
      noTarjeta = n; titular = t; saldo = s;
    } public Credito(
      string m, DateTime f,
      string n, string t, float s
    ):base() {
      noTarjeta = n; titular = t; saldo = s;
    } public Credito(
      float cant,
      string n, string t, float s
    ):base() {
      noTarjeta = n; titular = t; saldo = s;
    } // Fin de constructores sobrecargados

    public void CargarSaldo(float monto) {
      this.saldo += monto;
      Console.WriteLine("Se agregaron {0:C2} a tu cuenta.", monto);
    } // Fin de agregar saldo a cuenta

    public float Balance() {
      return saldo - this.Cantidad;
    } // Fin de balance de la cuenta
  } // Fin de clase Credito
} // Fin de espacio de nombre