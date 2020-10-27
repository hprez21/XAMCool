using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XAMCool.Models;
using XAMCool.Pages;

namespace XAMCool.PageModels
{
    public class _4_TransitionPPPageModel
    {
        public ObservableCollection<Contact> Items { get; set; }
        public ICommand TransitionCommand { get; set; }
        public Contact SelectedItem { get; set; }
        INavigation Navigation;        

        public _4_TransitionPPPageModel(INavigation _navigation, Page _page)
        {
            Items = new ObservableCollection<Contact>()
            { new Contact() { Id = 1, Name = "Thriller", Author = "Michael Jackson - 10 Tracks",Tracks="10 Tracks" },
                new Contact() { Id = 2, Name = "Like a Prayer", Author = "Madonna - 1 Tracks" ,Tracks="1 Tracks" },
                new Contact() { Id = 3, Name = "When Doves Cry", Author = "Prince - 60 Tracks",Tracks="60 Tracks" },
                new Contact() { Id = 4, Name = "I Wanna Dance", Author = "Whitney Houston - 70 Tracks",Tracks="70 Tracks" },
                new Contact() { Id = 5, Name = "It’s Gonna Be Me", Author = "N Sync - 10 Tracks",Tracks="10 Tracks" },
                new Contact() { Id = 6, Name = "Everybody", Author = "Backstreet Boys - 4 Tracks",Tracks="4 Tracks" },
                new Contact() { Id = 7, Name = "Rolling in the Deep", Author = "Adele - 25 Tracks" ,Tracks="25 Tracks" },
                new Contact() { Id = 8, Name = "Don’t Stop Believing", Author = "Journey - 10 Tracks" ,Tracks="10 Tracks" },
                new Contact() { Id = 9, Name = "Billie Jean", Author = "Michael Jackson - 5 Tracks",Tracks="5 Tracks" },
                new Contact() { Id = 10, Name = "Sorry", Author = "Justin Bieber - 1 Tracks",Tracks="1 Tracks" },
                new Contact() { Id = 11, Name = "Firework", Author = "Katy Perry - 6 Tracks",Tracks="6 Tracks" },
                new Contact() { Id = 12, Name = "The A Team", Author = "Ed Sheeran - 8 Tracks" ,Tracks="8 Tracks"},
                new Contact() { Id = 13, Name = "Thriller", Author = "Michael Jackson - 3 Tracks" ,Tracks="3 Tracks"},
                new Contact() { Id = 14, Name = "Like a Prayer", Author = "Madonna - 40 Tracks" ,Tracks="40 Tracks"},
                new Contact() { Id = 15, Name = "When Doves Cry", Author = "Prince - 10 Tracks",Tracks="10 Tracks" },
                new Contact() { Id = 16, Name = "I Wanna Dance", Author = "Whitney Houston - 2 Tracks",Tracks="2 Tracks" },
                new Contact() { Id = 17, Name = "It’s Gonna Be Me", Author = "N Sync - 11 Tracks" ,Tracks="11 Tracks"},
                new Contact() { Id = 18, Name = "Everybody", Author = "Backstreet Boys - 15 Tracks",Tracks="15 Tracks" },
                new Contact() { Id = 19, Name = "Rolling in the Deep", Author = "Adele - 18 Tracks" ,Tracks="18 Tracks"},
                new Contact() { Id = 20, Name = "Don’t Stop Believing", Author = "Journey - 35 Tracks",Tracks="35 Tracks" },
            };
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Image = $"ParallaxGuitar{(i + 1) % 12}.png";
            }

            Navigation = _navigation;
            

            TransitionCommand = new Command(async () =>
            {
                //await Navigation.PushAsync(new _4_TransitionPPBPage(SelectedItem));
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(_page, SelectedItem.Id.ToString());
                await Navigation.PushAsync(new _4_TransitionPPBPage(SelectedItem));
            });        
        }
    }
}
