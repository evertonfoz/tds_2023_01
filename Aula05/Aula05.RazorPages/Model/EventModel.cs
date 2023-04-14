using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aula05.RazorPages.Models {
    public class EventModel {
        public int? EventID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public List<PlayerModel>? Players { get; set; } 
    }
}