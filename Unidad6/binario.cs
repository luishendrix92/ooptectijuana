using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ArchivosBinarios {
  class IOBinario {
    // ================================================================
    // LECTURA DE UN ARCHIVO PARA GUARDAR TODOS SUS BYTES
    // ================================================================
    public static byte[] LeerArchivo(string rutaDelArchivo) {
      // Bytes con las letras ASCII "ERROR"
      byte[] bytesLeidos = new byte[] { 0x45, 0x52, 0x52, 0x4F, 0x52 };
      
      if (File.Exists(rutaDelArchivo)) {
        try {
          BinaryReader reader = new BinaryReader(
            File.Open(rutaDelArchivo, FileMode.Open, FileAccess.Read)
          ); // Fin de crear un lector binario
          bytesLeidos = reader.ReadBytes(int.MaxValue);
          reader.Close();
        } catch(IOException e) {
          MessageBox.Show(e.Message);
        } catch(ObjectDisposedException e) {
          MessageBox.Show(e.Message);
        } // Fin de atrapar posibles errores al leer
      } else {
        MessageBox.Show(
          "El archivo que quieres leer no existe.",
          "Error de directorio",
          MessageBoxButtons.OK,
          MessageBoxIcon.Warning,
          MessageBoxDefaultButton.Button1
        ); // Fin de mostrar error
      } // Fin de ver si existe el archivo
      
      return bytesLeidos;
    } // Fin de método para regresar los bytes de un archivo
    
    
    
    // ==================================================
    // BORRAR UN ARCHIVO POR COMPLETO
    // ==================================================
    public static bool BorrarArchivo(string ruta) {
      if (File.Exists(ruta))
      { File.Delete(ruta); return true; }
      else { return false; }
    } // Fin de método para borrar un archivo del sistema
    
    
    
    // ===============================================================================
    // LEER OBJECTOS SERIALIZADOS DENTRO DE UN ARCHIVO BINARIO
    // ===============================================================================
    public static List<Persona> ObtenerRegistros(string ruta) {
      List<Persona> registros = new List<Persona>();
      BinaryReader br = null; // Declaración del flujo
      
      try { // Buscar errores de fin de stream
        if (File.Exists(ruta)) {
          br = new BinaryReader(new FileStream(ruta, FileMode.Open, FileAccess.Read));
          
          do { // DES-SERIALIZAR OBJETO
            registros.Add(
              new Persona(
                br.ReadString(), /* Nombre */
                br.ReadString(), /* Ocupación */
                br.ReadInt16(), /* Edad */
                br.ReadBoolean(), /* ¿Está vivo? */
                br.ReadSingle() /* Altura */
              ) /* Fin de crear un objeto Persona */
            ); // Fin de agregar a la persona
          } while (true); // Mientras no sea el fin del stream
        } else { // No existe el archivo
          MessageBox.Show(
            "El archivo que quieres leer no existe.",
            "Error de directorio",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1
          ); // Fin de mostrar error
        } // Fin de ver si existe o no el archivo
      } catch (EndOfStreamException) {} finally {
        if (br != null) br.Close();
      } // Fin de prevenir error al terminarse el stream
      
      return registros;
    } // Fin de obtener una lista de objetos de cierto modelo
    
    
    
    // ==============================================================================
    // ESCRIBIR O SOBREESCRIBIR UN OBJETO EN ARCHIVOS BINARIOS
    // ------------------------------------------------------------------------------
    // Regresa un booleano de confirmación para controlar qué pasa si no se inserta
    // ==============================================================================
    public static bool EscribirRegistro(string ruta, bool limpiar, Persona persona) {
      BinaryWriter bw       = null;
      bool insercionExitosa = false;
      
      try { // Buscar errores de lectura y escritura
        if (File.Exists(ruta)) {
          bw = new BinaryWriter(
            new FileStream(
              ruta, /* Archivo a escribir */
              ((limpiar)? FileMode.Create : FileMode.Append),
              FileAccess.Write
            ) /* Fin de creación de stream */
          ); // Fin de creación de lector binario
          
          // Insertando el modelo de datos en el stream
          bw.Write(persona.Nombre);    // String
          bw.Write(persona.Ocupacion); // String
          bw.Write(persona.Edad);      // Int16
          bw.Write(persona.EstaVivo);  // Boolean
          bw.Write(persona.Altura);    // Single
          
          insercionExitosa = true;
        } else { // No existe el archivo
          MessageBox.Show(
            "No existe el archivo para escribir!",
            "Error de directorio",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1
          ); // Fin de mostrar error
        } // Fin de ver si existe o no el archivo
      } catch (IOException e) {
        MessageBox.Show(e.Message);
      } finally { if (bw != null) bw.Close(); }
      
      return insercionExitosa;
    } // Fin de capturar error de lectura y escritura
    
    
    
    // =================================================================
    // REEMPLAZAR EL CONTENIDO DE UN ARCHIVO POR UNA LISTA DE OBJETOS
    // -----------------------------------------------------------------
    // Este método es igual que el de arriba sólo que para varios
    // registros y se sobreescribe todo el archivo con lo nuevo.
    // =================================================================
    public static bool Reescribir(string ruta, List<Persona> personas) {
      BinaryWriter bw     = null;
      bool procesoExitoso = false;
      
      try { // Buscar errores de lectura y escritura
        if (File.Exists(ruta)) {
          bw = new BinaryWriter(
            new FileStream(ruta, FileMode.Create, FileAccess.Write)
          ); // Fin de creación de lector binario
          
          // Insertando la lista de personas en el stream
          foreach (Persona persona in personas) {
            bw.Write(persona.Nombre);    // String
            bw.Write(persona.Ocupacion); // String
            bw.Write(persona.Edad);      // Int16
            bw.Write(persona.EstaVivo);  // Boolean
            bw.Write(persona.Altura);    // Single
          } // Fin de iterar la lista de personas
          
          procesoExitoso = true;
        } else { // No existe el archivo
          MessageBox.Show(
            "No existe el archivo para escribir!",
            "Error de directorio",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1
          ); // Fin de mostrar error
        } // Fin de ver si existe o no el archivo
      } catch (IOException e) {
        MessageBox.Show(e.Message);
      } finally { if (bw != null) bw.Close(); }
      
      return procesoExitoso;
    } // Fin de método para reescribir datos con una lista
  } // Fin de clase estática para leer y escribir en binario
} // Fin de espacio de nombre