using FluentAssertions;

namespace BLL.ClassLibrary.xUnitUnitTests
{
    public class CadenaTextTest
    {
        [Fact]
        public void CadenaTest()
        {
            //Arrange
            CadenaText objcadena = new CadenaText();

            //Act
            var actaul = objcadena.Cadena();

            //Assert
            actaul.Should().
                StartWith("AB").
                And.EndWith("HI").
                And.Contain("EF").
                And.HaveLength(9);
        }
    }
}