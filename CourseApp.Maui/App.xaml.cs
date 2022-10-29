namespace CourseApp.Maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Pages.Layout.StackLayoutPage();
	}
}

