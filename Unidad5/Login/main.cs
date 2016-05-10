using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace EJERCICIO {
  class Programa {    
    static void Login(string u, string p) {
      string usuario = "luisito";
      string password = "123456";
      
      if (u == "" || p == "")
      { throw new CamposVacios(); }
      else if (u != usuario || p != password)
      { throw new LoginIncorrecto(); }
    } // Fom de otorgar o rechazar acceso
    
    static void Main() {
      Console.Clear();
      bool tienePermiso = true;
      
      Console.WriteLine("Introduce tu usuario y contraseña:");
      
      try {
        Login(Console.ReadLine(), Console.ReadLine());
      } catch(LoginIncorrecto err) {
        Console.WriteLine(err.Message);
        tienePermiso = false;
      } catch(CamposVacios err) {
        Console.WriteLine(err.Message);
        tienePermiso = false;
      } finally {
        if (tienePermiso) {
          Console.WriteLine("Acceso concedido");
        } else { Console.WriteLine("DENEGADO!"); }
      } // Fin de atrapar error
      
      Login(Console.ReadLine(), Console.ReadLine());
      
      Console.ReadKey();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre