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
    public partial class PageContentPage : ContentPage
    {
        public PageContentPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}