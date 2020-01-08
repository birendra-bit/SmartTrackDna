using SmartTrackDna.ViewModels.UsersViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartTrackDna.Pages.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginViewPage : ContentPage
    {
        public LoginViewPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}