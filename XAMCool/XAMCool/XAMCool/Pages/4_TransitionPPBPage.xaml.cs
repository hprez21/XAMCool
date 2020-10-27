using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMCool.Models;
using XAMCool.PageModels;

namespace XAMCool.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _4_TransitionPPBPage : ContentPage
    {
        public _4_TransitionPPBPage(Contact contact)
        {
            InitializeComponent();
            BindingContext = new _4_TransitionPPBPageModel(contact);
        }
    }
}