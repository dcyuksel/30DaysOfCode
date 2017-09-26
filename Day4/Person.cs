namespace Day4
{
    using System;

    public class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                this.age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }

            this.age = initialAge;
        }

        public void amIOld()
        {
            if (this.age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (this.age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            this.age++;
        }
    }
}
