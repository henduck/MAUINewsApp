using MAUIDemo.ViewModels;

namespace MAUIDemo.Views;

public partial class SectionsPage : ContentPage
{
	public SectionsPage()
	{
		InitializeComponent();
		this.BindingContext = new SectionsViewModel();
	}
}
