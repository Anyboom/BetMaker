namespace BetMaker.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
