
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Globalization;

namespace IntroUlohy {


    class Program {

         static void UlohaPremenne() {
            // Napíš jednoduchý program kde vytvoríš 10 premenných.
            // 3 premenným nepriraď hodnotu a 4 premenným priraď hodnotu. 
            // Pre zvyšné 3 premenné im priraď hodnotu z inej premennej. 
            int a = 12;
            string abeceda = "Abeceda";
            bool run = true;
            bool isEmpty = false;
            long  cislo;
            char znak;
            short cislo2;
            bool isRunnig = run;
            int b = a;
            string slovo = abeceda;
         }
        static void FizzBuzz() { 
            //Maj číslo.Ak číslo bude deliteľné číslom 3, tak na výpise konzoly bude text Fizz
            //ak bude deliteľné číslom 5, tak na výpise bude text Buzz.
            //Ak bude číslo zároveň deliteľné 3 a aj 5, tak vypíš FizzBuzz.

            Console.WriteLine("Napis cislo: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");

            }
            else if (number % 3 == 0) {
                Console.WriteLine("Fizz");
            }
            else if(number % 5 == 0) {
                Console.WriteLine("Buzz");
            }

        }

        static void TernarnyOperator() {
            //Napíš program, ktorý na konzolu vypíš či je číslo deliteľné dvomi alebo nie za pomoci ternárneho operátoru. Nemôžeš použiť if.
            //Napíš program, ktorý na konzolu vypíše či je číslo > ako 10, < ako 10 alebo = 10 za pomoci ternárneho operátoru v ternárnom operátore. Nemôžeš použiť if.

            Console.WriteLine("Napis Cislo: ");
            int number = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"cislo {number}  {((number % 2) == 0 ? "je delitelne 2": "nie je delitelne 2" )}");
            Console.WriteLine($"cislo {number} {(number > 10 ? "je vacsie ako 10" : (number == 10 ? "je rovne 10" : "je mensie ako 10"))}");


        }

        //Vytvor tri jednoduché metódy:
        // 1. metóda bude vracať String - podobne ako vo videu
        // 2. metóda bude vracať int
        // 3. metóda nebude vracať nič, namiesto toho bude vypisovať text na konzolu

        static String MenoAPriezvisko(String meno, String priezvisko) {
            return meno + " " + priezvisko;
        }
        static void VypisVseko() {
            Console.WriteLine($"{Convert.ToString(10)} + {Convert.ToString(20)} = {Convert.ToString(Scitaj(10, 20))} ");

            string mp = MenoAPriezvisko("Ivan", "Hrozny");
            Console.WriteLine(mp);

        }

        static int Scitaj(int a, int b) {
            return a + b; 
        }

        //Napíš metódu, ktorá premení minúty na sekundy. Na vstupe metódy bude počet minút a na výstupe bude počet sekúnd.
        static int ConvertToSeconds(int minutes) {
            return minutes * 60; 
        }

        static void VykresliZostupne(int number) {
            int a = number;
            for (int i = 0; i < number; i++) {
                for(int j = a; j > 0; j--) {
                    Console.Write("*");
                }
                a--;
                Console.WriteLine();
            }
        }

        static void VykresliVzostupne(int number) {
            int a = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= a; j++)
                {
                    Console.Write("*");
                }
                a++;
                Console.WriteLine();
            }


        }

        static void Prepinac() {
            /*
             * Napíš program, ktorý na základe čísla napíše hlášku. Ak 1, tak sa vypíše: Je pondelok. Ak 2, tak sa vypíše: Je utorok. A tak podobne pre všetky dni. Jedine ak 6 alebo 7, tak sa vypíše: Je víkend. Ak by si mal hocičo iné, tak na konzolu napíšeš: Nezadal si dobré číslo dňa.
            */
            Console.WriteLine("Zadaj cislo od 1 po 7 ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Je pondelok");
                    break;
                case 2:
                    Console.WriteLine("Je utorok");
                    break;
                case 3:
                    Console.WriteLine("Je streda");
                    break;
                case 4:
                    Console.WriteLine("Je stvrtok");
                    break;
               case 5:
                    Console.WriteLine("Je piatok");
                    break;
                case > 5 and <= 7:
                    Console.WriteLine("Je vikend");
                    break;
                default:
                    Console.WriteLine("Zadal si zle cislo");
                    break;
            }

        }
        static void Priemer(int[] array) {
            //Napíš program, ktorý vytvorí priemer zo známok (ľubovoľný počet int-ov) a na konzolu za pomoci switchu napíš akú známku bude na vysvedčení. Ak je priemer > 1.5 tak na vysvedčení bude 2. Ak je priemer < ako 1.5, tak na vysvedčení bude 1, takto to sprav pre všetky známky.

            double sum = 0;
            for (int i = 0; i < array.Length; i++) { 
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine($"Priemer znamok je: {average}");

            if (average < 1.5)
            {
                Console.WriteLine("Vysledna znamka je 1");
            }
            else if (average < 2.5)
            {
                Console.WriteLine("Vysledna znamka je 2");
            }
            else if (average < 3.5)
            {
                Console.WriteLine("Vysledna znamka je 3");

            }
            else if (average < 4.5)
            {
                Console.WriteLine("Vysledna znamka je 4");

            }
            else {
                Console.WriteLine("Vysledna znamka je 5");

            }

        }
        /*
         - Maj dvojrozmerné pole kde vnútorné polia majú dĺžku > 5. Na konzolu vypíš prvé dve čísla z každého poľa.
         - Na konzolu vypíš súčet a násobok všetkých čísel v jednorozmernom poli.
         - Na konzolu vypíš súčet a násobok všetkých čísel v dvojrozmernom poli.
         - Maj dvojrozmerné pole o ľubovoľnej dĺžke. Na konzolu vypíš súčet 0tých, 1vých ... ntých (indexi) čísel v poliach.
         */

        static void PracaSPolom() {
            Random random = new Random();
            int[][] array = new int[5][];
            int sumOne = 0;
            double nasobenieOne = 1;
            double sumTwo = 0;
            double nasobenieTwo = 1;
            array[0] = new int[6];
            array[1] = new int[7];
            array[2] = new int[8];
            array[3] = new int[9];
            array[4] = new int[9];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++) {
                    int number = random.Next(0, 100);
                    array[i][j] = number;
                    Console.Write($" {array[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");
            //Na konzolu vypíš prvé dve čísla z každého poľa.
            for (int i = 0; i < array.GetLength(0); i++) {

                for (int j = 0; j < array[i].Length; j++)
                {
                    if (i == 0) { 
                        sumOne += array[i][j];
                        nasobenieOne *= array[i][j];
                    }

                    if (j == 0 || j == 1) {
                        Console.Write($" {array[i][j]} ");
                    }

                    sumTwo += array[i][j];
                    nasobenieTwo *= array[i][j];

                    
                }
                Console.WriteLine() ;
            }
            Console.WriteLine($"Sucet cisel je {sumOne} a nasobok {nasobenieOne}");
            Console.WriteLine($"Sucet cisel celeho pola je {sumTwo} a nasobok {nasobenieTwo}");



        }
        //Napíš metódu, ktorá vstupný string zmení na všetko veľké písmená a vypíše ho na konzolu
        static string Velke(string sentence) {
            return sentence.ToUpper();
        }

        //Napíš metódu, ktorá porovná dva string parametre a na konzolu napíše true ak su rovnaké a false ak nie sú rovnaké.
        static void Porovnaj(string sentence, string sentence2) {

            if (sentence.Equals(sentence2))
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
        }
        //Predošlú metódu uprav tak, aby namiesto výpisu true a false vrátila boolean true alebo false. 
        static bool Porovnaj1(string sentence, string sentence2)
        {

            if (sentence.Equals(sentence2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        static void Main(string[] args)
        {
        int[][] arrayOfInts = new int [5][];
        arrayOfInts[0] = new int[10];
        int counter = 0;
            //while (counter < 5) {
            //    Console.WriteLine($"counter = {counter}");
            //    counter++;
            //}

            /*
            int[][] ints = new int[3][];
            ints[0] = new int[10];
            ints[1] = new int[] { 10, 25 };
            ints[2] = new int[2];

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints[i].Length; j++) { 
                    Console.WriteLine(ints[i][j]);
                }

            }
            */
            //FizzBuzz();
            //TernarnyOperator();
            //VypisVseko();
            //int minutes = 30;
            //int seconds = ConvertToSeconds(minutes); 
            //Console.WriteLine(seconds);
            //Vykresli(5)

            //VykresliVzostupne(5);
            //Prepinac();
            //Prepinac();
            //int[] array = { 1, 2, 3, 4, 5, 4, 4, 2, 5, 5, 5, 3 };
            //Priemer(array);
            //PracaSPolom();
            string veta = "Dnes je krasny den";
            string veta2 = "Dnes je krasny den1";

            Console.WriteLine(Velke(veta));

            Porovnaj(veta, veta2);
        }

    }
}