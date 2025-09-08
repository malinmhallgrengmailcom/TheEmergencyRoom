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
        }
    }
}
