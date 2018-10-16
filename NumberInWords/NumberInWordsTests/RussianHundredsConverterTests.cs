using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInWords.NumberInWordsModel;

namespace NumberInWordsTests
{
    [TestClass]
    public class RussianHundredsConverterTests
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get;
            set;
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TensTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void RussianHundredsConverter_ConvertNumberTests_TensTestData()
        {
            this.TestDifferentData();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "HundredsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianHundredsConverter_ConvertNumberTests_HundredsTestData()
        {
            this.TestDifferentData();
        }

        public void TestDifferentData()
        {
            int input = Convert.ToInt32(TestContext.DataRow["input"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            RussianHundredsConverter convertNumber = new RussianHundredsConverter();
            string output = convertNumber.ConvertNumber(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void RussianHundredsConverter_ConvertNumberTest_0_ReturnZero()
        {
            //arrange
            int input = 0;
            string expected = "ноль";
            RussianHundredsConverter convertNumber = new RussianHundredsConverter();

            //act
            string output = convertNumber.ConvertNumber(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow(-9)]
        [DataRow(3_333_333_333)]
        [DataRow(1000)]
        [ExpectedException(typeof(ArgumentException), "Exception was not throw")]
        public void RussianHundredsConverter_ConvertNumberTest_ArgumentException(int input)
        {
            //Arrange
            RussianHundredsConverter convertNumber = new RussianHundredsConverter();

            //Act
            string output = convertNumber.ConvertNumber(input);
        }
    }
}