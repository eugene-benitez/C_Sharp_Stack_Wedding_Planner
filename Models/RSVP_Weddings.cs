using System.Collections.Generic;
using Wedding_Planner.Models;

namespace Wedding_Planner.Models
{
    public class User_Weddings
    {
        public Wedding Wedding { get; set; }
        public IEnumerable<User> User { get; set; }
    }
}