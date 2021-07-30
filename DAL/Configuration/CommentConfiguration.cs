using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment
                {
                    Id = 1,
                    PostId = 1,
                    Username = "KOTKenny",
                    Message = "Comment",
                    CreateDate = DateTime.Now,

                },
                new Comment 
                { 
                    Id = 2, 
                    CreateDate = DateTime.Now, 
                    Message = "Reply", 
                    Username = "George", 
                    CommentId = 1 
                },
                new Comment
                {
                    Id = 3,
                    Username = "Daly",
                    Message = "ReplyOfReply",
                    CreateDate = DateTime.Now,
                    CommentId = 2

                },
                new Comment
                {
                    Id = 4,
                    Username = "Minsy",
                    Message = "ReplyOfReplyOfRely",
                    CreateDate = DateTime.Now,
                    CommentId = 3

                },
                new Comment
                {
                    Id = 5,
                    Username = "Oleg",
                    Message = "Comment",
                    CreateDate = DateTime.Now,
                    PostId = 1

                }
            );
        }
    }
}
