using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_given_number_when_normal_case_given()
        {
            int givenNumber = 1;
            string res = FizzBuzzGame.CountOff(givenNumber);
            //then
            Assert.Equal("1", res);
        }
    }
}