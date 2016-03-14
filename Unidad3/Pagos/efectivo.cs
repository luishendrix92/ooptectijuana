using System;

namespace Pagos {
  class Efectivo : Pago {
    float cantEfvo;

    public float CantidadEfectivo {
      get { return cantEfvo;  }
      set { cantEfvo = value; }
    } // Fin de getters y setters

    public Efectivo():base() {
      cantEfvo = 0;
    } public Efectivo(float cant, float efvo)
    :base(cant) {
      cantEfvo = efvo;
    } public Efectivo(string m, DateTime f, float c, float e)
    :base(m, f, c) {
      cantEfvo = e;
    } public Efectivo(string m, float c, float e)
    :base(m, c) {
      cantEfvo = e;
    } public Efectivo(DateTime f, float c, float e)
    :base(f, c) {
      cantEfvo = e;
    } public Efectivo(string m, DateTime f, float e)
    :base(m, f) {
      cantEfvo = e;
    } // Fin de constructores sobrecargados

    public float CalcularCambio() {
      return cantEfvo - this.Cantidad;
    } // Fin de ver cuánto regresar de cambio
  } // Fin de clase Efectivo
} // Fin de espacio de nombre