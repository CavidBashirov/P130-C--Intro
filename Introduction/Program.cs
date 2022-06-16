using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 55;
            int[] ages = { 12, 14, 17, 55 };

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i] + " - " + i);
            //}


            //foreach (var item in ages)
            //{
            //    Console.WriteLine(item);
            //}

            string[] names = { "Togrul", "Fidan", "Seadet", "Orxan" };

            foreach (var item in names)
            {
                if (item == "Seadet" || item == "Fidan")
                {
                    continue;
                }

                Console.WriteLine(item);



            }

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "Seadet")
            //    {
            //        Console.WriteLine(names[i]);
            //        break;
            //    }
            //}

            int sum = 0;

            foreach (var item in ages)
            {

                if(item%2 != 0)
                {
                    sum += item;
                }
            }

            Console.WriteLine(sum);



        
        }
    }
}
