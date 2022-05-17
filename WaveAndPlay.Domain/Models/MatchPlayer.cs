using System;
using System.Collections.Generic;
using System.Text;

namespace WaveAndPlay.Domain.Models
{
    public class MatchPlayer
    {
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public float AmountToPay { get; set; }
        public virtual Player Player { get; set; }
        public virtual Match Match { get; set; }
    }
}
