using System;

abstract class TicketBooking
{
    public void ShowBookingInfo() => Console.WriteLine("Booking tickets");
    public abstract void BookTicket(int seats);
}

class BusBooking : TicketBooking
{
    public override void BookTicket(int seats) => 
        Console.WriteLine($"Booking {seats} bus tickets");
}

class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats) => 
        Console.WriteLine($"Booking {seats} flight tickets");
}

class Program
{
    static void Main()
    {
        TicketBooking bus = new BusBooking();
        TicketBooking flight = new FlightBooking();
        
        bus.ShowBookingInfo();
        bus.BookTicket(3);
        
        flight.ShowBookingInfo();
        flight.BookTicket(2);
    }
}