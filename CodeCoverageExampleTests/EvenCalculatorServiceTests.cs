using CodeCoverageExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace CodeCoverageExampleTests
{
    [TestClass]
    public class EvenCalculatorServiceTests
    {
        [TestMethod]
        [DataRow(new int[] {})]
        [DataRow(new int[] { 1 })]
        [DataRow(new int[] { 1, 3, 5 })]
        public async Task CalculateAsync_InvalidValuesArray_ThrowsArgumentExceptionAsync(int[] values)
        {
            var calculatorService = new EvenCalculatorService();
            await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await calculatorService.CalculateAsync(values));
        }

        [TestMethod]
        [DataRow(2, new int[] { 2 })]
        [DataRow(8, new int[] { 2, 2, 4 })]
        [DataRow(4, new int[] { 1, 4 })]
        public async Task CalculateAsync_MixedValuesArray_ReturnsResultAsync(int expected, int[] values)
        {
            var calculatorService = new EvenCalculatorService();         
            var result = await calculatorService.CalculateAsync(values);

            Assert.AreEqual(expected, result);
        }
    }
}
