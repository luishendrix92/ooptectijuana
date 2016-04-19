using System;

namespace Escritura {
  class Teclado : IMaqEscribir {
    string marca;
    int numTeclas;

    public string Marca {
      get { return marca;  }
      set { marca = value; }
    } public int NumTeclas {
      get { return numTeclas;  }
      set { numTeclas = value; }
    } // Fin de getters y setters

    public Teclado() {}
    public Teclado(string m, int n) {
      marca = m; numTeclas = n;
    } // Fin de constructor sobrecargado

    public void Teclazo() {
      ConsoleKeyInfo tecla;

      // Prevenir que se termine el programa con CTRL+C
      // Console.TreatControlCAsInput = true;

      do { // Detectar teclas mientras no sea ESC
        tecla = Console.ReadKey(true);

        if ((tecla.Modifiers & ConsoleModifiers.Alt) != 0) {
          Alt(); // Ejecutar método correspondiente
        } else if ((tecla.Modifiers & ConsoleModifiers.Control) != 0) {
          Ctrl(); // Ejecutar método correspondiente
        } // Fin de manejar teclas modificadoras...

        switch (tecla.Key.ToString()) {
          case "PageUp"  : RePag(); break;
          case "PageDown": AvPag(); break;
          default: // Sin métodos...
            Console.Write("Presioné la tecla: ");
            Console.Write(tecla.Key + "\n");
            break;
        } // Fin de detectar ciertas teclas
      } while (tecla.Key != ConsoleKey.Escape);
    } // Fin de implementación

    public void Ctrl() {
      Console.WriteLine("Tecla Ctrl presionada, se ejecuta el método!!");
    } // Fin de método para ejecutar método en cierta tecla

    public void Alt() {
      Console.WriteLine("Tecla Alt presionada, se ejecuta el método!!");
    } // Fin de método para ejecutar método en cierta tecla

    public void RePag() {
      Console.WriteLine("Tecla RePag presionada, se ejecuta el método!!");
    } // Fin de método para ejecutar método en cierta tecla

    public void AvPag() {
      Console.WriteLine("Tecla AvPag presionada, se ejecuta el método!!");
    } // Fin de método para ejecutar método en cierta tecla
  } // Fin de clase Teclado
} // Fin de espacio de nombre