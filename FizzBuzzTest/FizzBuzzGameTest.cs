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

        [Fact]
        public void Should_return_Fizz_when_Fizz_case_given()
        {
            int givenNumber = 3;
            string res = FizzBuzzGame.CountOff(givenNumber);
            //then
            Assert.Equal("Fizz", res);
        }

        [Fact]
        public void Should_return_Buzz_when_Buzz_case_given()
        {
            int givenNumber = 5;
            string res = FizzBuzzGame.CountOff(givenNumber);
            //then
            Assert.Equal("Buzz", res);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_FizzBuzz_case_given()
        {
            int givenNumber = 15;
            string res = FizzBuzzGame.CountOff(givenNumber);
            //then
            Assert.Equal("FizzBuzz", res);
        }
    }
}