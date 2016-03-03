using System;

namespace U3L2 {
  class Vehiculo {
    string matricula, marca, modelo, tipo;
    float precioDia;
    int dias;

    public string Matricula     {
      get { return matricula;  }
      set { matricula = value; }
    } public string Marca       {
      get { return marca;      }
      set { marca = value;     }
    } public string Modelo      {
      get { return modelo;     }
      set { modelo = value;    }
    } public string Tipo        {
      get { return tipo;       }
      set { tipo = value;      }
    } public float PrecioDiario {
      get { return precioDia;  }
      set { precioDia = value; }
    } public int Dias           {
      get { return dias;       }
      set { dias = value;      }
    } // Fin de getters y setters

    public Vehiculo() {}
    public Vehiculo(
      string mat, string mar, string m, string t, float p, int d
    ) { // Recibir los parámetros del constructor
      matricula = mat;
      marca     = mar;
      modelo    = m;
      tipo      = t;
      precioDia = p;
      dias      = d;
    } // Fin de constructor sobrecargado

    public float CalcularRenta() {
      VerificaTipo();
      return precioDia * dias;
    } // Fin ver cuánto cuesta rentar x día

    public void VerificaTipo() {
      if (tipo.ToLower() != "sedán" && tipo.ToLower() != "sedan")
      { precioDia += (precioDia * 0.1f); }
    } // Fin de verificar tipo de vehículo

    public void Imprimir() {
      Console.WriteLine("========================");
      Console.WriteLine("Matrícula: {0}.", matricula);
      Console.WriteLine("Marca: {0}.", marca);
      Console.WriteLine("Modelo: {0}", modelo);
      Console.WriteLine("Tipo: {0}", tipo);
      Console.WriteLine("------------------------");
      Console.WriteLine("Dias rentados: {0}.", dias);
      Console.WriteLine("Renta Diaria: {0:C2}", CalcularRenta());
    } // Fin de imprimir datos del vehículo
  } // Fin de clase Vehiculo
} // Fin de espacio de nombre