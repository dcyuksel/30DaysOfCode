namespace Day16
{
    using System;

    public class Program
    {
        public static void Main(String[] args)
        {
            var S = Console.ReadLine();

            try
            {
                Console.WriteLine(Convert.ToInt32(S));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}