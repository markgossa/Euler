using ProblemSolver.Function.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProblemSolver.Tests.Unit.Services.Common
{
    public class ExtensionsTests
    {
        [Fact]
        public void Helpers_GetEven_Returns_Even_Numbers_From_List_1()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 9, 10, 12, 13, 14 };

            var actual = numbers.GetEven();
            var expected = new List<int> { 10, 12, 14 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Helpers_GetEven_Returns_Even_Numbers_From_List_2()
        {
            var numbers = new List<int> { 43242, 546465, 543537, 7492 };

            var actual = numbers.GetEven();
            var expected = new List<int> { 43242, 7492 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Helpers_GetFactors_Returns_Factors_For_An_Integer_1()
        {
            int number = 10;

            var actual = number.GetFactors();
            var expected = new List<int> { 1, 2, 5, 10 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Helpers_GetFactors_Returns_Factors_For_An_Integer_2()
        {
            int number = 1000;

            var actual = number.GetFactors();
            var expected = new List<int> { 1, 2, 4, 5, 8, 10, 20, 25, 40, 50, 100, 125, 200, 250, 500, 1000 };
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(15485863)]
        public void Helpers_IsPrime_Returns_True_If_Prime_Number(int number)
        {
            var actual = number.IsPrime();
            Assert.True(actual);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(1542972)]
        public void Helpers_IsPrime_Returns_False_If_Not_Prime_Number(int number)
        {
            var actual = number.IsPrime();
            Assert.False(actual);
        }

        [Theory]
        [InlineData(2, 3, 4, 3)]
        [InlineData(6, 8, 11, 11)]
        public void Helpers_GetPrime_Returns_Prime_Numbers_For_A_List_Of_Int_1(int number1, int number2,
            int number3, int expected)
        {
            var numbers = new List<int> { number1, number2, number3 };

            var actual = numbers.GetPrime();
            Assert.Equal(new List<int> { expected }, actual);
        }

        [Fact]
        public void Helpers_GetPrime_Returns_Prime_Numbers_For_A_List_Of_Int_2()
        {
            var numbers = new List<int> { 1, 2, 4, 5, 7, 9, 15485863 };

            var actual = numbers.GetPrime();
            var expected = new List<int> { 2, 5, 7, 15485863 };
            Assert.Equal(expected, actual);
        }
    }
}
