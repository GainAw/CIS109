using System;
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
using Windows.Devices.I2c;
using Windows.Devices.Gpio;
using Windows.Devices.Enumeration;
using System.Threading;


namespace LCDScreenClock
{
    public sealed partial class MainPage : Page
    {
		Random WeatherRNG;
		public MainPage()
		{
			WeatherRNG = new Random();
            this.InitializeComponent();
			displayI2C lcd = new displayI2C(0x27, "I2C1", 0, 1, 2, 4, 5, 6, 7, 3);
			string weather = (string)_GetWeather();
			lcd.init();
			while (true)
			{
				float Hour = DateTime.Now.Hour;
				float Min = DateTime.Now.Minute;
				float Sec = DateTime.Now.Second;
				lcd.gotoxy(4,0);
				lcd.prints(Hour + ":" + Min + ":" + Sec);
				lcd.gotoxy(0,1);
				lcd.prints("Weather: " + weather);
				Thread.Sleep(1000);
				lcd.clrscr();
			}
		}

		public Object _GetWeather()
		{
			Object Weather = "Sunny";
			switch (WeatherRNG.Next(1, 7))
			{
				case 1:
					Weather = "Sunny";
					break;
				case 2:
					Weather = "Rain";
					break;
				case 3:
					Weather = "Cloudy";
					break;
				case 4:
					Weather = "Hail";
					break;
				case 5:
					Weather = "Clear";
					break;
				case 6:
					Weather = "Bees?";
					break;
			}
			return Weather;
		}
    }
}
