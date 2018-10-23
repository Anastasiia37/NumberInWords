// <copyright file="Logger.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using log4net;
using log4net.Config;

namespace NumberInWords.UI
{
    /// <summary>
    /// Logger class
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Gets the logger of name LOGGER
        /// </summary>
        private static ILog log = LogManager.GetLogger("LOGGER");

        /// <summary>
        /// Gets the logger
        /// </summary>
        /// <value>
        /// The logger
        /// </value>
        public static ILog Log
        {
            get { return log; }
        }

        /// <summary>
        /// Initializes the logger
        /// </summary>
        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}