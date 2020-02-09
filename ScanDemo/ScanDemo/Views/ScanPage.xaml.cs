using ScanDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;

namespace ScanDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        ScanViewModel viewModel;

        public ScanPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ScanViewModel();
        }

        public void scanView_OnScanResult(Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Scanned result", "The barcode's text is " + result.Text + ". The barcode's format is " + result.BarcodeFormat, "OK");
            });
        }
    }
}