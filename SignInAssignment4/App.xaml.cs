using SignInAssignment4.Views;

namespace SignInAssignment4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new SignInView()));
        }
    }
}