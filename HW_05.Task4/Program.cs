using System;
using System.Collections.Generic;
using System.Text;

namespace HW_05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zips = new List<string>() { "OH 43071", "NY 56432" };
            String addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432,456 High Street WithoutName NY 5632";
            String[] splittedAddress = addresses.Split(',');

            for (int i = 0; i < splittedAddress.Length; i++)
            {
                String zipCodeOfStreet = splittedAddress[i].Substring(splittedAddress[i].Length - 8);

                if (zips.Contains(zipCodeOfStreet))
                {
                    String[] splittedAddressRow = splittedAddress[i].Split(' '); // разбили строчку отдельного адреса, чтобы получить потом отсюда номер улицы [элемент на позиции 0]
                    string ad = splittedAddress[i].Substring(splittedAddressRow[0].Length, splittedAddress[i].Length - 9); // получаем улицу, отбрасывая номер улицы и zip 

                    StringBuilder streetName = new StringBuilder(ad);
                    StringBuilder streetNumber = new StringBuilder(splittedAddressRow[0]);

                    for (int z = i+1; z < splittedAddress.Length; z++) // доп. цикл, чтобы собрать названия улиц и их номера для однго и того же zip
                    {
                        String zipCodeOfStreet1 = splittedAddress[z].Substring(splittedAddress[z].Length - 8);

                        if (zipCodeOfStreet1.Equals(zipCodeOfStreet))
                        {
                            String[] splittedAddressRow1 = splittedAddress[z].Split(' ');
                            string ad1 = splittedAddress[z].Substring(splittedAddressRow1[0].Length, splittedAddress[z].Length - 9);
                            streetName.Append(" ,");
                            streetName.Append(ad1);
                            streetNumber.Append(" ,");
                            streetNumber.Append(splittedAddressRow1[0]);
                        }
                    }

                    Console.WriteLine($"{zipCodeOfStreet}:{streetName}/{streetNumber}");
                }
                else
                {
                    String[] splittedAddressRow = addresses.Split(' ');
                    string zipIncorrect = splittedAddressRow[splittedAddressRow.Length - 1] + splittedAddressRow[splittedAddressRow.Length - 2];
                    Console.WriteLine($"{zipIncorrect}:/");
                }
            }
        }
    }
}
