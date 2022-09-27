using MAUIDemo.Views;

namespace MAUIDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("article", typeof(ArticlePage));

		this.HomeTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.home.png", this.GetType().Assembly);
        this.SectionsTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.categories.png", this.GetType().Assembly);
        this.BookmarksTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.bookmarks.png", this.GetType().Assembly);
        this.ProfileTab.Icon = ImageSource.FromResource("MAUIDemo.Resources.Images.profile.png", this.GetType().Assembly);
    }
}
