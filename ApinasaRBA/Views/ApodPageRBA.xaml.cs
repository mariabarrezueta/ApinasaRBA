using ApinasaRBA.ViewModels;

namespace ApinasaRBA.Views;

public partial class ApodPageRBA : ContentPage
{
	public ApodPageRBA()
	{
		InitializeComponent();
        BindingContext = new ApodViewModelRBA();
    }
}