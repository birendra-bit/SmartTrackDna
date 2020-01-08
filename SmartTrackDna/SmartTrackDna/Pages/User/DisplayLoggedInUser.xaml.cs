using SmartTrackDna.Models;
using SmartTrackDna.ViewModels.UsersViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartTrackDna.Pages.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayLoggedInUser : ContentPage
    {

        public DisplayLoggedInUser(Login data)
        {
            InitializeComponent();
            BindingContext = new DisplayLoggedInUserViewModel(data);
        }
    }
}