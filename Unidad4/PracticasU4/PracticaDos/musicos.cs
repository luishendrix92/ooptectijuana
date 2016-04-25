using System;

namespace AsociacionMusical {
  class Coralista : Musico, IIdentificable {
    int tipoDeVoz;
    
    public int TipoVoz {
      get { return tipoDeVoz;  }
      set { // Comprobar si voz está en el rango
        if (value >= 0 && value <= 3)
        { tipoDeVoz = value; }
        else { tipoDeVoz = 0; } // Soprano por defecto
      } // Fin de establecer voz
    } // Fin de getters y setters
    
    public Coralista():base() {}
    public Coralista(string nombre, int t)
    :base(nombre) {
      if (t >= 0 && t <= 3) { tipoDeVoz = t; }
      else { tipoDeVoz = 0; } // Soprano por defecto
    } // Fin de constructor sobrecargado
    
    static string DeterminarVoz(int numeroVoz) {
      string voz;
      
      switch (numeroVoz) {
        case 0:  voz = "soprano";     break;
        case 1:  voz = "contraalto";  break;
        case 2:  voz = "tenor";       break;
        case 3:  voz = "bajo";        break;
        default: voz = "desconocida"; break;
      } // Fin de elegir entre las opciones
      
      return voz;
    } // Fin de elegir entre voces
    
    public override void ImprimirDatos() {
      Console.WriteLine("Me llamo {0} y soy coralista!",
        ComoTeLlamas());
      Console.WriteLine("Mi tipo de voz es {0}",
        DeterminarVoz(tipoDeVoz));
      Console.WriteLine("-------------------------------------");
    } // Fin de implementación de imprimir datos
    
    public override bool yTuCantas() { return true; }
  } // Fin de clase Coralista
  
  class Instrumentalista : Musico, IIdentificable {
    string instrumento;
    
    public string Instrumento {
      get { return instrumento;  }
      set { instrumento = value; }
    } // Fin de getters y setters
    
    public Instrumentalista():base() {}
    public Instrumentalista(string nombre, string i)
    :base(nombre) { instrumento = i; }
    
    public override void ImprimirDatos() {
      Console.WriteLine("Me llamo {0} y soy instrumentalista!",
        ComoTeLlamas());
      Console.WriteLine("Toco el/la {0} muy bien", instrumento);
      Console.WriteLine("-------------------------------------");
    } // Fin de implementación de imprimir datos
    
    public override bool yTuCantas() { return false; }
  } // Fin de clase Instrumentalista
} // Fin de espacio de nombre