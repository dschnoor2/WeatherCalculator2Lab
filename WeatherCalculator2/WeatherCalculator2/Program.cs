using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Weather Calculator 2.0");
           
            double relativeHumidity;
            double heatIndex;
            double temperature;
            double windSpeed;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the Temperature in Fahrenheit");

            input = Console.ReadLine();

            temperature = int.Parse(input);
            bool istemp = double.TryParse(input, out temperature);

            //If Temperature > 50 Calculate Heat Index
            if (temperature > 50)
            {
                //Get Relative Humidity from User
                relativeHumidity = int.Parse(input);
                Console.WriteLine("Enter Relative Humidity");
                input = Console.ReadLine();
                
                //Calculate Heat Index
                heatIndex = .5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativeHumidity * 0.094));

                //Print Heat Index to User
                Console.WriteLine("The Heat Index is " + heatIndex);

            }
            //If temperature <= 50 Calculate Wind Chill
            else if (temperature <= 50)
            {
                // Get the Wind Speed from the User
                Console.WriteLine("Enter the Wind Speed in MPH");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the Wind Chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                //Print Wind Chill to User
                Console.WriteLine("The Wind Chill is " + windChill);
            }
        }
    }
}
