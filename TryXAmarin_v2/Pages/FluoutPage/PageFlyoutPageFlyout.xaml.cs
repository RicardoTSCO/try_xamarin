using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryXAmarin_v2.Pages.FluoutPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public PageFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new PageFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class PageFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PageFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public PageFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<PageFlyoutPageFlyoutMenuItem>(new[]
                {
                    new PageFlyoutPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new PageFlyoutPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new PageFlyoutPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new PageFlyoutPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new PageFlyoutPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}