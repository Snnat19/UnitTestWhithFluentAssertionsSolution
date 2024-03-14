using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ClassLibrary.xUnitUnitTests
{
    public class CollectionTest
    {
        [Fact]
        public void CoollectioTest()
        {
            //Arrange

            //act 
            IEnumerable<int> numbers = new[] { 1, 2, 3, }; //Coleccion que es entera y se puede itetar, se acumula en una coleccion numbers //Es igual a lo que viene de la BLL y se abrevia con un array

            //Assert
            //Verificar que todos los elementos de una colección cumplan con un predicado que contenga un número específico de elementos.
            numbers.Should().OnlyContain(n => n > 0);
            numbers.Should().HaveCount(3,"se esperan 3 valores en la coleccion."); //mensaje personalizado para detectar errores

        }
    }
}
