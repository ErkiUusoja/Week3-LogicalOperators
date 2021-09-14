using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada kasutajatunnus;
            //programm küsib kasutajal sisestada parool;
            //programm kontrollib, kas mõlemad nii kasutajatunnus
            //kui ka parool on õiged
            //kui mõlemad, kasuajatunnus ja parool on õiged
            //programm kuvab konsoolis "Tere tulemast!"
            //kui kasutajatunnus või parool on vale, siis
            //programm kuvab "sisselogimine ebaõnnestus. Proovi uuesti."
            //kt: admin, pr:admin1234

            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string userPassWord = Console.ReadLine();

            if (userName == "admin" && userPassWord == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Sisselogimine ebaõnnestus, proovi uuesti!");
            }



            

        }
    }
}
