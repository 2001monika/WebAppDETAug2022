using APIDemo.Controllers;
using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Models.Ticket> Tickets { get; }

        static TicketService()
        {
            Tickets = new List<Models.Ticket> {
            new Models.Ticket { ID=1, BookedFor = "platinumplus", Price = 5000, Qty = 200000 },
            new Models.Ticket { ID=2, BookedFor= "platinum", Price = 4000, Qty = 300000 },
            new Models.Ticket { ID=3, BookedFor = "Gold", Price = 3000, Qty = 500000 },
            new Models.Ticket { ID=4, BookedFor = "silver", Price = 2000, Qty = 500000 },
            new Models.Ticket { ID=5, BookedFor = "General", Price = 800, Qty = 100000 },
            };
        }

        public static List<Models.Ticket> GetAll() => Tickets;


        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x => x.ID == id);
            return ticket;
        }

       
    }
}
