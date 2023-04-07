using System;

namespace BetMaker.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public Team HomeTeam { get; set; }
        public Team GuestTeam { get; set; }
        public Prognosis Prognosis { get; set; }
        public Competition Competition { get; set; }
        public float Coefficient { get; set; }
        public BetStatus Result { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}
