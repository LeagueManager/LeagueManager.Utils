using System;
using System.Collections.Generic;

namespace LeagueManager.Utils
{
   public class Team
    {
        public string name { get; set; }
        public int wins { get; set; }
        public int loses { get; set; }
        public int rank { get; set; }
    }
    public class User
    {
        public string Name { get; set; }
        public Team Team { get; set; }
    }
}   
