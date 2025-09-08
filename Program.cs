namespace TheEmergencyRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*setup of global variables that 
            are used throughout the program*/

            bool validAgeInput = false;
            bool validTemperatureInput = false;
            int age = 0;
            double temperature = 0;

            bool isShortOfBreath = false;
            bool hasChestPains = false;
            bool hasBigBleeding = false;
            int painLevel = 0;
            bool validPainLevelInput = false;

            string priority = "TBD";

            Console.WriteLine("Välkommen till akuten, vänligen skriv in patientens namn:");
            string? name = Console.ReadLine();

            Console.WriteLine($"Okej {name}, ta det bara lugnt, vi ska hjälpa dig! Hur gammal är du?");

            //Makes sure we get a valid input for age
            while (!validAgeInput)
            {
                validAgeInput = int.TryParse(Console.ReadLine(), out age);

                if (!validAgeInput)
                {
                    Console.WriteLine($"Oj, det var illa däran med dig, {name}. Försök skriva in din ålder igen, med siffror");

                }
            }

            Console.WriteLine($"Bra, har du en febertemperatur som du kan ge oss?");

            //Makes sure we get a valid input for temperature, using double
            //in case we get decimal numbers
            while (!validTemperatureInput)
            {
                validTemperatureInput = double.TryParse(Console.ReadLine(), out temperature);

                if (!validTemperatureInput)
                {
                    Console.WriteLine($"Oj, det var illa däran med dig, {name}. Försök skriva in din temperatur igen, med siffror");

                }
            }

            //display given information
            Console.WriteLine($"Okej, vad bra, då har vi dina grundläggande uppgifter. Du heter {name}, {age} år gammal, och din nuvarande temperatur är {temperature}");
            Console.WriteLine("\nNu ska vi ta lite snabb hälsostatus på dig bara för triagen.");

            //each block takes response, makes it lower case and changes bool only if needed
            Console.WriteLine("Har du svårt att andas? ja/nej");
            string? breathingResponse = Console.ReadLine().ToLower();

            if (breathingResponse == "ja")
            {
                isShortOfBreath = true;
            }

            Console.WriteLine("Okej, hur är det med bröstsmärtor, har du såna? ja/nej");
            string? chestPainResponse = Console.ReadLine().ToLower();

            if (chestPainResponse == "ja")
            {
                hasChestPains = true;
            }

            Console.WriteLine("Jag förstår, är det så att du blöder också? Mycket menar jag då. ja/nej");
            string? bleedingResponse = Console.ReadLine().ToLower();

            if ( bleedingResponse == "ja")
            {
                hasBigBleeding = true;
            }

            Console.WriteLine($"Och så var det det här med smärtan {name}, på en skala 0-10, hur ont har du?");

            while (!validPainLevelInput)
            {
                validPainLevelInput = int.TryParse(Console.ReadLine(), out painLevel);

                if (!validPainLevelInput)
                {
                    Console.WriteLine($"Oj, det var illa däran med dig, {name}. Försök skriva in din smärtnivå igen, med siffror");

                }
            }

            //Debug log below, ignore
            //Console.WriteLine($"Okej {name} vi har fått följande info:\nandiningsbesvär: {isShortOfBreath} \nbröstsmärtor: {hasChestPains} \nblödning: {hasBigBleeding}\nUpplevd smärta: {painLevel}");

            if ((isShortOfBreath || hasChestPains) || hasBigBleeding || (temperature > 40 && (age < 1 || age > 75)))
            {
                priority = "RÖD";
                Console.WriteLine($"{name}, du har en del alarmsymptom så vi kommer ge dig prio {priority}");
            }
            else if (temperature >= 38 || painLevel >= 7)
            {
                priority = "GUL";
                Console.WriteLine($"Så, {name}, dina symptom är oroande, men inte livshotande. Du kommer få prio {priority}");
            }
            else
            {
                priority = "GRÖN";
                Console.WriteLine($"Just nu är dina symptom inte så alarmerande, {name}, men vi kommer fortsatt hålla koll på dig. Du får prio {priority}");
            }
        }
    }
}
