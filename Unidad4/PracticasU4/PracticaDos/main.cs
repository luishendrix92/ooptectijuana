using System.Collections.Generic;
using System;

namespace AsociacionMusical {
  class GestionaAsoc {
    static void Main(string[] args) {
      Console.Clear();
      
      // INICIA EL PROGRAMA =====>
      Asociacion uematsu = new Asociacion("UEMATSU");
      
      uematsu.NuevoMiembro(
        new Coralista("Luis Felipe", 3)
      ); // Fin de nuevo coralista en la asociación
      uematsu.NuevoMiembro(
        new Instrumentalista("Jimi Hendrix", "Guitarra")
      ); // Fin de nuevo guitarrista en la orquesta
      uematsu.NuevoMiembro(
        new Coralista("Hiruko Fugaku", 1)
      ); // Fin de nuevo corista en la asociación
      uematsu.NuevoMiembro(
        new Coralista("Jack Nicholson", 0)
      ); // Fin de nuevo corista en la asociación
      
      uematsu.ImprimirDatos();
      
      Console.WriteLine("Presione una tecla para continuar...");
      // <==== TERMINA EL PROGRAMA
      
      Console.ReadKey();
    } // Fin de Método Main
  } // Fin de clase GestionaAsoc
  
  class Asociacion {
    string nombre;
    int numMiembrosCoro, numMiembrosOrquesta;
    List<Musico> musicos = new List<Musico>();
    
    public int NumCoro {
      get { return numMiembrosCoro;  }
      set { numMiembrosCoro = value; }
    } public int NumOrquesta {
      get { return numMiembrosOrquesta;  }
      set { numMiembrosOrquesta = value; }
    } // Fin de getters y setters
    
    public Asociacion() {
      numMiembrosOrquesta = 0;
      numMiembrosCoro = 0;
    } public Asociacion(string nombre) {
      this.nombre = nombre;
      numMiembrosOrquesta = 0;
      numMiembrosCoro = 0;
    } // Fin de constructore sobrecargado
    
    public void NuevoMiembro(Musico musico) {
      musicos.Add(musico);
      if (musico.yTuCantas()) {
        numMiembrosCoro++;
      } else { numMiembrosOrquesta++; }
    } // Fin de añadir miembro a la asociación
    
    public void ImprimirDatos() {
      Console.WriteLine("ASOCIACIÓN MUSICAL {0}",
        nombre.ToUpper());
        Console.WriteLine("===================================");
      Console.WriteLine("Tenemos {0} integrante(s) de orquesta.",
        numMiembrosOrquesta);
      Console.WriteLine("También contamos con {0} corista(s)!",
        numMiembrosCoro);
      Console.WriteLine("\tLista de miembros =>\n");
      
      foreach (Musico musico in musicos) {
        musico.ImprimirDatos();
        System.Threading.Thread.Sleep(2000);
      } // Fin de pasar lista
    } // Fin de mostrar datos de la asociación
  } // Fin de clase Asociacion
} // Fin de espacio de nombre