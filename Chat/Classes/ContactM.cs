using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Chat.Classes
{
    public class ContactM
    {
        public string Username { get; set; }
        public string ImageSource { get; set; }
        public ObservableCollection<MessageM> Messages{  get; set; }
        public string LastMessage => Messages.Last().Message;
    }
}
