using System;
using System.Collections.Generic;
using System.Text;

namespace WaveAndPlay.Domain.Models
{
    public class Match
    {
        public int Id { get; set; }     
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int MinNumberOfPlayers { get; set; }
        public int MaxNumberOfPlayers { get; set; }
        public int NumberOfTeams { get; set; }
        public float FullAmount { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public int DisciplineId { get; set; }
        public virtual Discipline Discipline { get; set; }
        public virtual ICollection<MatchPlayer> MatchPlayers { get; set; }
        public int OrganizerId { get; set; }
        public virtual Player Organizer { get; set; }
    }
}
