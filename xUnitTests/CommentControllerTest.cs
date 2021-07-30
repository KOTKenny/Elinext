using DAL;
using DAL.Models;
using DAL.Repositories.Interfaces;
using Elinext.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using Xunit;

namespace xUnitTests
{
    public class CommentControllerTest
    {
        [Fact]
        public void ReturnCreatedPost()
        {

            var mockRepo = new Mock<IRepositoryManager>();
            var mockCommentRepo = new Mock<ICommentRepository>();
            mockRepo.Setup(m => m.Comment).Returns(mockCommentRepo.Object);

            Comment comment = new Comment()
            {
                Username = "Martin",
                Message = "This is new comment",
                PostId = 1
            };
            // Arrange
            var controller = new CommentController(mockRepo.Object);

            // Act
            var result = controller.Create(comment);

            Assert.Equal(((StatusCodeResult)result).StatusCode, new OkResult().StatusCode);
        }
    }
}
