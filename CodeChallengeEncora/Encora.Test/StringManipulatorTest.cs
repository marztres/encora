using Xunit;
using Xunit.Abstractions;

namespace Encora.Test
{
    public class StringManipulatorTest
    {
        private readonly ITestOutputHelper outputHelper;
        public StringManipulatorTest(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(@"TestData\Case1Input.txt", @"TestData\Case1OutPut.txt")]
        [InlineData(@"TestData\Case2Input.txt", @"TestData\Case2OutPut.txt")]
        [InlineData(@"TestData\Case3Input.txt", @"TestData\Case3OutPut.txt")]
        [InlineData(@"TestData\Case4Input.txt", @"TestData\Case4OutPut.txt")]
        [InlineData(@"TestData\Case5Input.txt", @"TestData\Case5OutPut.txt")]
        [InlineData(@"TestData\Case6Input.txt", @"TestData\Case6OutPut.txt")]
        public void SortString_ShouldOrderCharactersByFrequencyAndAlphabetically(string inputFileName, string expectedOutputFileName)
        {
            var inputLines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, inputFileName));
            outputHelper.WriteLine("Input => Output");
            List<string> output = new List<string>();
            foreach (var line in inputLines)
            {
                string sortedLine = StringManipulator.SortingOperations(line);
                outputHelper.WriteLine($"{line} =>{sortedLine}");
                output.Add(sortedLine);
            }

            var expectedOutput = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, expectedOutputFileName)).ToList();
            Assert.Equal(output, expectedOutput);
        }
    }
}