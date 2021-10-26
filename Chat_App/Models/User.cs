using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_App.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="First Name field is required.")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name field is required.")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name field is required.")]
        [StringLength(15)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Age field is required.")]
        [Range(0, 120, ErrorMessage = "Age must be between 0-120.")]
        [Display(Name = "Age")]
        [DataType("Int32", ErrorMessage = "The input must be a natural number.")]
        public int UserAge { get; set; }

        [Required(ErrorMessage ="Email field is required.")]
        [Display(Name ="Email")]
        [EmailAddress(ErrorMessage = "The input must be valid Email adrress")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password field is required.")]
        [Display(Name ="Password")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password field is required.")]
        [Display(Name ="Confirm Password")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Incompatible passwords.")]
        public string ConfirmPassword { get; set; }

        public bool IsOnline { get; set; }

        public int WinCoins { get; set; } = 0;

        public IEnumerable<Message> Messages { get; set; }

        public IEnumerable<User> Friends { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }
}
