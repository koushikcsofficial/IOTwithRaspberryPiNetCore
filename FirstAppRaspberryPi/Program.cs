using System;
using System.Device.Gpio;
using System.Threading;

namespace FirstAppRaspberryPi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int LedPin = 4;
            GpioController controller = new GpioController();
            controller.OpenPin(LedPin, PinMode.Output);


            while (true)
            {
                controller.Write(LedPin, PinValue.High);
                Thread.Sleep(2000);
                controller.Write(LedPin, PinValue.Low);
                Thread.Sleep(2000);
            }
        }
    }
}
