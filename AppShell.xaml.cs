using _20230721.Pages;

namespace _20230721;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SegundaPage), typeof(SegundaPage));
	}
}
