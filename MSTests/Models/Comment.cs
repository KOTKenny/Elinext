using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTests.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }

        public int? PostId { get; set; }

        public int? CommentId { get; set; }
    }
}
