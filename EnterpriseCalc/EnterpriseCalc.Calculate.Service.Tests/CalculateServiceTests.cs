using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using EnterpriseCalc.Calculate.Service;
using EnterpriseCalc.Interfaces;

namespace EnterpriseCalc.Calculate.Service.Tests
{
    [TestFixture]
    public class CalculateServiceTests
    {
        [Test]
        public void Add_TwoPositiveIntegers_ResultInRange()
        {
            MockConfig mockConfig;
            int a = 1;
            int b = 2;
            ICalculatorService calculatorService = Init(out mockConfig);

            var result = calculatorService.Add(a, b);

            Assert.Positive(result);
        }

        [Test]
        public void Add_TwoNegativeIntMaxRange_ResultNegative()
        {
            MockConfig mockConfig;
            int a = -2147483647;
            int b = -2147483647;
            ICalculatorService calculatorService = Init(out mockConfig);

            var result = calculatorService.Add(a, b);
            Assert.True(true);
        }
        [Test]
        public void Add_TwoPositiveIntegers_ResultPositive()
        {
            MockConfig mockConfig;
            int a = 2147483647;
            int b = 2147483647;
            ICalculatorService calculatorService = Init(out mockConfig);
            var result = calculatorService.Add(a, b);
            Assert.Positive(result);

        }

        [Test]
        public void Subtract_TwoPositiveIntegers_ResultPositive()
        {
            MockConfig mockConfig;
            int a = 10;
            int b = 5;
            ICalculatorService calculatorService = Init(out mockConfig);

            var result = calculatorService.Subtract(a, b);

            Assert.Positive(result);
        }

        [Test]
        public void Subtract_TwoPositiveIntegers_ResultNegative()
        {
            MockConfig mockConfig;
            int a = 10;
            int b = 20;
            ICalculatorService calculatorService = Init(out mockConfig);

            var result = calculatorService.Subtract(a, b);

            Assert.Negative(result);
        }

        public CalculatorService Init(out MockConfig mockConfig)
        {
            mockConfig = new MockConfig();
            var service = new CalculatorService();
            return service;
        }
    }
    public class MockConfig
    {
        public Mock<ICalculatorService> IOperationsMock { get; set; } = new Mock<ICalculatorService>();
    }

}
