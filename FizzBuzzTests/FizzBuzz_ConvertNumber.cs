using NUnit.Framework;
using FluentAssertions;

namespace FizzBuzz.Tests;

public class Tests
{

    [TestFixture]
    public class FizzBuzz_ConvertNumberShould
    {
        private FizzBuzz _fizzbuzz = default!;

        [SetUp]
        public void Setup()
        {
            _fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void Convert1ReturnString1()
        {
            int input = 1;
            var expected_output = "1";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
            // Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Convert2ReturnString2()
        {
            int input = 2;
            var expected_output = "2";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        public void Convert3ReturnFizz()
        {
            int input = 3;
            var expected_output = "Fizz";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        public void Convert5ReturnBuzz()
        {
            int input = 5;
            var expected_output = "Buzz";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        public void Convert4ReturnString4()
        {
            int input = 4;
            var expected_output = "4";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        public void Convert6ReturnFizz()
        {
            int input = 6;
            var expected_output = "Fizz";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        public void Convert15ReturnsFizzBuzz()
        {
            int input = 15;
            var expected_output = "FizzBuzz";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        public void ConvertMultipleOf3ReturnsFizz(int input_number)
        {
            int input = input_number;
            var expected_output = "Fizz";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        [TestCase(35)]
        public void ConvertMultipleOf5ReturnsBuzz(int input_number)
        {
            int input = input_number;
            var expected_output = "Buzz";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        public void ConvertMultipleOf15ReturnsFizzBuzz(int input_number)
        {
            int input = input_number;
            var expected_output = "FizzBuzz";

            var result = _fizzbuzz.ConvertNumber(input);
            result.Should().Be(expected_output);
        }
    }
}

