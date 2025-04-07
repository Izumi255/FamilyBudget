using Microsoft.UI.Xaml;

namespace familybudget;

public partial class App : Application
{
    private Window? window;

    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        window = new MainWindow();
        window.Activate();
    }
}

