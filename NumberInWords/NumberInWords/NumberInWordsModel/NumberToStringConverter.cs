﻿using System;

namespace NumberInWords.NumberInWordsModel
{
    public delegate string StartMethod(int number);

    public abstract class NumberToStringConverter : INumberToStringConverter
    {
        public abstract int MaxNumber
        {
            get;
        }

        public abstract int MinNumber
        {
            get;
        }

        protected StartMethod StartMethod
        {
            get;
            set;
        }

        protected abstract string zeroString
        {
            get;
        }

        public string ConvertNumber(int number)
        {
            if (number < this.MinNumber)
            {
                throw new ArgumentException($"Input parameter can not be less than {MinNumber}!");
            }

            if (number > this.MaxNumber)
            {
                throw new ArgumentException($"Input parameter can not be greater than {MaxNumber}!");
            }
            if (number == 0)
            {
                return this.zeroString;
            }
            else
            {
                Console.WriteLine("Here2"); //Here

                return this.StartMethod(number);
            }
        }
    }
}
