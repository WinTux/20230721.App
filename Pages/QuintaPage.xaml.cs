using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls.Maps;
using System.Diagnostics;

namespace _20230721.Pages;

public partial class QuintaPage : ContentPage
{
	public QuintaPage()
	{
		InitializeComponent();
		Location location = new Location(-16.501836579169517, -68.13286819508644);
		MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
		mimapa.MoveToRegion(mapSpan);

		mimapa.Pins.Add(new Pin {
			Label = "Pepe está en el Banco Unión",
			Location = new Location(-16.501534637030485, -68.13304757163773)
		});

		mimapa.MapType = MapType.Satellite;
	}
	async void OnMapaClic(Object sender, MapClickedEventArgs e)
	{
		Debug.WriteLine($"Map cliqueado en: {e.Location.Latitude},  {e.Location.Longitude}");
	}
}