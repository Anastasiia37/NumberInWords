// <copyright file="ArgumentsCount.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace NumberInWords.UI
{
    /// <summary>
    /// Arguments count in command line
    /// </summary>
    public enum ArgumentsCount
    {
        /// <summary>
        /// There are no arguments in command line
        /// </summary>
        NoArguments = 0,

        /// <summary>
        /// The minimum arguments count in command line
        /// </summary>
        MinArgumentsCount = 1,

        /// <summary>
        /// The maximum arguments count in command line
        /// </summary>
        MaxArgumentsCount = 2
    }
}