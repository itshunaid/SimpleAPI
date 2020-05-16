using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller= new WeatherForecastController(null);

         [Fact]
        public void GetReturnsMyName()
        {
            var returnvalue= controller.Get();
            Assert.Equal("Hunaid", returnvalue.ToString());

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
