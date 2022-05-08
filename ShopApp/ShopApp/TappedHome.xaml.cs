using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TappedHome : TabbedPage
    {
        public static TappedHome instance { get;  set; }
        public TappedHome()
        {
            InitializeComponent();
            instance = this;

        }
        
    }
}