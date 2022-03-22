using NUnit.Framework;
using FluentAssertions;

namespace FizzBuzz.Tests;

public class FizzBuzz_CountTo_Test {
    [TestFixture]
    public class FizzBuzz_CountTo
    {
        private FizzBuzz _fizzbuzz = default!;

        [SetUp]
        public void Setup()
        {
            _fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void CountTo1ReturnsStringArr1()
        {
            int input = 1;
            var expected_output = new string[] {"1"};

            var result = _fizzbuzz.CountTo(input);
            result.Should().Equal(expected_output);
        }

        [Test]
        public void CountTo2ReturnsStringArr1And2()
        {
            int input = 2;
            var expected_output = new string[] {"1", "2"};

            var result = _fizzbuzz.CountTo(input);
            result.Should().Equal(expected_output);
        }

        [Test]
        public void CountTo3ReturnsStringArr1And2AndFizz()
        {
            int input = 3;
            var expected_output = new string[] {"1", "2", "Fizz"};

            var result = _fizzbuzz.CountTo(input);
            result.Should().Equal(expected_output);
        }

        [Test]
        public void CountTo20ReturnsCorrectResult()
        {
            int input = 20;
            var expected_output = new string[] {
                "1", "2", "Fizz", "4", "Buzz",
                "Fizz", "7", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "14", "FizzBuzz",
                "16", "17", "Fizz", "19", "Buzz"
            };

            var result = _fizzbuzz.CountTo(input);
            result.Should().Equal(expected_output);
        }
    }
}