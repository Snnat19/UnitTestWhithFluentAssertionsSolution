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
            IEnumerable<int> numbers = new[] { 1, 2, 3, };

            //Assert
            //Verify that all elements of a collection match a predicate that it contains a specific number of elements
            numbers.Should().OnlyContain(n => n > 0);
            numbers.Should().HaveCount(3,"se esperan 3 valores en la coleccion");

        }
    }
}
