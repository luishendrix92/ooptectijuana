using System;
using System.Collections.Generic;
using System.Globalization;

namespace InterfacesClase2 {
  class CCuenta : IFecha {
    int noCta;
    string tipoCta;
    DateTime fechaApertura;
    float saldo;

    public int NoCta {
      get { return noCta;  }
      set { noCta = value; }
    } public string TipoCta {
      get { return tipoCta;  }
      set { tipoCta = value; }
    } public DateTime FechaApertura {
      get { return fechaApertura;  }
      set { fechaApertura = value; }
    } public float Saldo {
      get { return saldo;  }
      set { saldo = value; }
    } // Fin de getters y setters

    public CCuenta() {}
    public CCuenta(int n, string t, DateTime f, float s) {
      noCta = n; tipoCta = t; fechaApertura = f; saldo = s;
    } // Fin de constructor sobrecargado

    public float Balance() { return saldo; }

    public int dia() {
      return fechaApertura.Day;
    } // Fin de implementación

    public int mes() {
      return fechaApertura.Month;
    } // Fin de implementación

    public int año() {
      return fechaApertura.Year;
    } // Fin de implementación

    public string NombreMes() {
      DateTimeFormatInfo formatoFecha = CultureInfo
        .CreateSpecificCulture("es-MX")
        .DateTimeFormat;
      string nombreMes = formatoFecha.GetMonthName(mes());

      return nombreMes;
    } // Fin de convertir a letras el mes
  } // Fin de clase CCuenta
} // Fin de espacio de nombre