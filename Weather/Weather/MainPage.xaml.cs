using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        
        private void tempBtnClicked(object sender, EventArgs e)
        {
            OpenTemp();
        }

        private void prefBtnClicked(object sender, EventArgs e)
        {
            openPref();
        }

        private void aboutBtnClicked(object sender, EventArgs e)
        {
            openAbout();
        }

        
        
        
        
        private async void OpenTemp()
        {
            Temperaturepage temp = new Temperaturepage();
            await Navigation.PushModalAsync(temp);
        }

        private async void openPref()
        {
            PreferancePage pref = new PreferancePage();
            await Navigation.PushModalAsync(pref);
        }



        private async void openAbout()
        {
            AboutPage about = new AboutPage();
            await Navigation.PushModalAsync(about);
        }
    }
}
