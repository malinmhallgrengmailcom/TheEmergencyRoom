namespace TheEmergencyRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validAgeInput = false;
            bool validTemperatureInput = false;
            int age = 0;
            double temperature = 0;

            bool isShortOfBreath = false;
            bool hasChestPains = false;
            bool hasBigBleeding = false;
            int painLevel = 0;
            bool validPainLevelInput = false;

            Console.WriteLine("Välkommen till akuten, vänligen skriv in patientens namn:");
            string? name = Console.ReadLine();

            Console.WriteLine($"Okej {name}, ta det bara lugnt, vi ska hjälpa dig! Hur gammal är du?");

            while (!validAgeInput)
            {
                validAgeInput = int.TryParse(Console.ReadLine(), out age);

                if (!validAgeInput)
                {
                    Console.WriteLine($"Oj, det var illa däran med dig, {name}. Försök skriva in din ålder igen, med siffror");

                }
            }

            Console.WriteLine($"Bra, har du en febertemperatur som du kan ge oss?");

            while (!validTemperatureInput)
            {
                validTemperatureInput = double.TryParse(Console.ReadLine(), out temperature);

                if (!validTemperatureInput)
                {
                    Console.WriteLine($"Oj, det var illa däran med dig, {name}. Försök skriva in din temperatur igen, med siffror");

                }
            }

            Console.WriteLine($"Okej, vad bra, då har vi dina grundläggande uppgifter. Du heter {name}, {age} år gammal, och din nuvarande temperatur är {temperature}");
            Console.WriteLine("Nu ska vi ta lite snabb hälsostatus på dig bara för triagen.");

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

            Console.WriteLine($"Okej {name} vi har fått följande info:\nandiningsbesvär: {isShortOfBreath} \nbröstsmärtor: {hasChestPains} \nblödning: {hasBigBleeding}\nUpplevd smärta: {painLevel}");
            
        }
    }
}
