using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryXAmarin_v2.Pages.FluoutPage
{
    public class PageFlyoutPageFlyoutMenuItem
    {
        public PageFlyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(PageFlyoutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}