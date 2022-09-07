using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;
using WebAppDETAug2022.Service;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        //public void OnGet()
        //{
        //    Tickets = new list <Ticket>
        //    {
        //        new Ticket{Category="platinumplus", Price=5000, MaxLimit=200000},
        //         new Ticket{Category="platinum", Price=4000, MaxLimit=300000},
        //          new Ticket{Category="Gold", Price=3000, MaxLimit=500000},
        //           new Ticket{Category="silver", Price=2000, MaxLimit=500000},
        //            new Ticket{Category="General", Price=800, MaxLimit=100000},

        //    };
        //}

        public void OnGet()
        {
            Tickets = TicketService.GetAll();
        }
    }
}
