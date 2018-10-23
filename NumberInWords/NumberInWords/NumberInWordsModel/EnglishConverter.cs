// <copyright file="EnglishConverter.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Gets the representation in words of a number in English
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.NumberToStringConverter" />
    public class EnglishConverter : NumberToStringConverter
    {
        /// <summary>
        /// Gets the representation in words of number that is equal to 0
        /// </summary>
        /// <value>
        /// The zero in words
        /// </value>
        protected override string ZeroInWords => "zero";

        /// <summary>
        /// Separator between hundreds and tens in English
        /// </summary>
        /// <value>
        /// The hundreds and tens separator
        /// </value>
        protected override string HundredsTensSeparator => " and ";

        /// <summary>
        /// Separator between tens and units in English
        /// </summary>
        /// <value>
        /// The tens and units separator
        /// </value>
        protected override string TensUnitsSeparator => "-";

        /// <summary>
        /// Gets the representation of digits of a number in words in English
        /// </summary>
        /// <value>
        /// Digits of number in words
        /// </value>
        protected override string[] DigitInWords
        {
            get => new string[10]
            {
                string.Empty,
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };
        }

        /// <summary>
        /// Gets the representation of teens of a number in words in English
        /// </summary>
        /// <value>
        /// Teens of number in words
        /// </value>
        protected override string[] TeensInWords
        {
            get => new string[10]
            {
                string.Empty,
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen"
            };
        }

        /// <summary>
        /// Gets the representation of tens of a number in words in English
        /// </summary>
        /// <value>
        /// Tens of number in words
        /// </value>
        protected override string[] TensInWords
        {
            get => new string[10]
            {
                string.Empty,
                "ten",
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            };
        }

        /// <summary>
        /// Gets the representation of hundreds of a number in words in English
        /// </summary>
        /// <value>
        /// Hundreds of number in words
        /// </value>
        protected override string[] HundredsInWords
        {
            get => new string[10]
            {
                string.Empty,
                "one hundred",
                "two hundred",
                "three hundred",
                "four hundred",
                "five hundred",
                "six hundred",
                "seven hundred",
                "eight hundred",
                "nine hundred"
            };
        }

        /// <summary>
        /// Gets the representation of degrees of thousand in words in English
        /// </summary>
        /// <value>
        /// Degrees of thousand in words
        /// </value>
        protected override string[,] DegreesOfThousandInWords
        {
            get => new string[1, 10]
            {
                {
                    "thousand",
                    "one thousand",
                    "two thousand",
                    "three thousand",
                    "four thousand",
                    "five thousand",
                    "six thousand",
                    "seven thousand",
                    "eight thousand",
                    "nine thousand"
                }
            };
        }
    }
}