using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string PrifilePictureURL { get; set; }
        public string FullName { get; set; }
        public String Bio { get; set; }
    }
}
