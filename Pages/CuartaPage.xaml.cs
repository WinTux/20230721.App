using CommunityToolkit.Maui.Core;

namespace _20230721.Pages;

public partial class CuartaPage : ContentPage
{
	public CuartaPage()
	{
		InitializeComponent();
	}

	async void OnLineaDibujada(object sender, DrawingLineCompletedEventArgs e)
	{
		var stream = await lienzo.GetImageStream(200, 200);
		Dispatcher.Dispatch(() => {
			imagen.Source = ImageSource.FromStream(() => stream);
		});
    }
}