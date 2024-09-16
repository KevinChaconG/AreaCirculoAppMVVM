namespace AreaCirculoAppMVVM.Views;
using AreaCirculoAppMVVM.ViewModels;

public partial class AreaCirculoView : ContentPage
{

	private AreaCirculoViewModel ViewModel;
	public AreaCirculoView()
	{
		InitializeComponent();
		ViewModel = new AreaCirculoViewModel();
		BindingContext = ViewModel;
	}
}