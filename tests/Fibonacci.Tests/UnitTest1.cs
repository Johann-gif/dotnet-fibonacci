using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            using var fibonacciDataContext = new FibonacciDataContext();
            var result = await new Fibo(fibonacciDataContext).ExecuteAsync(new[] {"4"});
            Assert.Single(result);
            Assert.Equal(3, result[0]);
        }
    }
}