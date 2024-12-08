using Microsoft.AspNetCore.Mvc;
using TestCICD.Controllers;

namespace Test
{
    public class UnitTest1
    {
        [Theory] // Parameterized test
        [InlineData(3, 5, 8)]
        [InlineData(-2, 7, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 200, 300)]
        public void Test1(int x,int y, int z)
        {
            // Arrange
            var controller = new TestCICD.Controllers.HomeController();
            var model = new TestCICD.Models.TestModel { firstParam = x, secondParam = y };

            // Act
            var result = controller.Index(model) as ViewResult;
            var returnedModel = result?.Model as TestCICD.Models.TestModel;

            // Assert
            Assert.NotNull(returnedModel);
            Assert.Equal(z, returnedModel.result);
        }
    }
}