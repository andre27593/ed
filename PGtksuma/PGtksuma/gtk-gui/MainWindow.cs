
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox8;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Label label1;
	private global::Gtk.Entry entry4;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label label2;
	private global::Gtk.Entry entry5;
	private global::Gtk.VBox vbox9;
	private global::Gtk.HBox hbox8;
	private global::Gtk.Button button4;
	private global::Gtk.Label label3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 1");
		this.hbox6.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entry4 = new global::Gtk.Entry ();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '•';
		this.hbox6.Add (this.entry4);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.entry4]));
		w2.Position = 1;
		this.vbox8.Add (this.hbox6);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox6]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 2");
		this.hbox7.Add (this.label2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label2]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.entry5 = new global::Gtk.Entry ();
		this.entry5.CanFocus = true;
		this.entry5.Name = "entry5";
		this.entry5.IsEditable = true;
		this.entry5.InvisibleChar = '•';
		this.hbox7.Add (this.entry5);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entry5]));
		w5.Position = 1;
		this.vbox8.Add (this.hbox7);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox7]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button ();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("Suma");
		this.hbox8.Add (this.button4);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.button4]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Resultado");
		this.hbox8.Add (this.label3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label3]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.vbox9.Add (this.hbox8);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox8]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox8.Add (this.vbox9);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.vbox9]));
		w10.Position = 2;
		this.Add (this.vbox8);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
	}
}
