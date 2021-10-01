using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreferancePage : ContentPage
    {

        public PreferancePage()
        {
            InitializeComponent();
            string Swap = Xamarin.Essentials.Preferences.Get("Swap", "metric");

            if (Swap == "metric")
            {

                metricSwitch.IsToggled = true;
            }

            else
            {
                metricSwitch.IsToggled = false;
            }

        }

        private void metricSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (metricSwitch.IsToggled)
            {
                Xamarin.Essentials.Preferences.Set("Swap", "metric");
            }
            else
            {
                Xamarin.Essentials.Preferences.Set("Swap", "imperial");
            }
            
        }
    }
}