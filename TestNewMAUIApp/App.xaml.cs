using TestNewMAUIApp.Helpers;

namespace TestNewMAUIApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = ServiceHelper.GetService<MainPage>();
        //MainPage = new MainPage();
        //MainPage = new AppShell();
    }

}
