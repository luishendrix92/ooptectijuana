using System;

namespace FechaYTiempo {
  class Programa {
    public static void MostrarInfo(Persona persona) {
      Console.WriteLine("Te llamas: {0}.", persona.Nombre);
      Console.WriteLine("Naciste el: {0}.",
        persona.Nacimiento.ToLongDateString());
      Console.WriteLine("Hora de nacimiento: {0}",
        persona.Nacimiento.ToString("h:mm:ss tt"));
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Hasta la fecha llevas {0} años cumplidos.",
        persona.cumplidos());
      Console.WriteLine("Faltan {0} años para tu mayoría de edad.",
        persona.paraMayoriaEdad());
      Console.WriteLine("Tu edad es equivalente a {0} meses!",
        persona.mesesDeVida());
      Console.WriteLine("Naciste el mes de {0}.",
        persona.nombreMesNacimiento());
      Console.WriteLine("El número del mes que naciste es {0}.\n\n",
        persona.mesParOImpar());
    } // Fin de imprimir carta de detalles

    public static void Main() {
      Console.Clear();
      Persona yo = new Persona(
        "Luis Felipe López Garay",
        new DateTime(1992, 4, 9, 2, 49, 03)
      ); // Fin de instanciación
      Persona unAmigo = new Persona(
        "Rosado De La Colina",
        new DateTime(2001, 1, 23, 15, 59, 38)
      ); // Fin de instanciación

      MostrarInfo(yo);
      MostrarInfo(unAmigo);
    } // Fin de Método Main
  } // Fin de clase Principal
} // Fin de namespace

/* NOTAS EN LABORATORIO
----------------------------------------
public enum MesNombre {
  Meses, Enero, Febrero,
  Marzo, Mayo, Junio,
  Julio, Agosto, Septiembre,
  Octubre, Noviembre, Diciembre
} // Fin de enumeración pública
--------------------------------------*/