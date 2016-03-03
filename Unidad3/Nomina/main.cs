using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Nomina {
  class Programa {
    public static void Main() {
      Console.Clear();

      Empleado yo = new Empleado(
        "Luis Felipe", 34123, 1400.54f
      ); // Fin de instanciar objeto

      // Cálculo de deducciones y percepciones
      int   diasTrab   = 5                                  ;
      float bonos      = yo.Bono(diasTrab)                  ;
      float sdoSemanal = yo.SdoSem(diasTrab)                ;
      float impuestoSR = yo.ISR(diasTrab)                   ;
      float segSocial  = yo.IMSS(diasTrab)                  ;
      float sdoHora    = yo.SueldoHora()                    ;
      float totalPerc  = yo.Percepcion(diasTrab)            ;
      float totalDeduc = yo.Deduccion(impuestoSR,segSocial) ;
      float sdoAPagar  = yo.SueldoNeto(totalPerc,totalDeduc);

      // Mostrar propiedades
      Console.WriteLine("Datos del empleado:")                ;
      Console.WriteLine("===========================")        ;
      Console.WriteLine("Nombre: {0}", yo.Nombre)             ;
      Console.WriteLine("No. Empleado: {0}", yo.NumEmpleado)  ;
      Console.WriteLine("Sueldo Diario: {0}", yo.SueldoDiario);
      Console.WriteLine("Sueldo x Hora: {0:C2}", sdoHora)     ;

      // Mostrar recibo de pago
      Console.WriteLine("\nRecibo de pago:")                 ;
      Console.WriteLine("===========================")       ;
      Console.WriteLine("Percepciones ->")                   ;
      Console.WriteLine("---------------------------")       ;
      Console.WriteLine("Sueldo Semanal: {0:C2}", sdoSemanal);
      Console.WriteLine("Bono: {0:C2}", bonos)               ;
      Console.WriteLine("\tTOTAL: {0:C2}", totalPerc)        ;
      Console.WriteLine("---------------------------")       ;
      Console.WriteLine("Deducciones ->")                    ;
      Console.WriteLine("---------------------------")       ;
      Console.WriteLine("ISR: {0:C2}", impuestoSR)           ;
      Console.WriteLine("IMSS: {0:C2}", segSocial)           ;
      Console.WriteLine("\tTOTAL: {0:C2}", totalDeduc)       ;
      Console.WriteLine("---------------------------")       ;
      Console.WriteLine("Sueldo a pagar: {0:C2}", sdoAPagar) ;
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre