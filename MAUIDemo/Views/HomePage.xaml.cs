using MAUIDemo.Services;
using MAUIDemo.ViewModels;

namespace MAUIDemo.Views;

public partial class HomePage : ContentPage
{
	public HomePage(INewsService news)
	{
		InitializeComponent();
		this.BindingContext = new HomeViewModel(news);
	}
}
