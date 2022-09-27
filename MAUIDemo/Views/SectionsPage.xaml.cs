using MAUIDemo.Services;
using MAUIDemo.ViewModels;

namespace MAUIDemo.Views;

public partial class SectionsPage : ContentPage
{
	public SectionsPage(INewsService news)
	{
		InitializeComponent();
		this.BindingContext = new SectionsViewModel(news);
	}
}
