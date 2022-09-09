using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class FriendModel
    {
        [Required]
        [Key()]
        public int FriendID { get; set; } 

        [Required]
        public string FName { get; set; }
        public string FPlace { get; set; }

    }
}
