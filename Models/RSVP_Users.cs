using System.Collections.Generic;
using Wedding_Planner.Models;

namespace Wedding_Planner.Models
{
    public class Weddings_User
    {
        public User User { get; set; }
        public IEnumerable<Wedding> Wedding { get; set; }
    }
}