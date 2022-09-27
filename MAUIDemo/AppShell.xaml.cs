using MAUIDemo.Views;

namespace MAUIDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("article", typeof(ArticlePage));
    }
}

