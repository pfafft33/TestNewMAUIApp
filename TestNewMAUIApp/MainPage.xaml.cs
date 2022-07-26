using TestNewMAUIApp.ViewModels;

namespace TestNewMAUIApp;

public partial class MainPage : ContentPage
{
	int count = 0;
    private readonly MainViewModel _myMainVM;

    public MainPage(MainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
        _myMainVM = vm;
    }

    private void MyStoreDetailsNameEntry_Completed(object sender, EventArgs e)
    {
        _myMainVM.StoreDetailsNameCompleted((Entry)sender);
    }

    private void MyStoreDetailsPhoneEntry_Completed(object sender, EventArgs e)
    {
        _myMainVM.StoreDetailsPhoneCompleted((Entry)sender);
    }

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

