using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Ventana : Form {
  public Button boton;
  public TextBox caja;

  public Ventana()
  {
    // CONTROLES DE VENTANA
    boton = new Button();
    boton.Size = new Size(40, 40);
    boton.Location = new Point(30, 25);
    boton.Text = "Dame Click";
    this.Controls.Add(boton);
    boton.Click += new EventHandler(boton_Click);
    // --------------------------------
    caja = new TextBox();
    caja.Size = new Size(100, 30);
    caja.Location = new Point(30, 0);
    caja.Text = "Dame Click";
    this.Controls.Add(caja);
    // --------------------------------
    this.Text = "Mi primer programa";
  }

  [STAThread]
  public static void Main() {
    Application.EnableVisualStyles();
    Application.Run(new Ventana());
  }

  private void boton_Click(object sender, EventArgs e)
  {
    MessageBox.Show(caja.Text);
    Application.Run(new Ventana2());
  }
}

public class Ventana2 : Form {
  public TextBox caja;

  public Ventana2()
  {
    // CONTROLES DE VENTANA
    caja = new TextBox();
    caja.Size = new Size(100, 30);
    caja.Location = new Point(30, 0);
    caja.Text = "Fuck you";
    this.Controls.Add(caja);
    // --------------------------------
    this.Text = "Mi ventana secundaria";
  }
}