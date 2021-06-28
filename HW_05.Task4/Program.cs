using System;
using System.Collections.Generic;
using System.Text;

namespace HW_05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zips = new List<string>() {"OH 43071", "NY 56432" };
            String addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432,456 High Street WithoutName NY 5632";
            String[] splittedAddress = addresses.Split(',');

            for (int i = 0; i < splittedAddress.Length; i++) // адреса выводятся в нужном формате, но не сгруппированы по индексу
            {
                String zipCodeOfStreet = splittedAddress[i].Substring(splittedAddress[i].Length-8);
                if (zips.Contains(zipCodeOfStreet))
                {
                    String[] splittedAddress1 = splittedAddress[i].Split(' ');
                    string ad = splittedAddress[i].Substring(splittedAddress1[0].Length, splittedAddress[i].Length - 9);
                    Console.WriteLine($"{zipCodeOfStreet}:{ad}/{splittedAddress1[0]}");
                }
                else
                {
                    String[] splittedAddress1 = addresses.Split(' ');
                    string zipIncorrect = splittedAddress1[splittedAddress1.Length - 1] + splittedAddress1[splittedAddress1.Length - 2];
                    Console.WriteLine($"{zipIncorrect}:/");
                }
            }
        }
    }
}
