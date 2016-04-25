using System;

namespace Zoologico {
  class Mamifero : Animal {
    public Mamifero():base() {}
    public Mamifero(string e, string n, double p, int j)
    :base(e, n, p, j) {}
    
    public override void queClaseDeAnimalEres() {
      base.queClaseDeAnimalEres();
      Console.WriteLine("Este {0} es un mamífero!", Especie);
    } // Fin de ver qué clase de animal es
  } // Fin de clase Mamifero
  
  class Ave : Animal {
    string colorPlumaje;
    double alturaMaximaVuelo;
    
    public string Plumaje {
      get { return colorPlumaje;  }
      set { colorPlumaje = value; }
    } public double AlturaMaxima {
      get { return alturaMaximaVuelo;  }
      set { alturaMaximaVuelo = value; }
    } // Fin de getters y setters
    
    public Ave():base() {}
    public Ave(
      string e, string n, double p, int j,
      string plumaje, double vuelo
    ):base(e, n, p, j) {
      colorPlumaje = plumaje;
      alturaMaximaVuelo = vuelo;
    } // Fin de constructore sobrecargado
    
    public override void queClaseDeAnimalEres() {
      base.queClaseDeAnimalEres();
      Console.WriteLine("Esta ave tiene las plumas color {0}",
        colorPlumaje);
      Console.WriteLine("Su altura máxima de vuelo es de {0}m",
        alturaMaximaVuelo);
    } // Fin de ver qué clase de animal es
  } // Fin de clase Ave
  
  class Insecto : Animal {
    bool vuela;
    
    public bool Vuela {
      get { return vuela;  }
      set { vuela = value; }
    } // Fin de getters y setters
    
    public Insecto():base() {}
    public Insecto(
      string e, string n, double p, int j,
      bool vuela
    ):base(e, n, p, j) {
      this.vuela = vuela;
    } // Fin de constructore sobrecargado
    
    public override void queClaseDeAnimalEres() {
      base.queClaseDeAnimalEres();
      Console.WriteLine("Este insecto vuela? {0}", vuela);
    } // Fin de ver qué clase de animal es
  } // Fin de clase Insecto
} // Fin de Zoologico