using Prism.Unity;
using PrismDeNwnpOnTab.Views;
using Xamarin.Forms;

namespace PrismDeNwnpOnTab
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("RootPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();

            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<RootPage>();
            Container.RegisterTypeForNavigation<SubPage>();
            Container.RegisterTypeForNavigation<FirstPage>();
            Container.RegisterTypeForNavigation<SecondPage>();
        }
    }
}
