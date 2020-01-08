using SmartTrackDna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SmartTrackDna.ViewModels.UsersViewModel
{
    public class DisplayLoggedInUserViewModel
    {
        Login data;
        public DisplayLoggedInUserViewModel(Login data)
        {
            Uname = data.Uname;
            this.data = data;
        }

        public string uname;

        public string Uname { get =>"Wel-Come "+ uname; set => uname = value; }
    }
}
