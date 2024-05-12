using MiWeb;
using MiWeb.Controllers;

namespace TestUnitarios
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            WeatherForecastController controller = new WeatherForecastController(null);

            IEnumerable<WeatherForecast> results = controller.Get();
            Assert.True(results.Count()>1);           
        }
    }
}