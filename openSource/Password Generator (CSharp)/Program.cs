using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Generator__CSharp_
{
    class Program
    {
        static Random rand = new Random();
        static bool a;
        static string userreadline;
        static int characters;
        static string password;
        static string[] cha = { "/", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "~", "<", ">", "?", ":", "{", "}", "[", "]" };
        static string[] letters = { "A", "a", "B", "b", "C", "c", "D", "E", "e", "F", "f", "G", "g", "H", "h", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x" };
        static void Main(string[] args)
        {
            Console.WriteLine("Program made by ANDKFOX (Vadim Shirokikh - vk.com/andkfox) 2021 \n \nHow many characters should be present in your password? \n");
            userreadline = Console.ReadLine();
            characters = Convert.ToInt32(userreadline);
            Console.WriteLine("Your password must contain the following characters? \n[Y/N] \n");
            userreadline = Console.ReadLine();
            if(userreadline == "Y" || userreadline == "y")
            {
                for(int a = 0; a < characters; a++)
                {
                    int b;
                    b = rand.Next(1, 3);
                    if(b == 1)
                    {
                        password += rand.Next(0, 9);
                    }
                    if(b == 2)
                    {
                        password += letters[rand.Next(0, letters.Length)];
                    }
                    if(b == 3)
                    {
                        password += cha[rand.Next(0, cha.Length)];
                    }
                }
            }
            if(userreadline == "N" || userreadline == "n")
            {
                for (int a = 0; a < characters; a++)
                {
                    int b;
                    b = rand.Next(1, 2);
                    if (b == 1)
                    {
                        password += rand.Next(0, 9);
                    }
                    if (b == 2)
                    {
                        password += letters[rand.Next(0, letters.Length)];
                    }
                }
            }
            Console.WriteLine("Your password is ready \nPassword:   " + password);
            Console.ReadLine();

        }
    }
}
