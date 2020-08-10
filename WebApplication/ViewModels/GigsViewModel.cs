using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public object Heading { get; set; }
    }
}