using System;
using System.ComponentModel.DataAnnotations;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        [Required]
     [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters long")]
        public string Title
        {
            get; set;
        }
        
        public string Author
        {
            get; set;
        }
        [Required]
        [MinLength(100, ErrorMessage = "Blog posts must ben a minimum of 100 characters")]
        public string Body
        {
            get; set;
        }

        public DateTime Posted
        {
            get; set;
        }

    }
}
