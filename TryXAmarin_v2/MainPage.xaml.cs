using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TryXAmarin_v2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Pages_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.PageView());
        }

        private void Layouts_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Layouts.LayOutContentPage());
        }
    }
}
