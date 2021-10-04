using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var result = await Fibo.ExecuteAsync(new[] {"4"});
            Assert.Single(result);
            Assert.Equal(3, result[0]);
        }
    }
}