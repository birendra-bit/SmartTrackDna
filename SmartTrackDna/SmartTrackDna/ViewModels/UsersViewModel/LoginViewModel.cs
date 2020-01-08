using SmartTrackDna.Models;
using SmartTrackDna.Pages.User;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmartTrackDna.ViewModels.UsersViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private INavigation navigation;

        public LoginViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command OpenNewPage
        {
            get
            {
                return new Command(()=> {
                    Login data = new Login();
                    data.Uname = UName;
                    navigation.PushAsync(new DisplayLoggedInUser(data));
                });
            }
        }

        public string uName;
        public string UName { get => uName; set => uName = value; }


        public string password;
        public string Password { get => password; set => password = value; }

    }
}
