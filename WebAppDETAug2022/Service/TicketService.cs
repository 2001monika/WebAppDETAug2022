using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Service
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }

        static TicketService()
        {
            Tickets = new List<Ticket> {
            new Ticket { Category = "platinumplus", Price = 5000, MaxLimit = 200000 },
            new Ticket { Category = "platinum", Price = 4000, MaxLimit = 300000 },
            new Ticket { Category = "Gold", Price = 3000, MaxLimit = 500000 },
            new Ticket { Category = "silver", Price = 2000, MaxLimit = 500000 },
            new Ticket { Category = "General", Price = 800, MaxLimit = 100000 },
            };
        }

        public static List<Ticket> GetAll() => Tickets;
       
    }
}
