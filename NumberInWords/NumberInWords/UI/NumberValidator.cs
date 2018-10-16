using System;

namespace NumberInWords.UI
{
    internal static class NumberValidator
    {        
        public static int Validate(string[] args)
        {
            const int ARGUMENTS_COUNT = 1; 
            int number = 0;
            if (args.Length != ARGUMENTS_COUNT)
            {
                throw new ArgumentException("You must have one and only one parameter!");
            }

            try
            {
                number = checked(int.Parse(args[0]));
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Can`t operate with such large numbers!");
            }
            catch (FormatException)
            {
                throw new ArgumentException("Your input parameter is not a number!");
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentException("Your input parameter is not a number!");
            }

            return number;
        }
    }
}
