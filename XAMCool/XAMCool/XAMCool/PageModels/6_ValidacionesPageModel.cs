using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XAMCool.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class _6_ValidacionesPageModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasError { get; set; }
        public ICommand SendCommand { get; set; }

        public _6_ValidacionesPageModel(Page _page)
        {
            SendCommand = new Command(async () =>
            {
                //if (string.IsNullOrEmpty(Name))
                //{
                //    await _page.DisplayAlert("Error", "Name is invalid", "Ok");
                //    return;
                //}
                if (string.IsNullOrEmpty(Name))
                {
                    HasError = true;
                    return;
                }
                else
                {
                    HasError = false;
                }
                await _page.DisplayAlert("All is Cool", "Information sent", "Ok");
            });
        }
    }
}
