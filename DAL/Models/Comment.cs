using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Comment : IEntityDate
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for the Username is 100 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Message is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the Message is 500 characters.")]
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }

        public int? PostId { get; set; } 
        public virtual Post Post { get; set; }

        public int? CommentId { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
