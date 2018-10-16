using System;

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

            return this.StartMethod(number);
        }
    }
}
