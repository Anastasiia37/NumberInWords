using System;

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Converts numbers from 0 to 999
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.RussianConverter" />
    public class RussianHundredsConverter : RussianConverter
    {
        public RussianHundredsConverter()
        {
            this.StartMethod = this.GetHundreds;
        }

        public override int MaxNumber => 999;

        public override int MinNumber => 0;
        
        protected string GetHundreds(int number)
        {
            string str_hundreds = string.Empty;
            string str_tens = this.GetTens(number % 100);
            int hundreds = number / 100;
            switch (hundreds)
            {
                case 0:
                    return str_tens;
                    break;
                case 1:
                    str_hundreds = "сто";
                    break;
                case 2:
                    str_hundreds = "двести";
                    break;
                case 3:
                case 4:
                    str_hundreds = this.GetUnits(hundreds).ToString() + "ста";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    str_hundreds = this.GetUnits(hundreds).ToString() + "сот";
                    break;
            }

            return (str_tens == string.Empty) ? str_hundreds : str_hundreds + " " + str_tens;
        }

        protected string GetTens(int number)
        {
            string[] str_tens = { string.Empty, "десять", "двадцать", "тридцать", "сорок",
                "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            int units = number % 10;
            string str_units = units != 0 ? this.GetUnits(units) : string.Empty;
            int tens = number / 10;

            if (tens == 1 && units != 0)
            {
                return this.GetTeens(units);
            }

            if (str_units == string.Empty)
            {
                return str_tens[tens];
            }
            
            if (tens == 0)
            {
                return str_units;
            }

            return str_tens[tens] + " " + str_units;
        }

        protected string GetTeens(int number)
        {
            string[] str_teens = { string.Empty, "одиннадцать", "двенадцать", "тринадцать", "четырнадцать",
            "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            return str_teens[number];
        }

        protected string GetUnits(int digit)
        {
            string[] str_digit = { string.Empty, "один", "два", "три", "четыре",
            "пять", "шесть", "семь", "восемь", "девять" };
            return str_digit[digit];
        }        
    }
}
