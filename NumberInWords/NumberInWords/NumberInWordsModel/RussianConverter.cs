// <copyright file="RussianConverter.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Gets a representation in words of a number in Russian
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.NumberToStringConverter" />
    public class RussianConverter : NumberToStringConverter
    {
        /// <summary>
        /// Gets the representation in words of number that is equal to 0
        /// </summary>
        /// <value>
        /// The zero in words
        /// </value>
        protected override string ZeroInWords => "ноль";

        /// <summary>
        /// Gets the representation of digits of a number in words in Russian
        /// </summary>
        /// <value>
        /// Digits of number in words
        /// </value>
        protected override string[] DigitInWords
        {
            get => new string[ELEMENTS_COUNT] 
            {
                string.Empty,
                "один",
                "два",
                "три",
                "четыре",
                "пять",
                "шесть",
                "семь",
                "восемь",
                "девять"
            };
        }

        /// <summary>
        /// Gets the representation of teens of a number in words in Russian
        /// </summary>
        /// <value>
        /// Teens of number in words
        /// </value>
        protected override string[] TeensInWords
        {
            get => new string[ELEMENTS_COUNT]
            {
                string.Empty,
                "одиннадцать",
                "двенадцать",
                "тринадцать",
                "четырнадцать",
                "пятнадцать",
                "шестнадцать",
                "семнадцать",
                "восемнадцать",
                "девятнадцать"
            };
        }

        /// <summary>
        /// Gets the representation of tens of a number in words in Russian
        /// </summary>
        /// <value>
        /// Tens of number in words
        /// </value>
        protected override string[] TensInWords
        {
            get => new string[ELEMENTS_COUNT]
            {
                string.Empty,
                "десять",
                "двадцать",
                "тридцать",
                "сорок",
                "пятьдесят",
                "шестьдесят",
                "семьдесят",
                "восемьдесят",
                "девяносто"
            };
        }

        /// <summary>
        /// Gets the representation of hundreds of a number in words in Russian
        /// </summary>
        /// <value>
        /// Hundreds of number in words
        /// </value>
        protected override string[] HundredsInWords
        {
            get => new string[ELEMENTS_COUNT]
            {
                string.Empty,
                "сто",
                "двести",
                "триста",
                "четыреста",
                "пятьсот",
                "шестьсот",
                "семьсот",
                "восемьсот",
                "девятьсот"
            };
        }

        /// <summary>
        /// Gets the representation of degrees of thousand in words in Russian
        /// </summary>
        /// <value>
        /// Degrees of thousand in words
        /// </value>
        protected override string[,] DegreesOfThousandInWords
        {
            get => new string[3, ELEMENTS_COUNT]
            {                
                {
                    "тысяч",
                    "одна тысяча",
                    "две тысячи",
                    "три тысячи",
                    "четыре тысячи",
                    "пять тысяч",
                    "шесть тысяч",
                    "семь тысяч",
                    "восемь тысяч",
                    "девять тысяч"
                },
                {
                    "миллионов",
                    "один миллион",
                    "два миллиона",
                    "три миллиона",
                    "четыре миллиона",
                    "пять миллионов",
                    "шесть миллионов",
                    "семь миллионов",
                    "восемь миллионов",
                    "девять миллионов"
                },
                {
                    "миллиардов",
                    "один миллиард",
                    "два миллиарда",
                    "три миллиарда",
                    "четыре миллиарда",
                    "пять миллиардов",
                    "шесть миллиардов",
                    "семь миллиардов",
                    "восемь миллиардов",
                    "девять миллиардов"
                }
            };
        }
    }
}