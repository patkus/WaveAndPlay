using System;
using System.Collections.Generic;
using System.Text;

namespace WaveAndPlay.Domain.Models
{
    public class TeamPlayer
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
