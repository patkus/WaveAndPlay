namespace WaveAndPlay.Web.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TeamStatus Status { get; set; }

        public Team(int id, string name, TeamStatus status)
        {
            Id = id;
            Name = name;
            Status = status;
        }

        public enum TeamStatus
        {
            Public = 0,
            Private = 1
        }
    }
}
