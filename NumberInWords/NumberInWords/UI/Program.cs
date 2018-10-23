// <copyright file="Program.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace NumberInWords.UI
{
    /// <summary>
    /// The start point of the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The start method of the program
        /// </summary>
        /// <param name="args">The arguments from command line</param>
        /// <returns>Return code: 0 if success, 1 if error occurred</returns>
        public static int Main(string[] args)
        {
            NumberInWordsApplication myApplication = new NumberInWordsApplication();
            return myApplication.Run(args);
        }
    }
}