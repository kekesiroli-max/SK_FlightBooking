namespace FlightBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egyik teszt
            Flight flight1 = new Flight("FR001", "London", 25000, 3);
            Flight flight2 = new Flight("FR002", "Budapest", 10000, 1);

            flight2.BookSeat();
            flight2.BookSeat();

            Console.WriteLine(flight1.Describe());
            Console.WriteLine(flight2.Describe());

            // Másik teszt
        }
    }
}
