using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HueControlBlazorExampleWebApp.Models;

namespace HueControlBlazorExampleWebApp.Services
{
    public class UserLoginEventArgs : EventArgs
    {
        public User User { get; }

        public UserLoginEventArgs(User user)
        {
            User = user;
        }
    }
}
