using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.API.Models
{
    public class EventModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? EventId { get; set; }
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Name { get; set; }
        public string Description { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Date { get; set; }

        // public EventModel(int? eventId, string name, string description, DateTime date)
        //     :this(name, description, date)
        // {
            
        //     EventId = eventId;
        // }

        // public EventModel(string name, string description, DateTime date)
        // {
        //     Name = name;
        //     Description = description;
        //     Date = date;
        // }
    }
}