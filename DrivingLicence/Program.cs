﻿using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis "Oled liiga noor, et juhilube saada.";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis "Oled piisvalt vana, et juhilube saad.";
            //kui kasutaja on 18, siis programm kuvab konsoolis "Palju õnne! Nüüd sa saad juhilube taotleda."

            Console.WriteLine("Palun, sisesta oma sünniaasta:");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2022 - YearOfBirth;

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotelda.");
            }

        }
    }
}
