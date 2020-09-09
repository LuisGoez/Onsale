﻿using Onsale.Prism.Resources;
using OnSale.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Onsale.Prism.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            CultureInfo ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            Culture = ci.Name;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Culture { get; set; }

        public static string Accept => Resource.Accept;

        public static string ConnectionError => Resource.ConnectionError;

        public static string Error => Resource.Error;

        public static string Loading => Resource.Loading;

        public static string SearchProduct => Resource.SearchProduct;

        public static string Name => Resource.Name;

        public static string Description => Resource.Description;

        public static string Price => Resource.Price;

        public static string Category => Resource.Category;

        public static string IsStarred => Resource.IsStarred;

        public static string AddToCart => Resource.AddToCart;

        public static string Product => Resource.Product;

        public static string Products => Resource.Products;

    }

}