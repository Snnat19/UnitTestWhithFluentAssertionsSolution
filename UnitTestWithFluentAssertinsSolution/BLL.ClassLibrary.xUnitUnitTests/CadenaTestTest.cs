using FluentAssertions;

namespace BLL.ClassLibrary.xUnitUnitTests
{
    public class CadenaTextTest
    {
        [Fact]
        public void CadenaTest()
        {
            //Arrange
            CadenaText objcadena = new CadenaText(); //instanciar la clase concreta

            //Act
            var actaul = objcadena.Cadena();

            //Assert
            actaul.Should(). //metodo de AsserFluent
                StartWith("AB").
                And.EndWith("HI").
                And.Contain("EF").
                And.HaveLength(9);

            //condiciones
        }
    }
}