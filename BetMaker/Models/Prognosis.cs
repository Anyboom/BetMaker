﻿namespace BetMaker.Models
{
    public class Prognosis
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
