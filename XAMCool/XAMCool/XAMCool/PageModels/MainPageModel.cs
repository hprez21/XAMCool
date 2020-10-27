using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMCool.Pages;

namespace XAMCool.PageModels
{
    public class MainPageModel
    {
        public ICommand TopParallaxCommand { get; set; }
        public ICommand ListViewParallaxCommand { get; set; }
        public ICommand GradientsCommand { get; set; }
        public ICommand TransitionPPCommand { get; set; }
        public ICommand ControlTransitionsCommand { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand ValidationsCommand { get; set; }
        public ICommand LottieCommand { get; set; }
        public ICommand LoaderCommand { get; set; }
        public ICommand ShapesCommand { get; set; }

        public MainPageModel(INavigation _navigation)
        {
            Navigation = _navigation;
            TopParallaxCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _1_TopParallaxPage());                
            });
            ListViewParallaxCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _2_ListViewParallaxPage());                
            });
            GradientsCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _3_GradientsPage());                
            });
            TransitionPPCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _4_TransitionPPPage());                
            });
            ControlTransitionsCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _5_Controls_TransitionsPage());
            });
            ValidationsCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _6_ValidacionesPage());
            });
            LottieCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _7_Lottie());
            });
            LoaderCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _8_Loader());
            });
            ShapesCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new _9_ShapesPage());
            });
        }
    }
}
