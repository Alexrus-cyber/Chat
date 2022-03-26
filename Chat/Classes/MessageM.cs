﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Classes
{
  public  class MessageM
    {
        public string Username { get; set; }
        public string UsernameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }

        public bool FirstMessage { get; set; }
    }
}
