using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Nomina {
  class Empleado {
    static int diasDeTrab = 6   ;
    static float bonoPorc = 0.2f;
    static int hrsDeTrab  = 8   ;

    int noEmpleado;
    string nombre ;
    float sdoDia  ;

    public int NumEmpleado {
      get { return noEmpleado;  }
      set { noEmpleado = value; }
    } public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public float SueldoDiario {
      get { return sdoDia;  }
      set { sdoDia = value; }
    } // Fin de getters y setters

    public Empleado() {}
    public Empleado(string n, int nE, float sD) {
      nombre = n; noEmpleado = nE; sdoDia = sD;
    } // Fin de constructor sobrecargado

    public float SdoSem(int dias) {
      return diasDeTrab * sdoDia;
    } // Fin de calcular sueldo semanal

    public float Bono(int dias) {
      if (dias >= diasDeTrab) {
        return SdoSem(dias) * bonoPorc;
      } else { return 0; }
    } // Fin de bono de asistencia

    public float ISR(int dias) {
      float sueldoSem = SdoSem(dias);

      if (sueldoSem <= 3000) {
        return sueldoSem * 0.05f;
      } else { return sueldoSem * 0.1f; }
    } // Fin de impuesto sobre la renta

    public float IMSS(int dias) {
      float sueldoSem = SdoSem(dias);

      if (sueldoSem <= 3000) {
        return sueldoSem * 0.50f;
      } else { return sueldoSem * 0.08f; }
    } // Fin de descuento de seguro social

    public float SueldoHora() {
      return sdoDia / hrsDeTrab;
    } // Fin de calcular sueldo por hora

    public float Percepcion(int dias) {
      return SdoSem(dias) + Bono(dias);
    } // Fin de sueldo total antes de descuentos

    public float Deduccion(float isr, float imss) {
      return isr + imss;
    } // Fin de las deducciones al sueldo total

    public float SueldoNeto(float tp, float td) {
      return tp - td;
    } // Fin de sueldo pagado al empleado
  } // Fin de clase Empleado
} // Fin de espacio de nombre