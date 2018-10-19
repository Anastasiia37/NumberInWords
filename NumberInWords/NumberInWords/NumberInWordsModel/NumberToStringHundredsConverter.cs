using System;
using System.Collections.Generic;

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Converts numbers from 0 to 999
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.RussianConverter" />
    public abstract class NumberToStringHundredsConverter : NumberToStringConverter
    {
        public NumberToStringHundredsConverter()
        {
            this.StartMethod = this.GetHundreds;
        }

        //protected string[] strDigit = new string[10];

        public abstract string[] strDigit
        {
            get;
            set;
        }
        // str_digit = { string.Empty, "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        public abstract string[] strTeens
        {
            get;
            set;
        }
       //protected string[] strTeens = new string[10];
        //string[] str_teens = { string.Empty, "одиннадцать", "двенадцать", "тринадцать", "четырнадцать",
        //    "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

        public abstract string[] strTens
        {
            get;
            set;
        }
        //protected string[] strTens = new string[10];
        //string[] str_tens = { string.Empty, "десять", "двадцать", "тридцать", "сорок",
        //        "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

        public abstract string[] strHundreds
        {
            get;
            set;
        }
        //protected string[] strHundreds = new string[10];
        //string str_hundreds = {string.Empty, "сто", "двести", "триста", "четыреста", "пятьсот",
        //       "шестьсот", "семьсот", "восемьсот", "девятьсот"};

        public override int MaxNumber => 999;

        public override int MinNumber => 0;
        
        protected string GetHundreds(int number)
        {
            Console.WriteLine("Hundreds " + number); //Here

            //string str_hundreds = string.Empty;
            string str_tens = this.GetTens(number % 100);
            Console.WriteLine("Tens " + str_tens); //Here

            int hundreds = number / 100;
            if (hundreds == 0)
            {
                return str_tens;
            }
            /*switch (hundreds)
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
            }*/

            return (str_tens == string.Empty) ? strHundreds[hundreds]: strHundreds[hundreds] + " " + str_tens;
        }

        protected string GetTens(int number)
        {
            Console.WriteLine("TensMeth " ); //Here

            int units = number % 10;
            string str_units = units != 0 ? this.GetUnits(units) : string.Empty;
            Console.WriteLine("Units"  + str_units); //Here
            int tens = number / 10;

            if (tens == 1 && units != 0)
            {
                return this.GetTeens(units);
            }

            if (str_units == string.Empty)
            {
                return strTens[tens];
            }
            
            if (tens == 0)
            {
                return str_units;
            }

            return strTens[tens] + " " + str_units;
        }

        protected string GetTeens(int number)
        {
            return strTeens[number];
        }

        protected string GetUnits(int digit)
        {
            Console.WriteLine("strDigit[digit] " + this.strDigit[digit]); //Here

            return strDigit[digit];
        }        
    }
}
