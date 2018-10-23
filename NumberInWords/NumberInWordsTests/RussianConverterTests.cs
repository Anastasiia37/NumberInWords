// <copyright file="RussianConverterTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInWords.NumberInWordsModel;

namespace NumberInWordsTests
{
    /// <summary>
    /// Tests for RussianConverter class
    /// </summary>
    [TestClass]
    public class RussianConverterTests
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run
        ///</summary>
        public TestContext TestContext
        {
            get;
            set;
        }

        /// <summary>
        /// Test for ConvertNumber method with incorrect input
        /// </summary>
        /// <param name="input">Very big number</param>
        [DataTestMethod]
        [DataRow(333_333_333_333_333ul)]
        [ExpectedException(typeof(ArgumentException), "Exception was not throw")]
        public void RussianConverter_ConvertNumberTest_ArgumentException(ulong input)
        {
            //Arrange
            RussianConverter converter = new RussianConverter();

            //Act
            string actual = converter.ConvertNumber(input);
        }


        /// <summary>
        /// Test for ConvertNumber method with zero
        /// </summary>        
        [TestMethod]
        public void RussianConverter_ConvertNumberTest_ZeroTest()
        {
            // Arrange
            ulong input = 0;
            string expected = "ноль";
            RussianConverter converter = new RussianConverter();

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
        public void RussianConverter_ConvertNumberTest_UnitsTestData()
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
        public void RussianConverter_ConvertNumberTest_TensTestData()
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
        public void RussianConverter_ConvertNumberTest_TeensTestData()
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
        public void RussianConverter_ConvertNumberTest_HundredsTestData()
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
        public void RussianConverter_ConvertNumberTest_ThousandsTestData()
        {
            this.TestDifferentData();
        }

        /// <summary>
        /// Test for ConvertNumber method with millions test data
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "MillionsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianConverter_ConvertNumberTest_MillionsTestData()
        {
            this.TestDifferentData();
        }

        /// <summary>
        /// Test for ConvertNumber method with billions test data
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "BillionsTestData.xml",
            "Number",
            DataAccessMethod.Sequential)]
        public void RussianConverter_ConvertNumberTest_BillionsTestData()
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
            string expected = Convert.ToString(TestContext.DataRow["expectedRU"]);
            RussianConverter converter = new RussianConverter();

            // Act
            string actual = converter.ConvertNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}