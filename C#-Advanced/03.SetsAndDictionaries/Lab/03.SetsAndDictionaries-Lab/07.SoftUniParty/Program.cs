using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string guest = Console.ReadLine(); ;
            bool isPartyStarted = false;

            while (guest  != "END")
            {
                if (Char.IsNumber(guest, 0))
                {
                    vipGuests.Add(guest);
                }
                else if (guest.Length == 8)
                {
                    regularGuests.Add(guest);
                }

                if (guest == "PARTY")
                {
                    isPartyStarted = true;

                    while (guest != "END")
                    {
                        guest = Console.ReadLine();

                        if (vipGuests.Contains(guest))
                        {
                            vipGuests.Remove(guest);
                        }
                        else if (regularGuests.Contains(guest))
                        {
                            regularGuests.Remove(guest);
                        }
                    }
                }

                if (isPartyStarted)
                {
                    break;
                }

                guest = Console.ReadLine();
            }

            int didNotCome = vipGuests.Count + regularGuests.Count;

            Console.WriteLine(didNotCome) ;

            foreach (string item in vipGuests)
            {
                Console.WriteLine(item);
            }

            foreach (string item in regularGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
