namespace _20230721.Pages;

public partial class SextaPage : ContentPage
{
	public SextaPage()
	{
		InitializeComponent();
	}

	public void OnBotonClic(object sender, EventArgs e)
	{
		if (video.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
			video.Pause();
		else
			video.Play();
	}
}