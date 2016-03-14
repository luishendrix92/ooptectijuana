using System;

namespace Pagos {
  class Pago {
    string moneda;
    DateTime fecha;
    float cant;

    public string Moneda     {
      get { return moneda;  }
      set { moneda = value; }
    } public DateTime Fecha  {
      get { return fecha;   }
      set { fecha = value;  }
    } public float Cantidad  {
      get { return cant;    }
      set { cant = value;   }
    } // Fin de getters y setters

    public Pago() {
      fecha  = DateTime.Now;
      moneda = "pesos";
      cant   = 0;
    } public Pago(string m, DateTime f, float c) {
      moneda = m; fecha = f; cant = c;
    } public Pago(string m, float c) {
      fecha  = DateTime.Now;
      moneda = m; cant = c;
    } public Pago(DateTime f, float c) {
      fecha = f; cant = c; moneda = "pesos";
    } public Pago(string m, DateTime f) {
      moneda = m; fecha = f; cant = 0;
    } public Pago(float cant) {
      this.cant = cant;
    } // Fin de constructores sobrecargados
  } // Fin de clase Pago
} // Fin de espacio de nombre