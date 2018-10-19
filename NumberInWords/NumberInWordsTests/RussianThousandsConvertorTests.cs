using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInWords.NumberInWordsModel;

namespace NumberInWordsTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RussianThousandsConvertorTests
    {
        public TestContext TestContext
        {
            get;
            set;
        }

       /* [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "ThousandsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianThousandsConverter_ThousandsTest_ThousandsTestData()
        {
            this.TestDifferentData();
        }*/

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "ThousandsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianThousandsConverter_ThousandsTest_ThousandsTestData()
        {
            this.TestDifferentData();
        }
        public void TestDifferentData()
        {
            int input = Convert.ToInt32(TestContext.DataRow["input"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            RussianThousandsConverter thousandsConverter = new RussianThousandsConverter();
            string output = thousandsConverter.ConvertNumber(input);
            Assert.AreEqual(expected, output);
        }
        /*[TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "HundredsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianThousandsConverter_ThousandsTest_HundredsTestData()
        {
            this.TestDifferentData();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TensTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianThousandsConverter_ThousandsTest_TensTestDataTestData()
        {
            this.TestDifferentData();
        }

        public void TestDifferentData()
        {
            int input = Convert.ToInt32(TestContext.DataRow["input"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            NumberToStringThousandsConverter hundredsConverter = new NumberToStringThousandsConverter();
            string output = hundredsConverter.ConvertNumber(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow(-9)]
        [DataRow(3_333_333_333)]
        [DataRow(1_000_000)]
        [ExpectedException(typeof(ArgumentException), "Exception was not throw")]
        public void RussianThousandsConverter_ConvertNumberTest_ArgumentException(int input)
        {
            //Arrange
            NumberToStringThousandsConverter convertNumber = new NumberToStringThousandsConverter();

            //Act
            string output = convertNumber.ConvertNumber(input);
        }*/
    }
}
