using System;

namespace WaveAndPlay.Web.Models
{
    public class Match
    {
        public int Id { get; set; }
        public Player Organizer { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Discipline Discipline { get; set; }
        public int MinNumberOfPlayers { get; set; }
        public int MaxNumberOfPlayers { get; set; }
        public int NumberOfTeams { get; set; }
        public Address Address { get; set; }

        public Match(int id, Player organizer, DateTime startDateTime, DateTime endDateTime, Discipline discipline, 
            int minNumberOfPlayers, int maxNumberOfPlayers, int numberOfTeams, Address address)
        {
            Id = id;
            Organizer = organizer;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            Discipline = discipline;
            MinNumberOfPlayers = minNumberOfPlayers;
            MaxNumberOfPlayers = maxNumberOfPlayers;
            NumberOfTeams = numberOfTeams;
            Address = address;
        }
    }
}
