using Onsale.Prism.Helpers;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onsale.Prism.ViewModels
{
    public class ShowHistoryPageViewModel : ViewModelBase
    {
        public ShowHistoryPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = Languages.ShowPurchaseHistory;
        }
    }
}
