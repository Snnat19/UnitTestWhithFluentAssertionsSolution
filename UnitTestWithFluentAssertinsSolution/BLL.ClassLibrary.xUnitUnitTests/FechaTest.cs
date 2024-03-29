﻿using FluentAssertions;
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
        public void FechaTest_ShouldBe13Marzo2024At1132() 
        {
            //Arrange

            //Act
            var result = new DateTime(2024, 3, 13, 11, 38, 17); //ilegible

            //Assert
            result.Should().Be(13.March(2024).At(11, 38, 17)); //comprensible
        }
    }
}
