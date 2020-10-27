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
    public partial class _4_TransitionPPPage : ContentPage
    {
        public _4_TransitionPPPage()
        {
            InitializeComponent();
            BindingContext = new _4_TransitionPPPageModel(Navigation, this);
        }
    }
}