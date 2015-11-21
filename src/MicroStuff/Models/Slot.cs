using System;

namespace MicroStuff.Models
{
    public class Slot
    {
        public Slot()
        {
            
        }
        
        public Slot(int id, string start, string end)
        {
            Id = id;
            Start = TimeSpan.Parse(start);
            End = TimeSpan.Parse(end);
        }
        
		public int Id { get; set; }
        public TimeSpan Start { get; set; }
		public TimeSpan End { get; set; }
        
        public  bool Equals(Slot other) => other?.Id == this.Id;
        
        public override bool Equals(object obj) => Equals(obj as Slot);
        
        public override int GetHashCode() => this.Id;
    }
}
