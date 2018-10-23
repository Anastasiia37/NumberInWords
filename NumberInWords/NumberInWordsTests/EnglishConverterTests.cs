// <copyright file="EnglishConverterTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInWords.NumberInWordsModel;

namespace NumberInWordsTests
{
    /// <summary>
    /// Tests for EnglishConverter class
    /// </summary>
    [TestClass]
    public class EnglishConverterTests
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run
        ///</summary>
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        /// Test for ConvertNumber method
        /// </summary>
        /// <param name="input">The incorrect input</param>
        [DataTestMethod]
        [DataRow(1_333_333ul)]
        [ExpectedException(typeof(ArgumentException), "Exception was not throw")]
        public void EnglishConverter_ConvertNumberTest_ArgumentException(ulong input)
        {
            //Arrange
            EnglishConverter converter = new EnglishConverter();

            //Act
            string actual = converter.ConvertNumber(input);
        }


        /// <summary>
        /// Test for ConvertNumber method wit zero input value
        /// </summary>
        [TestMethod]
        public void EnglishConverter_ConvertNumberTest_ZeroTest()
        {
            // Arrange
            ulong input = 0;
            string expected = "zero";
            EnglishConverter converter = new EnglishConverter();

            // Act
            string actual = converter.ConvertNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Test for ConvertNumber method with units test data
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "UnitsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void EnglishConverter_ConvertNumberTest_UnitsTestData()
        {
            this.TestDifferentData();
        }

        /// <summary>
        /// Test for ConvertNumber method with tens test data
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TensTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void EnglishConverter_ConvertNumberTest_TensTestData()
        {
            this.TestDifferentData();
        }

        /// <summary>
        /// Test for ConvertNumber method with teens test data
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TeensTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void EnglishConverter_ConvertNumberTest_TeensTestData()
        {
            this.TestDifferentData();
        }

        /// <summary>
        /// Test for ConvertNumber method with hundreds test data
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "HundredsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void EnglishConverter_ConvertNumberTest_HundredsTestData()
        {
            this.TestDifferentData();
        }

        /// <summary>
        /// Test for ConvertNumber method with thousands test data
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "ThousandsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void EnglishConverter_ConvertNumberTest_ThousandsTestData()
        {
            this.TestDifferentData();
        }

        /// <summary>
        /// Supporting method for testing of ConvertNumber method with different test data
        /// </summary>
        public void TestDifferentData()
        {
            // Arrange
            ulong input = Convert.ToUInt64(TestContext.DataRow["input"]);
            string expected = Convert.ToString(TestContext.DataRow["expectedENG"]);
            EnglishConverter converter = new EnglishConverter();

            // Act
            string actual = converter.ConvertNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}