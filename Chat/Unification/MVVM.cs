using Chat.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Chat.Unification
{
    class MVVM
    {
        public ObservableCollection<MessageM> Messages { get; set; }
        public ObservableCollection<ContactM> Contacts { get; set; }
        public MVVM()
        {
            Messages = new ObservableCollection<MessageM>();
            Contacts = new ObservableCollection<ContactM>();


            Messages.Add(new MessageM
            {
                Username = "Brad",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                UsernameColor = "#",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true


            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageM
                {
                    Username = "Brad",
                    UsernameColor = "#",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false


                });

            }
            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageM
                {
                    Username = "Ban",
                    UsernameColor = "#",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                         });
            }
            Messages.Add(new MessageM
            { 
              Username = "Ban",
              UsernameColor = "#",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "Test",
              Time = DateTime.Now,
              IsNativeOrigin = true,
         
              });

                
            
            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactM
                {
                    Username = $"Alex {i}",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Messages = Messages
                }) ;
            }
        }
    }
}
