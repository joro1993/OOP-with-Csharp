using System;
using Xunit;
using NightInTheMuseum;

namespace nightInTheMuseeum.Tests
{
    public class xunit
    {
        [Fact]
        public void ArtNotNull()
        {   //Arrange
            Art sut = new Art();
            //Act
            var result = new Art();
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void menusNotNull()
        {   //Arrange
            menus sut1 = new menus();
            //Act
            var result = new menus();
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void EntreNotNull()
        {   //Arrange
            Entre sut3 = new Entre();
            //Act
            var result = new Entre();
            //Assert
            Assert.NotNull(result);
        }
    }
}
