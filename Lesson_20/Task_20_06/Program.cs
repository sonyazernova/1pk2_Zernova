using System;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLightSimulator
{
    public enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }

    class Program
    {
        private static TrafficLightColor currentColor = TrafficLightColor.Red;
        private static bool isRunning = true;
        private static bool isManualMode = false;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Светофор запущен. Нажмите:");
            Console.WriteLine("1 - для ручного переключения");
            Console.WriteLine("Esc - для выхода");

            var autoSwitchTask = Task.Run(AutoSwitchColors);

            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.Escape)
                    {
                        isRunning = false;
                    }
                    else if (key == ConsoleKey.D1)
                    {
                        isManualMode = !isManualMode;
                        Console.WriteLine(isManualMode ? "Ручной режим активирован" : "Автоматический режим активирован");
                    }
                    else if (isManualMode && key == ConsoleKey.Spacebar)
                    {
                        ManualSwitchColor();
                    }
                }

                await Task.Delay(100);
            }

            await autoSwitchTask;
            Console.WriteLine("Светофор остановлен.");
        }

        static void AutoSwitchColors()
        {
            while (isRunning)
            {
                if (!isManualMode)
                {
                    SwitchToNextColor();
                    Console.WriteLine($"Текущий цвет: {currentColor}");
                    Thread.Sleep(3000);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        static void ManualSwitchColor()
        {
            SwitchToNextColor();
            Console.WriteLine($"Текущий цвет: {currentColor}");
        }

        static void SwitchToNextColor()
        {
            currentColor = currentColor switch
            {
                TrafficLightColor.Red => TrafficLightColor.Yellow,
                TrafficLightColor.Yellow => TrafficLightColor.Green,
                TrafficLightColor.Green => TrafficLightColor.Red,
                _ => TrafficLightColor.Red
            };
        }
    }
}