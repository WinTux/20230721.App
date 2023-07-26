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
    async void OnBotonTerceraPageClic(object sender, EventArgs e)
    {
        Debug.WriteLine("[EVENTO] Botón OnBotonTerceraPageClic presionado");
        await Shell.Current.GoToAsync(nameof(TerceraPage));
    }
    async void OnBotonCuartaPageClic(object sender, EventArgs e)
    {
        Debug.WriteLine("[EVENTO] Botón OnBotonCuartaPageClic presionado");
        await Shell.Current.GoToAsync(nameof(CuartaPage));
    }
}

