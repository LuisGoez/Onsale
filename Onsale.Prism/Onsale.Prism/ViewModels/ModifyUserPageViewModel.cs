using Onsale.Prism.Helpers;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onsale.Prism.ViewModels
{
    public class ModifyUserPageViewModel : ViewModelBase
    {
        public ModifyUserPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = Languages.ModifyUser;
        }
    }
}
