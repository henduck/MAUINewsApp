using MAUIDemo.ViewModels;

namespace MAUIDemo.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		this.BindingContext = new HomeViewModel();
	}
}
