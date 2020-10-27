using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMCool.PageModels;

namespace XAMCool.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _2_ListViewParallaxPage : ContentPage
    {
        public _2_ListViewParallaxPage()
        {
            InitializeComponent();
            BindingContext = new _2_ListViewParallaxPageModel();
        }
    }
}