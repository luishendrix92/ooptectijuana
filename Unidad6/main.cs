using System;
using System.Text;
using System.IO;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// Compilación en MONO Develop:
// -----> dmcs -out:binario.exe -r:System.Windows.Forms.dll -r:System.Drawing.dll *.cs
// Compilación en CSC (.NET):
// -----> csc /out:binario.exe  *.cs

namespace ArchivosBinarios {
  public class VentanaPrincipal : Form {
    Label ruta, volcado, analizado, pregunta, divisor;
    Button btnExplorar, btnLeer, btnBorrar, btnLeerReg, btnNuevoReg;
    TextBox volcadoHexadecimal, textoAnalizado, rutaAbsoluta;
    RadioButton ASCII_Opn, UTF8_Opn, Unicode;
    byte[] bytesLeidos;
    char[] charsLeidos;
    string textoBuffer;

    // ===========================================================
    // CONSTRUCTOR QUE CREA Y DIBUJA LOS ELEMENTOS DEL FORM
    // ===========================================================
    public VentanaPrincipal() { // Constructor
      // CONTROLES DE VENTANA PRINCIPAL
      // --------------------------------------------
      ruta          = new Label();
      ruta.Size     = new Size(97, 20);
      ruta.Location = new Point(12, 11);
      ruta.Text     = "Ruta del archivo";
      this.Controls.Add(ruta);
      // --------------------------------------------
      volcado          = new Label();
      volcado.Size     = new Size(128, 20);
      volcado.Location = new Point(11, 53);
      volcado.Text     = "Volcado Hexadecimal";
      this.Controls.Add(volcado);
      // --------------------------------------------
      analizado          = new Label();
      analizado.Size     = new Size(98, 20);
      analizado.Location = new Point(291, 54);
      analizado.Text     = "Texto Analizado";
      this.Controls.Add(analizado);
      // --------------------------------------------
      pregunta          = new Label();
      pregunta.Size     = new Size(270, 20);
      pregunta.Location = new Point(11, 312);
      pregunta.Text     = "¿Qué codificación de caracteres deseas usar?";
      this.Controls.Add(pregunta);
      // --------------------------------------------
      rutaAbsoluta          = new TextBox();
      rutaAbsoluta.Size     = new Size(250, 22);
      rutaAbsoluta.Location = new Point(118, 9);
      this.Controls.Add(rutaAbsoluta);
      // --------------------------------------------
      volcadoHexadecimal            = new TextBox();
      volcadoHexadecimal.Size       = new Size(277, 221);
      volcadoHexadecimal.Location   = new Point(10, 81);
      volcadoHexadecimal.Multiline  = true;
      volcadoHexadecimal.ReadOnly   = true;
      volcadoHexadecimal.ScrollBars = ScrollBars.Vertical;
      volcadoHexadecimal.BackColor  = System.Drawing.SystemColors.Window;
      this.Controls.Add(volcadoHexadecimal);
      // --------------------------------------------
      textoAnalizado            = new TextBox();
      textoAnalizado.Size       = new Size(264, 221);
      textoAnalizado.Location   = new Point(286, 81);
      textoAnalizado.Multiline  = true;
      textoAnalizado.ReadOnly   = true;
      textoAnalizado.ScrollBars = ScrollBars.Vertical;
      textoAnalizado.BackColor  = System.Drawing.SystemColors.Window;
      this.Controls.Add(textoAnalizado);
      // --------------------------------------------
      btnExplorar          = new Button();
      btnExplorar.Size     = new Size(81, 25);
      btnExplorar.Location = new Point(374, 7);
      btnExplorar.Text     = "Explorar";
      btnExplorar.Click   += new EventHandler(ExplorarClick);
      this.Controls.Add(btnExplorar);
      // --------------------------------------------
      btnLeer          = new Button();
      btnLeer.Size     = new Size(70, 25);
      btnLeer.Location = new Point(454, 7);
      btnLeer.Text     = "Leer";
      btnLeer.Click += new EventHandler(LeerArchivoClick);
      this.Controls.Add(btnLeer);
      // --------------------------------------------
      btnBorrar          = new Button();
      btnBorrar.Size     = new Size(133, 25);
      btnBorrar.Location = new Point(35, 364);
      btnBorrar.Text     = "Borrar Archivo";
      btnBorrar.Click += new EventHandler(BorrarArchivoClick);
      this.Controls.Add(btnBorrar);
      // --------------------------------------------
      btnLeerReg          = new Button();
      btnLeerReg.Size     = new Size(179, 25);
      btnLeerReg.Location = new Point(187, 364);
      btnLeerReg.Text     = "Leer o editar registros";
      btnLeerReg.Click += new EventHandler(VerEditarRegClick);
      this.Controls.Add(btnLeerReg);
      // --------------------------------------------
      btnNuevoReg          = new Button();
      btnNuevoReg.Size     = new Size(135, 25);
      btnNuevoReg.Location = new Point(384, 364);
      btnNuevoReg.Text     = "Escribir registro";
      btnNuevoReg.Click += new EventHandler(CrearRegistroClick);
      this.Controls.Add(btnNuevoReg);
      // --------------------------------------------
      divisor             = new Label();
      divisor.AutoSize    = false;
      divisor.Height      = 2;
      divisor.Width       = 540;
      divisor.BorderStyle = BorderStyle.Fixed3D;
      divisor.Location    = new Point(11, 339);
      this.Controls.Add(divisor);
      // --------------------------------------------
      ASCII_Opn = new RadioButton();
      UTF8_Opn  = new RadioButton();
      Unicode   = new RadioButton();
      ASCII_Opn.Size     = new Size(56, 24);
      ASCII_Opn.Location = new Point(299, 310);
      ASCII_Opn.Text     = "ASCII";
      ASCII_Opn.Checked  = true;
      ASCII_Opn.CheckedChanged += new EventHandler(CambioASCII);
      UTF8_Opn.Size      = new Size(59, 24);
      UTF8_Opn.Location  = new Point(374, 310);
      UTF8_Opn.Text      = "UTF-8";
      UTF8_Opn.CheckedChanged += new EventHandler(CambioUTF8);
      Unicode.Size       = new Size(69, 24);
      Unicode.Location   = new Point(454, 310);
      Unicode.Text       = "Unicode";
      Unicode.CheckedChanged += new EventHandler(CambioUnicode);
      this.Controls.Add(ASCII_Opn);
      this.Controls.Add(UTF8_Opn);
      this.Controls.Add(Unicode);
      // ------------------------------------------->
      this.Text = "POO Unidad 6 - Archivos Binarios";
      this.Size = new Size(566, 463);
      this.Icon = new Icon("icono.ico");
    } // Fin de constructor de controles para la ventana principal



