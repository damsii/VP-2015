﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_2
{
    class Program
    {   /*
         ** author: Damjan Miloshevski
         ** contact: d.miloshevski@gmail.com;
         ** skype: damjan.milosevski
         ** phone: +38978566409;
         ** web: https://www.facebook.com/damjan.miloshevski
                 http://miloshevski.us.to/
       */
        static void Main(string[] args)
        {
            Console.WriteLine("------ PROGRAMA ZA BROEVI. VIZUELNO PROGRAMIRANJE - LAB. 1 ------");
            Console.WriteLine();
            Console.WriteLine("Izberi:");
            Console.WriteLine();
            Console.WriteLine("1 - Vnesi rachno");
            Console.WriteLine("2 - Generiraj avtomatski");
            Console.WriteLine("3 - Izlezi");
            Console.WriteLine();
            Console.Write("Vashiot izbor e? ");

            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine("------ RACHNO VNESUVANJE ------ ");
                            Console.WriteLine();
                            Console.Write("Kolku broevi kje vnesete? ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            int[] numbers = new int[n];
                            int min = int.MaxValue;
                            int max = int.MinValue;
                            double avg = 0;
                            double sum = 0;
                            int i;
                            Console.WriteLine();
                            Console.WriteLine("Vnesete gi vashite broevi:");
                            Console.WriteLine();
                            for (i = 0; i < n; i++)
                            {
                                Console.Write("Broj {0} = ", i + 1);
                                numbers[i] = Convert.ToInt32(Console.ReadLine());
                                if (numbers[i] > max)
                                {
                                    max = numbers[i];
                                }
                                if (numbers[i] < min)
                                {
                                    min = numbers[i];
                                }
                                sum += numbers[i];
                                avg = sum / n;

                            }
                            Console.WriteLine();
                            Console.WriteLine("Vashite broevi se:");
                            for (i = 0; i < n; i++)
                            {

                                Console.Write("{0} ", numbers[i]);

                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(string.Format("Suma = {0:#.##} | Prosek = {1:#.##} | Minimum = {2:#.##} | Maximum = {3:#.##}", sum, avg, min, max));
                            Console.WriteLine();
                            Console.WriteLine("Pritisnete bilo koe kopce da izlezete.");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("------ AVTOMATSKO GENERIRANJE ------ ");
                            Console.WriteLine();
                            Console.Write("Kolku broevi da se generiraat? ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            int[] numbers = new int[n];
                            int min = int.MaxValue;
                            int max = int.MinValue;
                            double avg = 0;
                            double sum = 0;
                            int i;
                            Random rand = new Random();
                            for (i = 0; i < n; i++)
                            {

                                numbers[i] = rand.Next(1, 1000);
                                if (numbers[i] > max)
                                {
                                    max = numbers[i];
                                }
                                if (numbers[i] < min)
                                {
                                    min = numbers[i];
                                }
                                sum += numbers[i];
                                avg = sum / n;

                            }
                            Console.WriteLine();
                            Console.WriteLine("Vo opseg [1,1000], vashite broevi se:");
                            Console.WriteLine();
                            for (i = 0; i < n; i++)
                            {

                                Console.Write("{0} ", numbers[i]);

                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(string.Format("Suma = {0:#.##} | Prosek = {1:#.##} | Minimum = {2:#.##} | Maximum = {3:#.##}", sum, avg, min, max));
                            Console.WriteLine();
                            Console.WriteLine("Pritisnete bilo koe kopce da izlezete.");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine("------ IZLEZ ------");
                            Console.WriteLine();
                            Console.WriteLine("Se otkazuvate :(. Izbravte izlez. Programata sega kje zavrshi.");
                            Console.WriteLine();
                            Console.WriteLine("Pritisnete bilo koe kopche da izlezete.");
                            break;
                        }
                    default:
                        Console.WriteLine("Nevaliden izbor. Programata sega kje zavrshi.");
                        Console.WriteLine("Pritisnete bilo koe kopce da izlezete.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Pogreshen vlez. Ve molime startuvajte ja programata odnovo.");
                Console.WriteLine("Pritisnete bilo koe kopche da izlezete.");
            }
            Console.ReadKey();
        }
    }
}
