using System;

namespace PasswordCheck
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input our password  ");
            string password = Console.ReadLine();
            ParolChecker parol = new ParolChecker();
            int score =  parol.ChecPassward(password);
            Console.Write(score.ToString());
            
        }
    }
}