using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// MONO: dmcs -r:System.Windows.Forms.dll -r:System.Drawing.dll main.cs

public class Ventana : Form {
  public Button boton;
  public TextBox caja;
  public Label etiqueta;

  public Ventana() {
    // CONTROLES DE VENTANA
    boton = new Button();
    boton.Size = new Size(40, 40);
    boton.Location = new Point(30, 30);
    boton.Text = "Ver Porno";
    this.Controls.Add(boton);
    boton.Click += new EventHandler(boton_Click);
    // --------------------------------
    caja = new TextBox();
    caja.Size = new Size(100, 30);
    caja.Location = new Point(30, 0);
    caja.Text = "De quién?";
    this.Controls.Add(caja);
    // --------------------------------
    etiqueta = new Label();
    etiqueta.Size = new Size(150, 15);
    etiqueta.Location = new Point(30, 70);
    etiqueta.Text = "Puta madre";
    this.Controls.Add(etiqueta);
    // --------------------------------
    this.Text = "PORNOMAX 2000";
  }

  [STAThread]
  public static void Main() {
    Application.EnableVisualStyles();
    Application.Run(new Ventana());
  }

  private void boton_Click(object sender, EventArgs e) {
    Form nuevaVentana = new Ventana2(caja.Text);
    
    nuevaVentana.Show();
  }
}

public class Ventana2 : Form {
  public TextBox texto;

  public Ventana2(string quien) {
    // CONTROLES DE VENTANA
    texto = new TextBox();
    texto.Size = new Size(500, 300);
    texto.Multiline = true;
    texto.Location = new Point(0, 0);
    texto.Text = "EL VIDE PORNO DE " + quien + "!!!";
    this.Controls.Add(texto);
    // --------------------------------
    this.Text = "El video porno";
  }
}