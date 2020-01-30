using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heat Index or Wind Chill Calculator");
            double relativeHumidity;
            double heatIndex;
            double temperature;
            int windSpeed;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the Temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);
            bool istemp = double.TryParse(input, out temperature);

            if (temperature > 50)
            {
                relativeHumidity = int.Parse(input);
                Console.WriteLine("Enter Relative Humidity");
                input = Console.ReadLine();
                heatIndex = .5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativeHumidity * 0.094));

                Console.WriteLine("The Heat Index is " + heatIndex);

            }
            else if (temperature <= 50)
            {
                // Get the windspeed from the user
                Console.WriteLine("Enter the wind speed in MPH");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
        }
    }
}
