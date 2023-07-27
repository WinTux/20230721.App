using _20230721.Pages;

namespace _20230721;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SegundaPage), typeof(SegundaPage));
        Routing.RegisterRoute(nameof(TerceraPage), typeof(TerceraPage));
        Routing.RegisterRoute(nameof(CuartaPage), typeof(CuartaPage));
        Routing.RegisterRoute(nameof(QuintaPage), typeof(QuintaPage));
    }
}
