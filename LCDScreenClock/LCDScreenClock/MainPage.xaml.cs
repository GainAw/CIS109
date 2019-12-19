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
using Windows.Devices.I2c;
using Windows.Devices.Gpio;
using Windows.Devices.Enumeration;


namespace LCDScreenClock
{
    public sealed partial class MainPage : Page
    {

		public MainPage()
        {
            this.InitializeComponent();
			displayI2C lcd = new displayI2C(0x27, "I2C1", 0, 1, 2, 4, 5, 6, 7, 3);
			lcd.init();
			lcd.prints("1968");
		}
    }
}