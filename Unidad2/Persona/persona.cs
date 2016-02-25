using System.Globalization;
using System;

namespace FechaYTiempo {
  class Persona {
    string nombre;
    DateTime fechaDeNacimiento;

    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public DateTime Nacimiento {
      get { return fechaDeNacimiento;  }
      set { fechaDeNacimiento = value; }
    } // Fin de getters y setters

    public Persona() {
      nombre = "Fulanito Perez Mengano";
      fechaDeNacimiento = new DateTime(1990, 01, 01);
    } public Persona(string nom, DateTime feNac) {
      nombre = nom;
      fechaDeNacimiento = feNac;
    } // Fin de constructor sobrecargado

    public int cumplidos() {
      DateTime hoy    = DateTime.Today;
      DateTime cumple = new DateTime(hoy.Year,
        fechaDeNacimiento.Month, fechaDeNacimiento.Day
      ); // Fin de obtener cumpleaños de este año

      if (hoy.DayOfYear < cumple.DayOfYear) {
        return (hoy.Year - fechaDeNacimiento.Year) - 1;
      } else { // Se tiene la edad resultante
        return hoy.Year - fechaDeNacimiento.Year;
      } // Fin de comprobar si aún no cumple años
    } // Fin de método para regresar años cumplidos

    public int paraMayoriaEdad() {
      int mayoriaEdad = 18;
      int faltantes   = mayoriaEdad - cumplidos();

      return (faltantes < 0)? 0 : faltantes;
    } // Fin de calcular conteo hacia mayoría de edad

    public int mesesDeVida() {
      return cumplidos() * 12;
    } // Fin de calcular meses de vida

    public string nombreMesNacimiento() {
      return CultureInfo // Información Regional
            .CurrentCulture // La de aquí (es-MX)
            .DateTimeFormat // Formato de fecha
            .GetMonthName(fechaDeNacimiento.Month);
    } // Fin de regresar el nombre del mes de nacimiento

    public string mesParOImpar() {
      int mes = fechaDeNacimiento.Month;

      return (mes % 2 == 0)? "par" : "impar";
    } // Fin de ver si el mes de nacimiento es par/impar
  } // Fin de clase Persona
} // Fin de namespace