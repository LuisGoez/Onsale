using Onsale.Prism.Helpers;
using Prism.Navigation;

namespace Onsale.Prism.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = Languages.Login;
        }
    }

}
