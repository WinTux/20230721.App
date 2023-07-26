using _20230721.Pages;
using CommunityToolkit.Maui;
using ZXing.Net.Maui;

namespace _20230721;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseBarcodeReader()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddTransient<SegundaPage>();
        builder.Services.AddTransient<TerceraPage>();
        builder.Services.AddTransient<CuartaPage>();
        return builder.Build();
	}
}
