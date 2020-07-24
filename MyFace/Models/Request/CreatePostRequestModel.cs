using System.ComponentModel.DataAnnotations;

namespace MyFace.Models.Request
{
    public class CreatePostRequestModel
    {
        [Required]
        [StringLength(140)]

        public string Message { get; set; }
        
        public string ImageUrl { get; set; }
        
        [Required]
        public int UserId { get; set; }
    }
}