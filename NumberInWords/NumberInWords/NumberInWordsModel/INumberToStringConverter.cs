// <copyright file="INumberToStringConverter.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Abstraction for Number to String Converter
    /// </summary>
    public interface INumberToStringConverter
    {
        /// <summary>
        /// Gets the maximum number for conversion
        /// </summary>
        /// <value>
        /// The maximum number for conversion
        /// </value>
        ulong MaxNumber
        {
            get;
        }

        /// <summary>
        /// Gets the minimum number for conversion
        /// </summary>
        /// <value>
        /// The minimum number for conversion
        /// </value>
        ulong MinNumber
        {
            get;
        }

        /// <summary>
        /// The main function of Converter that converts the number to its representation in words
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>Number`s representation in words</returns>
        string ConvertNumber(ulong number);
    }
}