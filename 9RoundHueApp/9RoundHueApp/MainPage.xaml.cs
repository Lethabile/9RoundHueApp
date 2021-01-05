using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using Q42.HueApi.ColorConverters;
using System.Net.Http;

namespace _9RoundHueApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SetupHueLights(object sender, EventArgs e)
        {
            var bridgeIP = "192.168.1.94";
            var appKey = "xeubXtBl7hiDckEfxXHrioX1hxnpicSlpCWa5D2F";

            ILocalHueClient client = new LocalHueClient(bridgeIP);
            client.Initialize(appKey);

            var command = new LightCommand();
            command.TurnOff();

            client.SendCommandAsync(command);
        }

        public void ColorLoopLights(object sender, EventArgs args)
        {
            var bridgeIP = "192.168.1.94";
            var appKey = "xeubXtBl7hiDckEfxXHrioX1hxnpicSlpCWa5D2F";

            ILocalHueClient client = new LocalHueClient(bridgeIP);
            client.Initialize(appKey);

            var command = new LightCommand();
            command.Effect = Q42.HueApi.Effect.ColorLoop;

            client.SendCommandAsync(command);
        }
    }
}
