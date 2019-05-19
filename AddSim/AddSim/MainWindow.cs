using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }


    protected void num1sliderChange(object sender, EventArgs e)
    {
        num1_spinbutton.Value = num1_hscale1.Value;
        add();
    }

    protected void num1_spinnerChanged(object sender, EventArgs e)
    {
        num1_hscale1.Value = num1_spinbutton.Value;
        add();
    }

    protected void num2_spinnerChanged(object sender, EventArgs e)
    {
        num2_hscale.Value = num2_spinbutton.Value;
        add();
    }

    protected void num2sliderChange(object sender, EventArgs e)
    {
        num2_spinbutton.Value = num2_hscale.Value;
        add();
    }

    private void add()
    {
        result_lbl.Text = (num1_spinbutton.Value + num2_spinbutton.Value).ToString();
    }
}
