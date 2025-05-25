using System;

namespace Quiz
{
    class Program
    {

        static string[] suallar = new string[]
        {
            "1. Dunyanin en uzun cayi hansidir?",
            "2. Romeo ve Culoet eserinin muellifi kimdir?",
            "3. Hansi planet qirmizi planet adlanir?",
            "4. Dunyanin en boyuk okeani hansidir?",
            "5. Suyun donma tempraturu nece derecedir?",
            "6. Hansi ixtiraci elektrik lampasini kesf edib?",
            "7. Komputerin esas beyni nedir?",
            "8. Azerbaycan respublikasinin milli musiqi aleti hansidir?",
            "9. Hansi olke Avropanin en boyuk erazisine sahibdir?",
            "10. NASA hansi sahede fealiyyet gosterir?"
        };

        static string[,] variantlar = new string[,]
        {
            {"a) Nil", "b) Amazon", "c) Missisipi"},
            {"a) Tolstoy", "b) Sekspir", "c) Dostoyevski"},
            {"a) Yupiter", "b) Mars", "c) Merkuri"},
            {"a) Hind okeani", "b) Atlantik okean", "c) Sakit okean"},
            {"a) 0 derece", "b) 10 derece", "c) -10 derece"},
            {"a) Edison", "b) Tesla", "c) Paskal"},
            {"a) Ram", "b) CPU", "c) Hard disk"},
            {"a) Qaval", "b) Tar", "c) Balabal"},
            {"a) Almanya", "b) Fransa", "c) Rusiya"},
            {"a) Herbi texnologiya", "b) Kimya senayesi", "c) Kosmos arasdirmalari"}
        };

        static string[] cavablar = new string[]
        {
            "a", "b", "b", "c", "a", "a", "b", "b", "c", "c"
        };
        static void Main(string[] args)
        {
            int xal = 0;
            Random rand = new Random();

            for (int i = 0; i < suallar.Length; i++)
            {
                int number = rand.Next(i, suallar.Length);

                string tempSual = suallar[i];
                suallar[i] = suallar[number];
                suallar[number] = tempSual;

                for (int j = 0; j < 3; j++)
                {
                    string tempVariant = variantlar[i, j];
                    variantlar[i, j] = variantlar[number, j];
                    variantlar[number, j] = tempVariant;
                }

                string tempCavab = cavablar[i];
                cavablar[i] = cavablar[number];
                cavablar[number] = tempCavab;
            }

            for (int i = 0; i < suallar.Length; i++)
            {
                Console.ResetColor();
                Console.WriteLine(suallar[i]);

                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine(variantlar[i, k]);
                }
                Console.WriteLine("Duzgun cavabi secin (a,b,c): ");
                string cavab = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cavab))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Siz hec ne daxil etmemisiz!");
                }

                if (cavab == cavablar[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tebrikler! Siz suala duzgun cavab verdiniz!");
                    xal += 10;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cavabiniz yanlisdir!");
                    xal -= 10;
                }

                Console.ResetColor();
                Console.WriteLine();
            }

            Console.WriteLine("Yaris bitdi, sizin topladiginiz umumi xal: " + xal);
        }
        }
}
