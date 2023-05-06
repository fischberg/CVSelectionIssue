namespace CVSelectionIssue;

public partial class MainPage : ContentPage
{
	CVViewModel vm;

	public MainPage()
	{
		vm = new CVViewModel();
		InitializeComponent();
		BindingContext = vm;
	}
}


