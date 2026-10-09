namespace FlightBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egyik teszt

            // Másik teszt
            Passenger passenger1 = new Passenger("passenger1", 9);
            Passenger passenger2 = new Passenger("passenger2", 18);


            passenger2.AddBag();
            passenger2.AddBag();
            passenger2.AddBag();

            Console.WriteLine(passenger1.Name);
            Console.WriteLine(passenger2.Name);

            Console.WriteLine(passenger1.BagCount);
            Console.WriteLine(passenger2.BagCount);

            passenger1.IsChild();
            passenger2.IsChild(),

        }
    }
}
