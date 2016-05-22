using System.Collections.Generic;
using System;

namespace DiasDelMes {
  public enum MesNombre {
    Enero, Febrero, Marzo, Abril,
    Mayo, Junio, Julio, Agosto,
    Septiembre, Octubre, Noviembre, Diciembre
  } // Fin de enumeración pública
  
  class WhatDay {
    static void Main(string[] argumentosDeConsola) {
      Console.Clear();
      
      int[] DiasMes = {
        31, 29, 31, 30, 31, 30, 31, 30, 30, 31, 30, 31
      }; // Fin de días que tiene cada mes
      int mesNum = 0, diaNum = 0;
      
      try {
        diaNum = int.Parse(argumentosDeConsola[0]);
        
        if (diaNum < 0 || diaNum > 365)
        { throw new OverflowException(); }
      } catch(FormatException) {
        Console.WriteLine("Escribe un número por favor!");
      } catch(IndexOutOfRangeException) {
        Console.WriteLine("Escribe un número en los argumentos!");
      } catch(OverflowException) {
        Console.WriteLine("No escribiste un número válido...");
        Console.WriteLine("Debe estar entre 0 y 365.");
      } // Fin de capturar errores
      
      foreach (int diasEnMes in DiasMes) {
        if (diaNum <= diasEnMes) { break; }
        else { diaNum -= diasEnMes; mesNum++; }
      } // Fin de iterar los días de cada mes
      
      MesNombre temp = (MesNombre)mesNum;
      string mesNombre = temp.ToString();
      Console.WriteLine(mesNombre);
      
      Console.ReadKey();
    } // Fin de Método Principal
  } // Fin de clase WhatDay
} // Fin de espacio de nombre