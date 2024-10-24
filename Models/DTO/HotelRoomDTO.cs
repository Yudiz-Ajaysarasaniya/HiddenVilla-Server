using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class HotelRoomDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Room Name")] //for client side validation
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please Enter Occupancy")]
        public int Occupancy { get; set; }
        [Range(1,3000, ErrorMessage = "Ragular Rate must be between 1 and 3000")]
        [Required]
        public double RagularRate { get; set; }
        public string? Details { get; set; }
        public string? SqFt { get; set; }
    }
}
