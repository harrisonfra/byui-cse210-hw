using System;
class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("E University Parkway & Campus Dr", "Provo", "UT", "USA"); //this is the Mariott Center address
        Address receptionAddress = new Address("1125 N University Ave", "Provo", "UT", "USA");
        Address outdoorAddress = new Address("Porter Park", "Rexburg", "ID", "USA");

        Lectures lecture = new Lectures(
            "Ted Talk",
            "The Power of Code: How Programming Shapes our World", //This is a real ted talk about programming
            "April 10",
            "6:00 PM",
            lectureAddress, 
            "Neal Chopra",
            50
        );

        Receptions reception = new Receptions(
            "Wedding Reception",
            "Celebrate with us",
            "May 5",
            "7:00 PM",
            receptionAddress
        );

        Outdoorevent outdoor = new Outdoorevent(
            "Neighborhood Picnic",
            "Food and games",
            "June 1",
            "12:00 PM",
            outdoorAddress,
            "sunny"
        );

        Console.WriteLine("LECTURE EVENT");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        lecture.CapacityCheck();
        Console.WriteLine();

        Console.WriteLine("RECEPTION EVENT");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.Write("Enter name to check RSVP: ");
        string name = Console.ReadLine();
        reception.RSVPCheck(name);
        Console.WriteLine();

        Console.WriteLine("OUTDOOR EVENT");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription());
        outdoor.WeatherCheck();
    }
}