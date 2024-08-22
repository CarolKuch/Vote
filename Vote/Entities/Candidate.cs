namespace Vote.Entities
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasVoted { get; set; }
    }
}
