using Microsoft.AspNetCore.Mvc;
using TestCICD.Controllers;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var controller = new TestCICD.Controllers.HomeController();
            var model = new TestCICD.Models.TestModel { firstParam = 5, secondParam = 7 };

            // Act
            var result = controller.Index(model) as ViewResult;
            var returnedModel = result?.Model as TestCICD.Models.TestModel;

            // Assert
            Assert.NotNull(returnedModel);
            Assert.Equal(12, returnedModel.result);
        }
    }
}