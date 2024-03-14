using FluentAssertions;
using FluentAssertions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ClassLibrary.xUnitUnitTests
{
    public class FechaTest
    {
        public void FechaTest_ShouldBe13Febrero2024At1132() 
        {
            //Arrange

            //Act
            var result = new DateTime(2024, 2, 11, 3, 28, 30);

            //Assert
            result.Should().Be(11.February(2024).At(3, 28, 30));
        }
    }
}
