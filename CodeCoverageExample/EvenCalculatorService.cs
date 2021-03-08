using System;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCoverageExample
{
    public class EvenCalculatorService
    {
        public async Task<int> CalculateAsync(int[] values)
        {
            var evenCollection = values.Where(v => v % 2 == 0);

            if(!evenCollection.Any())
            {
                throw new ArgumentException("No even integers founds", nameof(values));
            }

            var result = evenCollection.Sum();
            return await Task.FromResult(result);
        }
    }
}
