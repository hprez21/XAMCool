using Syncfusion.XForms.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMCool.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _8_Loader : ContentPage
    {
        public _8_Loader()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //loader.IsRunning = true;
            //stack.Opacity = .8;
            //stack.IsEnabled = false;
            //stack.BackgroundColor = Color.Black;
            //await DoSomething();
            //loader.IsRunning = false;
            //stack.Opacity = 1;
            //stack.IsEnabled = true;
            //stack.BackgroundColor = Color.White;
            var popup = new PopupPage("Loading");
            await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(popup);
            await DoSomething();
            await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopAllAsync();

        }

        private async Task DoSomething()
        {
            await Task.Delay(5000);
        }
    }
}