using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInWords.NumberInWordsModel;

/*namespace NumberInWordsTests
{
    /// <summary>
    /// Summary description for RussianMillionsConverterTests
    /// </summary>
    [TestClass]
    public class RussianMillionsConverterTests
    {
        public TestContext TestContext
        {
            get;
            set;
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "MillionsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianMillionsConverter_MillionsTest_MillionsTestData()
        {
            this.TestDifferentData();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "ThousandsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianMillionsConverter_MillionsTest_ThousandsTestData()
        {
            this.TestDifferentData();
        }
        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "HundredsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianMillionsConverter_MillionsTest_HundredsTestData()
        {
            this.TestDifferentData();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TensTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianMillionsConverter_MillionsTest_TensTestData()
        {
            this.TestDifferentData();
        }

        public void TestDifferentData()
        {
            int input = Convert.ToInt32(TestContext.DataRow["input"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            INumberToStringConverter millionsConverter = new RussianMillionsConverter();
            string output = millionsConverter.ConvertNumber(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow(-9)]
        [DataRow(3_333_333_333)]
        [DataRow(1_000_000_000)]
        [ExpectedException(typeof(ArgumentException), "Exception was not throw")]
        public void RussianMillionsConverter_ConvertNumberTest_ArgumentException(int input)
        {
            //Arrange
            RussianMillionsConverter convertNumber = new RussianMillionsConverter();

            //Act
            string output = convertNumber.ConvertNumber(input);
        }
    }
}*/
