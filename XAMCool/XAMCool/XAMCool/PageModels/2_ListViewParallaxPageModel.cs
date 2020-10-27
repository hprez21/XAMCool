using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XAMCool.Models;

namespace XAMCool.PageModels
{
    public class _2_ListViewParallaxPageModel
    {        
        public ObservableCollection<Contact> Items { get; set; }

        public _2_ListViewParallaxPageModel()
        {
            Items = new ObservableCollection<Contact>()
            { new Contact() { Name = "Thriller", Author = "Michael Jackson - 10 Tracks",Tracks="10 Tracks" },
                new Contact() { Name = "Like a Prayer", Author = "Madonna - 1 Tracks" ,Tracks="1 Tracks" },
                new Contact() { Name = "When Doves Cry", Author = "Prince - 60 Tracks",Tracks="60 Tracks" },
                new Contact() { Name = "I Wanna Dance", Author = "Whitney Houston - 70 Tracks",Tracks="70 Tracks" },
                new Contact() { Name = "It’s Gonna Be Me", Author = "N Sync - 10 Tracks",Tracks="10 Tracks" },
                new Contact() { Name = "Everybody", Author = "Backstreet Boys - 4 Tracks",Tracks="4 Tracks" },
                new Contact() { Name = "Rolling in the Deep", Author = "Adele - 25 Tracks" ,Tracks="25 Tracks" },
                new Contact() { Name = "Don’t Stop Believing", Author = "Journey - 10 Tracks" ,Tracks="10 Tracks" },
                new Contact() { Name = "Billie Jean", Author = "Michael Jackson - 5 Tracks",Tracks="5 Tracks" },
                new Contact() { Name = "Sorry", Author = "Justin Bieber - 1 Tracks",Tracks="1 Tracks" },
                new Contact() { Name = "Firework", Author = "Katy Perry - 6 Tracks",Tracks="6 Tracks" },
                new Contact() { Name = "The A Team", Author = "Ed Sheeran - 8 Tracks" ,Tracks="8 Tracks"},
                new Contact() { Name = "Thriller", Author = "Michael Jackson - 3 Tracks" ,Tracks="3 Tracks"},
                new Contact() { Name = "Like a Prayer", Author = "Madonna - 40 Tracks" ,Tracks="40 Tracks"},
                new Contact() { Name = "When Doves Cry", Author = "Prince - 10 Tracks",Tracks="10 Tracks" },
                new Contact() { Name = "I Wanna Dance", Author = "Whitney Houston - 2 Tracks",Tracks="2 Tracks" },
                new Contact() { Name = "It’s Gonna Be Me", Author = "N Sync - 11 Tracks" ,Tracks="11 Tracks"},
                new Contact() { Name = "Everybody", Author = "Backstreet Boys - 15 Tracks",Tracks="15 Tracks" },
                new Contact() { Name = "Rolling in the Deep", Author = "Adele - 18 Tracks" ,Tracks="18 Tracks"},
                new Contact() { Name = "Don’t Stop Believing", Author = "Journey - 35 Tracks",Tracks="35 Tracks" },
            };
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Image = $"ParallaxGuitar{(i + 1) % 12}.png";
            }
        }
    }
}
