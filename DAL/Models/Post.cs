using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Post : IEntityDate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Article { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
