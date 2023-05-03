using System;

namespace ArcadeScore.Domain.Entities
{
    public class Score
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Points { get; set; }
        public string Player { get; set; }
    }
}
