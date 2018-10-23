// <copyright file="NumberInWordsApplication.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Text;
using NumberInWords.NumberInWordsModel;

namespace NumberInWords.UI
{
    /// <summary>
    /// Application for number conversion
    /// </summary>
    public class NumberInWordsApplication
    {
        /// <summary>
        /// The string for russian language in command line
        /// </summary>
        private const string RUSSIAN_LANGUAGE = "ru";

        /// <summary>
        /// The string for english language in command line
        /// </summary>
        private const string ENGLISH_LANGUAGE = "eng";

        /// <summary>
        /// Number for conversion
        /// </summary>
        private ulong myNumber;

        /// <summary>
        /// Number in its representation in words
        /// </summary>
        private string myNumberInWords;

        /// <summary>
        /// The type of converter that is using for conversion
        /// </summary>
        private INumberToStringConverter converter;

        /// <summary>
        /// Runs the application
        /// </summary>
        /// <param name="args">The arguments from command line</param>
        /// <returns>Return code: 0 if success, 1 if error occurred</returns>
        /// <exception cref="ArgumentNullException">The program was started without parameters!</exception>
        /// <exception cref="ArgumentException">Too many arguments in command line!</exception>
        public int Run(string[] args)
        {
            try
            {
                Logger.InitLogger();
                switch (args.Length)
                {
                    case (int)ArgumentsCount.NoArguments:
                        throw new ArgumentNullException();
                    case (int)ArgumentsCount.MinArgumentsCount:
                        this.myNumber = ulong.Parse(args[0]);
                        this.converter = new RussianConverter();
                        break;
                    case (int)ArgumentsCount.MaxArgumentsCount:
                        this.myNumber = ulong.Parse(args[0]);
                        this.converter = this.ParseLanguage(args[1]);
                        break;
                    default:
                        if (args.Length > (int)ArgumentsCount.MaxArgumentsCount)
                        {
                            throw new ArgumentException("Too many arguments in command line!");
                        }

                        break;
                }

                this.myNumberInWords = this.converter.ConvertNumber(this.myNumber);
                Console.WriteLine($"Your number {this.myNumber} in words is: {this.myNumberInWords}");
                Logger.Log.Info("The program was ended with return code: Success. " +
                    "The command line arguments: " + this.GetArgumentsAsString(args));
                return (int)ReturnCode.Success;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The program was started without parameters!");
                this.ShowAbout();
                Console.ReadKey();
                Logger.Log.Info("The program was started without parameters, " +
                    "showed ReadMe and ended with return code: Success.");
                return (int)ReturnCode.Success;
            }
            catch (FormatException exception)
            {
                this.HandleExceptions(exception, "Can`t convert input string to number!", args);
            }
            catch (OverflowException exception)
            {
                this.HandleExceptions(exception, "Input number exceeds the allowable range!", args);
            }            
            catch (ArgumentException exception)
            {
                this.HandleExceptions(exception, exception.Message, args);
            }

            return (int)ReturnCode.Error;
        }

        /// <summary>
        /// Parses the language from command line
        /// </summary>
        /// <param name="argLanguage">The language from command line</param>
        /// <returns>The type of converter that will convert the number</returns>
        /// <exception cref="ArgumentException">Don`t have such language!</exception>
        private INumberToStringConverter ParseLanguage(string argLanguage)
        {
            argLanguage = argLanguage.ToLower();
            switch (argLanguage)
            {
                case "ru":
                    return new RussianConverter();
                case "eng":
                    return new EnglishConverter();
            }

            throw new ArgumentException("Don`t have such language!");
        }

        /// <summary>
        /// Handles the exceptions
        /// </summary>
        /// <param name="exception">The exception</param>
        /// <param name="message">The message to display</param>
        /// <param name="args">The arguments of command line</param>
        private void HandleExceptions(Exception exception, string message, string[] args)
        {
            Console.WriteLine(message);
            this.ShowInstructions();
            string logMessage = exception + Environment.NewLine
                    + "The command line arguments: " + this.GetArgumentsAsString(args) 
                    + Environment.NewLine;
            Logger.Log.Error(logMessage);
        }

        /// <summary>
        /// Shows the instructions how to use the application
        /// </summary>
        private void ShowInstructions()
        {
            Console.WriteLine(Environment.NewLine + "Input parameters:  number  [language]" + Environment.NewLine
                + "WHERE:" + Environment.NewLine
                + "number is unsigned long integer (in range from 0 to 999.999.999.999 for russian "
                + "and from 0 to 999.999 for english)," + Environment.NewLine 
                + "language is ru (for russian) or eng (for english)." + Environment.NewLine 
                + "If no language is specified, the default language (russian) is used.");
        }

        /// <summary>
        /// Shows the information about the application
        /// </summary>
        private void ShowAbout()
        {
            Console.WriteLine(NumberInWords.Properties.Resources.ReadMe);
        }

        /// <summary>
        /// Allows to convert an array of strings to a single string
        /// </summary>
        /// <param name="args">Array of strings</param>
        /// <returns>A string that consists of an array of input strings</returns>
        private string GetArgumentsAsString(string[] args)
        {
            StringBuilder stringArgs = new StringBuilder();
            foreach (string argument in args)
            {
                stringArgs.Append(argument).Append(" ");
            }

            return stringArgs.ToString();
        }
    }
}