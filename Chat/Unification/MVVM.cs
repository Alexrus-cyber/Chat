using Chat.Classes;
using Chat.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Chat.Unification
{
    class MVVM : ObservableObject
    {
        public ObservableCollection<MessageM> Messages { get; set; }
        public ObservableCollection<ContactM> Contacts { get; set; }


        public RelayCommand SendCommand { get; set; }

        public ContactM _selectedContact;

        public ContactM SelectedContact
        { 
            get { return _selectedContact; }
            set { _selectedContact = value; OnPropertyChanged(); }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value;
                OnPropertyChanged();
            }
            
        }

        public MVVM()
        {
            Messages = new ObservableCollection<MessageM>();
            Contacts = new ObservableCollection<ContactM>();


            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageM
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = "";
            });

            Messages.Add(new MessageM
            {
                Username = "Brad",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                UsernameColor = "#408aff",
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
                    UsernameColor = "#408aff",
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
                    UsernameColor = "#408aff",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Message = "Не тест",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                         });
            }

            Messages.Add(new MessageM
            { 
              Username = "Ban",
              UsernameColor = "#408aff",
              ImageSource = "https://i.imgur.com/yMWvLXd.png",
              Message = "Руддщ",
              Time = DateTime.Now,
              IsNativeOrigin = true,
         
              });

                
            
            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactM
                {
                    Username = $"Brad {i}",
                    ImageSource = "https://i.imgur.com/yMWvLXd.png",
                    Messages = Messages
                }) ;
            }
        }
    }
}
