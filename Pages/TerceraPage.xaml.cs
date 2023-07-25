using System.Diagnostics;
using ZXing.Net.Maui;

namespace _20230721.Pages;

public partial class TerceraPage : ContentPage
{
	public TerceraPage()
	{
		InitializeComponent();
		lectorCodigo.Options = new BarcodeReaderOptions() { 
			AutoRotate = true,
			Formats = BarcodeFormat.QrCode,//BarcodeFormats.All
            TryHarder = true,
			Multiple = false
		};

    }
	async void OnCodigoBarrasDetectado(object sender, BarcodeDetectionEventArgs e) {
		Debug.WriteLine("Se detectó un código de barras.");
		Dispatcher.Dispatch( () => {
            resultadoCodigo.Text = $"{e.Results[0].Value}; Formato: {e.Results[0].Format}";
        }); 
		

    }
}