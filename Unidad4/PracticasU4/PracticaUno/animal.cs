using System;

namespace Zoologico {
  abstract class Animal {
    string especie, nombre;
    double peso;
    int jaula;
    
    public string Especie {
      get { return especie;  }
      set { especie = value; }
    } public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public double Peso { // KG
      get { return peso;  }
      set { peso = value; }
    } public int Jaula { // Número
      get { return jaula;  }
      set { jaula = value; }
    } // Fin de getters y setters
    
    public Animal() {}
    public Animal(string e, string n, double p, int j) {
      especie = e; nombre = n; peso = p; jaula = j;
    } // Fin de constructor sobrecargado
    
    public virtual void queClaseDeAnimalEres() {
      Console.WriteLine("==================================");
      Console.WriteLine("Especie de animal: {0}", especie);
      Console.WriteLine("Se llama {0}", nombre);
      Console.WriteLine("Pesa {0} kilogramos", peso);
      Console.WriteLine("Se encuentra en la jaula #{0}", jaula);
    } // Fin de método virtual de clase base abstracta
  } // Fin de clase Animal
} // Fin de Zoologico