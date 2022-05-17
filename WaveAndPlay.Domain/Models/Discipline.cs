using System;
using System.Collections.Generic;
using System.Text;

namespace WaveAndPlay.Domain.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
    }
}
