using System;
using NumberInWords.NumberInWordsModel;

namespace NumberInWords.UI
{
    internal class NumberInWordsApplication
    {
        private int myNumber;
        private string myNumberInWords;

        public int Run(string[] args)
        {
            try
            {
                this.myNumber = NumberValidator.Validate(args);
                RussianMillionsConverter converter = new RussianMillionsConverter();
                this.myNumberInWords = converter.ConvertNumber(this.myNumber);
                Console.WriteLine($"Your number {this.myNumber} in words is: {this.myNumberInWords}");
                return (int)ReturnCode.Success;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                this.Instructions();
                return (int)ReturnCode.Error;
            }
        }

        private void Instructions()
        {
            Console.WriteLine($"Input parameters: number (in range from 0 to 999.999.999)");
        }
    }
}
