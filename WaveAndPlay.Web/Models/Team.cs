namespace WaveAndPlay.Web.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Team(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
