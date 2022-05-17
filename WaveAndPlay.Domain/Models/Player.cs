using System;
using System.Collections.Generic;
using System.Text;

namespace WaveAndPlay.Domain.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual ICollection<TeamPlayer> PlayerTeams { get; set; }
        public virtual ICollection<MatchPlayer> PlayerMatches { get; set; }
        public virtual ICollection<Match> OrganizedMatches { get; set; } 
    }
}
