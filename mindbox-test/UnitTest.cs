using mindbox;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Abstractions;

namespace mindbox_test
{
    public class UnitTest
    {
        readonly ITestOutputHelper output;

        public UnitTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [MemberData(nameof(GetTestKit))]
        public void BaseTestTheory(TestData testData)
        {
            output.WriteLine("1. Test begining...");
            var result = testData.TestObject.GetSquare();

            output.WriteLine($"2. Method returned result: {result}");
            output.WriteLine($"3. Expected result: {testData.ExpectedResult}");

            Assert.Equal(testData.ExpectedResult, result);

            output.WriteLine("Test complete successfully!");
        }

        //we could add more tests to test e.g. border cases (excpetions, IsRectangular method, ...)

        public static IEnumerable<object[]> GetTestKit()
        {
            yield return SimpleCircleTest();
            yield return SimpleTrianlgeTest();
        }

        /// <summary>
        /// #1 case: test for simple circle
        /// </summary>
        private static object[] SimpleCircleTest()
        {
            return new object[]
            {
                new TestData
                {
                    ExpectedResult = 1256.6370614359173,
                    TestObject = new Circle(20)
                }
            };
        }

        /// <summary>
        /// #2 case: test for simple triangle
        /// </summary>
        private static object[] SimpleTrianlgeTest()
        {
            return new object[]
            {
                new TestData
                {
                    ExpectedResult = 290.4737509655563,
                    TestObject = new Triangle(20, 40, 30)
                }
            };
        }



        public class TestData : TestSource
        {
            public TestData([CallerMemberName] string testName = null)
                : base(testName)
            {
            }
            /// <summary>
            /// Some expected result.
            /// </summary>
            public double ExpectedResult { get; set; }
            /// <summary>
            /// Object which will be tested.
            /// </summary>
            public ISquarable TestObject { get; set; }
        }
    }
}
