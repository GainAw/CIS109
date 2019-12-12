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
using Windows.Devices.Gpio;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloBlinky
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const int LED = 26;
        private GpioPin _pin;
        private DispatcherTimer timer;
        GpioPinValue _pinvalue;
        public MainPage()
        {
            this.InitializeComponent();
            InitialiseGpio();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitialiseGpio()
        {
            var controller = GpioController.GetDefault();
            if (controller != null)
            {
                _pin = controller.OpenPin(LED);
                _pin.SetDriveMode(GpioPinDriveMode.Output);
                _pin.Write(GpioPinValue.Low);
                _pinvalue = GpioPinValue.Low;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Target Device Does Not Have Gpio pins");
            }
        }
        private void Timer_Tick(object sender, object e)
        {
            if (_pinvalue == GpioPinValue.High)
            {
                _pin.Write(GpioPinValue.Low);
                _pinvalue = GpioPinValue.Low;
            }
            else
            {
                _pin.Write(GpioPinValue.High);
                _pinvalue = GpioPinValue.High;
            }
        }

    }
}
