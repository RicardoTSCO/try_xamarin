using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryXAmarin_v2.Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LayOutContentPage : ContentPage
	{
		public LayOutContentPage ()
		{
			InitializeComponent ();
		}

        private void layout_Clicked(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new TesteStacLayout());
        }

        private void layoutv2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TesteStacLayout_v2());

        }
    }
}