using System;
using System.Collections.Generic;
using System.Text;

namespace WaveAndPlay.Domain.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}
