namespace WaveAndPlay.Web.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinNumberOfPlayers { get; set; }
        public int MaxNumberOfPlayers { get; set; }
        public string Description { get; set; }

        public Discipline(int id, string name, int minNumbersOfPlayers, int maxNumberOfPlayers, string description)
        {
            Id = id;
            Name = name;
            MinNumberOfPlayers = minNumbersOfPlayers;
            MaxNumberOfPlayers = maxNumberOfPlayers;
            Description = description;
        }
    }
}
