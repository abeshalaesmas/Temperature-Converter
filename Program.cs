class TemperatureConverter
{
    // Method to convert Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {       //This variable hold the converted value of Celsius to Fahrenheit
            double CelsiusToFahrenheit = (celsius * 9/5) + 32;
            return CelsiusToFahrenheit;// This line return the new value
    }

    //Method to convert Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit)
    {     // This variable hold the conveted value of Fahrenheit to Celsius
         double FahrenheitToCelsius = (fahrenheit - 32) / 1.8;
         return FahrenheitToCelsius;
    }

    // testing

    // This is the Entry point of the code (Main) 
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter");
        
        double temperature = 0; // The default value of temperature is 0
        bool validTemperature = false;
        // The Exclamation point (!) means NOT that say not false that make value of validTemperature true
        while (!validTemperature)
        {  
            Console.WriteLine("Enter temperature value: ");
            // The Question Mark(?) is make datatype to be Nullable type that accpeting null values
            string? input = Console.ReadLine();
            if (input != null)
            {   // double.tryParse is the one who convert the string datatype in number form  into double datatype
                validTemperature = double.TryParse(input, out temperature);
                if (!validTemperature)
                {
                    Console.WriteLine("Invalid temperature value. PLease enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("No input provided. Please enter a valid number.");
            }
        }

        int choice = 0; // choice default value is 0
        bool validChoice  = false; // choice default value is false
        while (!validChoice)
        {   // Use the provide information to the user nad know what kind of service they will use
            Console.WriteLine("Choose conversion direction:");
            Console.WriteLine("[1] Celsius to Farenheit");
            Console.WriteLine("[2] Fahrenheit to Celsius");
            Console.Write("Enter your choice(1 or 2)");

            // The Console.ReadLine() use to have methods that user can input their choices like cin in C++
            string? input = Console.ReadLine();
            if (input != null)
            {   // The Method int.TryParse convert the input string into integer
                // (input, out choice) && (choice == 1 || choice ==2) is the condition need to enter in the loop and  flow controls
                validChoice = int.TryParse(input, out choice) && (choice == 1 || choice ==2);

                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                }
            }
            else
            {
                Console.WriteLine("No input provided. Please enter 1 or 2.");
            }
        }
        //Conditional statement that if the use input number 1 this code will be access
        if (choice == 1)
        {   // This block of code get converted value and output it in readable form from Celsius to Fahrenheit
            double convertedFTemperature = CelsiusToFahrenheit(temperature);
            Console.WriteLine($"{temperature}°C is equal to {convertedFTemperature:F2}°F");
        }
        else if (choice == 2)
        {   // This block of code get converted value and output it in readable form from Fahrenheit to Celsius
            double convertedCTemperature = FahrenheitToCelsius(temperature);
            Console.WriteLine($"{temperature}°F is equal to {convertedCTemperature:F2}°C");

        } 
    }
}