using System;

namespace Day13
{
    public class MyBook : Book
    {
        public MyBook(string t, string a, int price) : base(t, a)
        {
            this.price = price;
        }

        public int price { get; private set; }

        public override void display()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("Price: " + this.price);
        }
    }
}
