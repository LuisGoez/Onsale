﻿using Onsale.Prism.Helpers;
using OnSale.Common.Entities;
using OnSale.Common.Responses;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace Onsale.Prism.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase
    {
        private ObservableCollection<ProductImage> _images;
        private ProductResponse _product;
        public ProductDetailPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Title = Languages.Product;
        }

        public ObservableCollection<ProductImage> Images
        {
            get => _images;
            set => SetProperty(ref _images, value);
        }

        public ProductResponse Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("product"))
            {
                Product = parameters.GetValue<ProductResponse>("product");
                Title = Product.Name;
                Images = new ObservableCollection<ProductImage>(Product.ProductImages);
            }
        }
    }
}