    // ===========================================================
    // MÉTODO PRINCIPAL QUE SE EJECUTA AL CARGAR EL PROGRAMA
    // -----------------------------------------------------------
    // [STAThread] significa que se usará sólo un hilo para evitar
    // conflictos con Windows.Forms, no soporta el multi-threading
    // =========================================================== 
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new VentanaPrincipal());
    } // Fin de método principa al correr programa



    // ===========================================================
    // MÉTODOS PARA MANEJAR LOS BOTONES DE OPCIÓN
    // -----------------------------------------------------------
    // Cambian la codificación del cuadro de texto analizado de
    // acuerdo a la codificación de caracteres que se decida.
    // ===========================================================
    private void CambioASCII(object sender, EventArgs e) {
      RadioButton btn = sender as RadioButton;

      if (btn.Checked) {
        try {
          textoBuffer = Encoding.ASCII.GetString(bytesLeidos);
        } catch(System.ArgumentNullException)
        { MessageBox.Show("No hay nada qué leer aún."); }
        
        textoAnalizado.Text = textoBuffer;
      } // Fin de ver si se marcó
    } // Fin de controlar evento de selección ASCII
    
    private void CambioUTF8(object sender, EventArgs e) {
      RadioButton btn = sender as RadioButton;

      if (btn.Checked) {
        try {
          textoBuffer = Encoding.UTF8.GetString(bytesLeidos);
        } catch(System.ArgumentNullException)
        { MessageBox.Show("No hay nada qué leer aún."); }
        
        textoAnalizado.Text = textoBuffer;
      } // Fin de ver si se marcó
    } // Fin de controlar evento de selección UTF-8
    
    private void CambioUnicode(object sender, EventArgs e) {
      RadioButton btn = sender as RadioButton;

      if (btn.Checked) {
        try {
          textoBuffer = Encoding.Unicode.GetString(bytesLeidos);
        } catch(System.ArgumentNullException)
        { MessageBox.Show("No hay nada qué leer aún."); }
        
        textoAnalizado.Text = textoBuffer;
      } // Fin de ver si se marcó
    } // Fin de controlar evento de selección Unicode
    
    
    
    // ===========================================================
    // MANEJADORES DE EVENTO PARA LOS BOTONES EXPLORAR Y LEER
    // =========================================================== 
    private void ExplorarClick(object sender, EventArgs e) {
      var DialogoArchivos = new OpenFileDialog();
      
      if (DialogoArchivos.ShowDialog() == DialogResult.OK) {
        rutaAbsoluta.Text = DialogoArchivos.FileName;
      } // Fin de comprobación de resultado positivo
    } // Fin de evento para botón de explorar en busca de archivos
    
    private void LeerArchivoClick(object sender, EventArgs e) {
      string volcadoLeido = "";
      
      bytesLeidos = IOBinario.LeerArchivo(rutaAbsoluta.Text);
      
      if (ASCII_Opn.Checked)
      { charsLeidos = Encoding.ASCII.GetString(bytesLeidos).ToCharArray();   }
      else if (UTF8_Opn.Checked)
      { charsLeidos = Encoding.UTF8.GetString(bytesLeidos).ToCharArray();    }
      else if (Unicode.Checked)
      { charsLeidos = Encoding.Unicode.GetString(bytesLeidos).ToCharArray(); }
      
      // Depositar el volcado hexadecimal en la caja de texto
      foreach (byte byteLeido in bytesLeidos) {
        volcadoLeido += (byteLeido.ToString("X2") + " ");
      } // Fin de leer arreglo de bytes
      
      textoBuffer             = new string(charsLeidos);
      volcadoHexadecimal.Text = volcadoLeido;
      textoAnalizado.Text     = textoBuffer;
    } // Fin de cargar los buffers de bytes y texto en memoria



    // ===========================================================
    // SUCESOS DEL EVENTO PARA BORRAR EL ARCHIVO ACTUAL
    // ===========================================================
    private void BorrarArchivoClick(object sender, EventArgs e) {
      string ruta         = rutaAbsoluta.Text;
      bool archivoBorrado = IOBinario.BorrarArchivo(ruta);
      
      if (archivoBorrado) {
        MessageBox.Show("Archivo borrado con éxito!");
        
        // Resetear los cuadros de texto
        volcadoHexadecimal.Text = "";
        rutaAbsoluta.Text       = "";
        textoAnalizado.Text     = "";
      } else {
        MessageBox.Show(
          "El archivo que querías borrar no existe.",
          "Error de directorio",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error,
          MessageBoxDefaultButton.Button1
        ); // Fin de mostrar error de archivo inexistente
      } // Fin de ver si en verdad fue borrado
    } // Fin de borrar el archivo del sistema
    
    
    
    // ===========================================================
    // BOTONES PARA LANZAR LAS OTRAS DOS VENTANAS
    // ===========================================================
    private void CrearRegistroClick(object sender, EventArgs e) {
      Form ventana = new VentanaRegNuevo(rutaAbsoluta.Text);
      ventana.Show();
    } // Fin de lanzar el form que se encarga de insertar objetos
    
    private void VerEditarRegClick(object sender, EventArgs e) {
      Form ventana = new VentanaVMRegs(rutaAbsoluta.Text);
      ventana.Show();
    } // Fin de lanzar el form para ver y modificar registros
  } // Fin de clase definida para el formulario principal
} // Fin de espacio de nombre