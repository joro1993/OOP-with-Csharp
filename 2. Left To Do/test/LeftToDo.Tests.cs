using System;
using Xunit;

namespace LeftToDo.Tests
{
    public class LeftToDoXunit
    {
        [Fact]
        public void CanAddTodo()
        {
            // Arrange
            var select = new selectATodo("CanAddTodo test");
            // Act

            // Assert
            Assert.NotEmpty(select.ToString());
        }


        [Fact]
        public void CanMarkAsDone()
        {
            // Arrange
            var markAsDone = new selectATodo("CanMarkAsDone test");
            // Act
            
            // Assert
            Assert.NotEmpty(markAsDone.ToString());
        }

        [Fact]
        public void CanArchiveTodo()
        {
            // Arrange
            var ArchiveTodo = new selectATodo("CanArchiveTodo test");
            // Act
            var result2 = ArchiveTodo;
            // Assert
            Assert.NotNull(result2);
        }
    }
}
