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
        public string HomeTeam { get; set; }
        public string GuestTeam { get; set; }
        public string Prognosis { get; set; }
        public string EventName { get; set; }
        public float Сoefficient { get; set; }
        public BetStatus Result { get; set; }
        public DateTime EventTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
