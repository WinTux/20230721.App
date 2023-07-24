using _20230721.Pages;
using System.Diagnostics;
using System.Timers;

namespace _20230721;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
	}
	async void OnBotonSegundaPageClic( object sender, EventArgs e)
	{
		Debug.WriteLine("[EVENTO] Botón OnBotonSegundaPageClic presionado");
		await Shell.Current.GoToAsync(nameof(SegundaPage));
	}
	
}

