using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Temperaturepage : ContentPage
    {
        APIs aPIs = new APIs();
        
        public Temperaturepage()
        {
            InitializeComponent();

            GetTemp();
        }

        public async void GetTemp()
        {
            string unit = Xamarin.Essentials.Preferences.Get("Swap", "metric");

            string choice;

            if(unit == "metric")
            {
                choice = "°C";
            }

            else
            {
                choice = "°F";
            }

            Model model = await new APIs().GetApi("Perth");

            perthTemp.Text = string.Format(model.Perthtemperature.ToString() + choice);

            description.Text = model.description.ToString();
        }

        
    }
}