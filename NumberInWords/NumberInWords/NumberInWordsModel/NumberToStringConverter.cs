// <copyright file="NumberToStringConverter.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Text;

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Abstract class for conversion number to its representation in words
    /// Implements all functionality of the Converter
    /// Works with non-negative numbers
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.INumberToStringConverter" />
    public abstract class NumberToStringConverter : INumberToStringConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberToStringConverter"/> class
        /// Initializes maximum number that can be converted
        /// </summary>
        protected NumberToStringConverter()
        {
            if (this.DegreesOfThousandInWords != null)
            {
                this.MaxNumber = Convert.ToUInt64(Math.Pow(1000, this.DegreesOfThousandInWords.GetLength(0) + 1)) - 1;
            }
            else
            {
                this.MaxNumber = 999;
            }
        }

        /// <summary>
        /// Gets the minimum number for conversion is equal to zero
        /// </summary>
        /// <value>
        /// The minimum number for conversion
        /// </value>
        public ulong MinNumber
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the maximum number for conversion is calculated in the constructor,
        /// and is based on filling the array DegreesOfThousandInWords
        /// </summary>
        /// <value>
        /// The maximum number for conversion
        /// </value>
        public ulong MaxNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the representation in words of number that is equal to 0
        /// </summary>
        /// <value>
        /// The zero in words
        /// </value>
        protected abstract string ZeroInWords
        {
            get;
        }

        /// <summary>
        /// Gets the representation of digits of a number in words
        /// </summary>
        /// <value>
        /// Digits of number in words
        /// </value>
        protected abstract string[] DigitInWords
        {
            get;
        }

        /// <summary>
        /// Gets the representation of teens of a number in words
        /// </summary>
        /// <value>
        /// Teens of number in words
        /// </value>
        protected abstract string[] TeensInWords
        {
            get;
        }

        /// <summary>
        /// Gets the representation of tens of a number in words
        /// </summary>
        /// <value>
        /// Tens of number in words
        /// </value>
        protected abstract string[] TensInWords
        {
            get;
        }

        /// <summary>
        /// Gets the representation of hundreds of a number in words
        /// </summary>
        /// <value>
        /// Hundreds of number in words
        /// </value>
        protected abstract string[] HundredsInWords
        {
            get;
        }

        /// <summary>
        /// Gets the representation of degrees of thousand in words
        /// </summary>
        /// <value>
        /// Degrees of thousand in words
        /// </value>
        protected abstract string[,] DegreesOfThousandInWords
        {
            get;
        }

        /// <summary>
        /// Separator between tens and units
        /// </summary>
        /// <value>
        /// The tens and units separator
        /// </value>
        protected virtual string TensUnitsSeparator => " ";

        /// <summary>
        /// Separator between hundreds and tens
        /// </summary>
        /// <value>
        /// The hundreds and tens separator
        /// </value>
        protected virtual string HundredsTensSeparator => " ";

        /// <summary>
        /// Separator between degrees of thousand
        /// </summary>
        /// <value>
        /// Separator between degrees of thousand
        /// </value>
        protected virtual string DegreesOfThousandsSeparator => " ";

        /// <summary>
        /// The main function of Converter that converts the number to its reprasentation in words
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>number`s reprasentation in words</returns>
        /// <exception cref="ArgumentException">
        /// Exception is expected when the number for conversion is less than minimum number,
        /// or when the number for conversion is bigger than maximum number
        public string ConvertNumber(ulong number)
        {
            if (number < this.MinNumber)
            {
                throw new ArgumentException($"Input parameter can not be less than {MinNumber}!");
            }

            if (number > this.MaxNumber)
            {
                throw new ArgumentException
                    (string.Format("Input parameter can not be greater than {0:N}!", this.MaxNumber));
            }

            if (number == 0)
            {
                return this.ZeroInWords;
            }
            else
            {
                return this.GetNumberToString(number);
            }
        }

        /// <summary>
        /// Gets the units of the number in words
        /// </summary>
        /// <param name="digit">The digit from 0 to 9</param>
        /// <returns>Representation in words</returns>
        protected string GetUnits(int digit)
        {
            return this.DigitInWords[digit];
        }

        /// <summary>
        /// Gets the teens of the number in words
        /// </summary>
        /// <param name="number">The last digit of teens of number</param>
        /// <returns>Representation in words</returns>
        protected string GetTeens(int number)
        {
            return this.TeensInWords[number];
        }

        /// <summary>
        /// Gets the tens of the number in words
        /// </summary>
        /// <param name="number">The number from 11 to 99</param>
        /// <returns>Representation in words</returns>
        protected string GetTens(int number)
        {
            int units = number % 10;
            string str_units = units != 0 ? this.GetUnits(units) : string.Empty;
            int tens = number / 10;
            if (tens == 1 && units != 0)
            {
                return this.GetTeens(units);
            }

            if (str_units == string.Empty)
            {
                return this.TensInWords[tens];
            }

            if (tens == 0)
            {
                return str_units;
            }

            return this.TensInWords[tens] + this.TensUnitsSeparator + str_units;
        }

        /// <summary>
        /// Gets the hundreds of the number in words
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>Representation in words</returns>
        protected string GetHundreds(int number)
        {
            number %= 1000;
            string str_tens = this.GetTens(number % 100);
            int hundreds = number / 100;
            if (hundreds == 0)
            {
                return str_tens;
            }

            if (str_tens == string.Empty)
            {
                return this.HundredsInWords[hundreds];
            }
            else
            {
                return this.HundredsInWords[hundreds] + this.HundredsTensSeparator + str_tens;
            }
        }

        /// <summary>
        /// Gets the number in words from 1 to maximum value
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>The representation of the number in words</returns>
        protected string GetNumberToString(ulong number)
        {
            string str_hundreds = this.GetHundreds((int)(number % 1000));
            StringBuilder numberBuilder = new StringBuilder();
            numberBuilder.Append(str_hundreds);
            ulong largeNumber = number;
            int i = 0;
            while (largeNumber / 1000 > 0)
            {
                StringBuilder subnumberBuilder = new StringBuilder();
                largeNumber = largeNumber / 1000;
                if (largeNumber % 1000 > 0)
                {
                    if (largeNumber % 100 >= 11 && largeNumber % 100 <= 19)
                    {
                        subnumberBuilder.Append(this.GetHundreds((int)largeNumber % 1000));
                        subnumberBuilder.Append(this.DegreesOfThousandsSeparator);
                        subnumberBuilder.Append(this.DegreesOfThousandInWords[i, 0]);
                    }
                    else
                    {
                        string hundreds = this.GetHundreds((int)(largeNumber - (largeNumber % 10)) % 1000);
                        subnumberBuilder.Append(hundreds);
                        if (hundreds != string.Empty)
                        {
                            subnumberBuilder.Append(this.DegreesOfThousandsSeparator);
                        }

                        subnumberBuilder.Append(this.DegreesOfThousandInWords[i, largeNumber % 10]);
                    }
                }

                if (subnumberBuilder.ToString() != string.Empty)
                {
                    if (numberBuilder.ToString() != string.Empty)
                    {
                        numberBuilder.Insert(0, this.DegreesOfThousandsSeparator);
                    }

                    numberBuilder.Insert(0, subnumberBuilder);
                }
                    
                i++;
            }

            return numberBuilder.ToString();
        }
    }
}