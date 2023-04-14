namespace Events.API.Models
{
    public class EventModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public EventModel(int? id, string name, string description, DateTime date)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
        }
    }
}