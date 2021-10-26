using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Message cannot be empty.")]
        [StringLength(300, ErrorMessage = "Max Message length : 300 chars.")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [ForeignKey("Sender"),Column(Order =0)]
        public int SenderId { get; set; }

        [ForeignKey("Reciever"), Column(Order = 1)]
        public int RecieverId { get; set; }

        public int IdanBranch { get; set; }

        public virtual User Sender { get; set; }

        public virtual User Reciever { get; set; }
    }
}
