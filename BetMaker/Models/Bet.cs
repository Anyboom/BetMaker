using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetMaker.Models
{
    class Bet
    {
        public int Id { get; set; }
        public Team HomeTeam { get; set; }
        public Team GuestTeam { get; set; }
        public Prognosis Prognosis { get; set; }
        public Competition Competition { get; set; }
        public float Сoefficient { get; set; }
        public BetStatus Result { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

    }
}
