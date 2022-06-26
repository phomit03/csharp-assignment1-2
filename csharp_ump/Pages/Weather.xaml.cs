﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2108M_UMP.Module.CurentWeather;
using T2108M_UMP.Service;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2108M_UMP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Weather : Page
    {
        public Weather()
        {
            this.InitializeComponent();
            PrintTemp();
        }
        public async void PrintTemp()
        {
            /*WeatherService ws = new WeatherService();
            CurentWeather cw = await ws.GetCurentWeather();
            Temp.Text = cw.main.temp.toString();*/
            WeatherService ws = new WeatherService();
            CurentWeather cw = await ws.GetForeCastWeather();

            for (int i = 0; i < 15; i++)
            {
                weatherlist.Items.Add(cw.list[i]);

            }
            //foreach (List tt in fw.list)
            //{
              
            //}
        }
    }
}
