using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1717 Adamstown Place", "Arlington", "TX", "USA");
        Address address2 = new Address("242 ByBee Dugway Road", "Rexburg", "ID", "USA");
        Address address3 = new Address("38 Abington Woods Drive", "Aurora", "IL", "USA");

        Event lecture = new Lecture("The Acting Icon Speaks!", "Meet the legendary actor, Morgan Freeman, in person and get to learn from his years of acting!", address1, "12/2/2024", "5:00pm", "Morgan Freeman");
        lecture.SetCapacity(500);
        Event reception = new Reception("Joshua and Lynda ties the matrimonial knot", "Don't miss it as Joshua and Lynda finally gets hitched!", address2, "30/12/2023", "10:00am");
        Event outdoor = new Outdoor("Global Cultural Day", "Aurora hold its 1st Cultural Day to promote understanding, unity, and love amongst all its communities.", address3, "27/1/2024", "4:00pm", "Sunny");

        Console.WriteLine("Short Descriptions:");
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine(outdoor.ShortDescription());

        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(lecture.StandardDetails() + "\n");
        Console.WriteLine(reception.StandardDetails() + "\n");
        Console.WriteLine(outdoor.StandardDetails() + "\n");

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.FullDetails() + "\n");
        Console.WriteLine(reception.FullDetails() + "\n");
        Console.WriteLine(outdoor.FullDetails() + "\n");
    }
}