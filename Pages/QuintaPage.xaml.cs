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
		Polygon recuadro = new Polygon { 
			StrokeColor = Color.FromArgb("#00AAFF"),
			StrokeWidth = 8,
			FillColor = Color.FromArgb("#8800AAFF"),
			Geopath =
			{
				new Location(-16.500694225297913, -68.13262642158358),
				new Location(-16.500854997631468, -68.13249191065924),
				new Location(-16.501165941545754, -68.13289912866306),
				new Location(-16.50100340274383, -68.13304101004901)
			}
		};
		mimapa.MapElements.Add(recuadro);

		Polyline polyline = new Polyline {
            StrokeColor = Colors.Pink,
            StrokeWidth = 15,
            Geopath =
            {
                new Location(-16.504611632693397, -68.13407143814479),
                new Location(-16.504071023603018, -68.1336642201399),
                new Location(-16.504408462788355, -68.13313354688538),
                new Location(-16.504113424367308, -68.13294375749498)
            }
        };
        mimapa.MapElements.Add(polyline);

		Circle circle = new Circle {
			Center = new Location(-16.50420993084124, -68.13127913842527),
			Radius = new Distance(20),
			StrokeColor = Color.FromArgb("FFFF0000"),
			StrokeWidth = 8,
			FillColor = Color.FromArgb("88FF0000")
		};
        mimapa.MapElements.Add(circle);
    }
}