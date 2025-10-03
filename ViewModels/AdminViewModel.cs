using System.Collections.Generic;
using GiftOfTheGivers.Models;

namespace GiftOfTheGivers.ViewModels
{
    public class AdminViewModel
    {
        public List<User> Users { get; set; }
       
        public List<Incident> Incidents { get; set; }
    }
}
