using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HueControlBlazorExampleWebApp.Models;

namespace HueControlBlazorExampleWebApp.Services
{
    public class UserLogoutEventArgs : EventArgs
    {
        public string Username { get; }

        public UserLogoutEventArgs(string username)
        {
            Username = username;
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public string Username { get; }
        public string Message { get; }
    }
}
