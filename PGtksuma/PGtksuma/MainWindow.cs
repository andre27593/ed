using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		Decimal Numero1 = Decimal.Parse (entry4.Text); //Un numero a decimal
		Decimal Numero2 = Decimal.Parse (entry5.Text); //El otro numero a decimal
		Decimal Resultado = Numero1+Numero2; //Suma de los dos numeros
		label3.Text = Resultado.ToString ();	//Que el resultado salga en la casilla de Resultado
	}
}
