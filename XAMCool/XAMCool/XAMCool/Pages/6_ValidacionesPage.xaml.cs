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
    public partial class _6_ValidacionesPage : ContentPage
    {
        public _6_ValidacionesPage()
        {
            InitializeComponent();
            BindingContext = new _6_ValidacionesPageModel(this);
        }
    }
}