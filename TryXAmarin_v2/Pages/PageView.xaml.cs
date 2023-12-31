﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryXAmarin_v2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageView : ContentPage
    {
        public PageView()
        {
            InitializeComponent();
        }

        private void btnContentPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageContentPage());

        }

        private void btnFlyoutPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FluoutPage.PageFlyoutPage());
        }
    }
}