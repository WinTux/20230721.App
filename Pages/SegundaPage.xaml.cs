using System.Timers;

namespace _20230721.Pages;

public partial class SegundaPage : ContentPage
{
	public SegundaPage()
	{
		InitializeComponent();
        var temporizador = new System.Timers.Timer(1000);
        temporizador.Elapsed += new ElapsedEventHandler(RedibujarReloj);
        temporizador.Start();
    }
    private void RedibujarReloj(object sender, ElapsedEventArgs e)
    {
        var graficosView = this.relojGraphicsView;
        graficosView.Invalidate();
    }
}