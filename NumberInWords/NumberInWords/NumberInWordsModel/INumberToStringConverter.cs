using System;

namespace NumberInWords.NumberInWordsModel
{
    public interface INumberToStringConverter
    {
        int MaxNumber
        {
            get;
        }

        int MinNumber
        {
            get;
        }

        string ConvertNumber(int number);
    }
}
