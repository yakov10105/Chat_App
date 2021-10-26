using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_App.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }

        [Display(Name = "Room Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "The room name cannot be empty.")]
        [StringLength(20, ErrorMessage = "Max length of name : 20 chars.")]
        public string RoomName { get; set; }

        public bool IsGameOn { get; set; } = false;

        public IEnumerable<User> Members { get; set; }

        public IEnumerable<Message> Messages { get; set; }
    }
}
