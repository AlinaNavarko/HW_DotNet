using System;
using System.Collections.Generic;

namespace HW_05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zips = new List<string>() {"OH 43071", "OH 43071"};

            String addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";

            String[] addressArray = addresses.Split(',');

            for (int i = 0; i < addressArray.Length; i++)
            {
                Console.WriteLine(addressArray[i]);
            }

            Console.WriteLine(zips);

        }
    }
}
