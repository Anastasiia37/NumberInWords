using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords.NumberInWordsModel
{
    public class RussianThousandsConverter : NumberToStringThousandsConverter
    {
        protected override string zeroString => "ноль";

        public override string[] strDigit { get => new string [10] { string.Empty, "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" }; set => throw new NotImplementedException(); }
        public override string[] strThousands { get => new string[10] { "тысяч", "одна тысяча", "две тысячи", "три тысячи", "четыре тысячи", "пять тысяч", "шесть тысяч", "семь тысяч", "восемь тысяч", "девять тысяч" }; set => throw new NotImplementedException(); }
        public override string[] strTeens { get => new string[10] { string.Empty, "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" }; set => throw new NotImplementedException(); }
        public override string[] strTens { get => new string[10] { string.Empty, "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" }; set => throw new NotImplementedException(); }
        public override string[] strHundreds { get => new string[10] { string.Empty, "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" }; set => throw new NotImplementedException(); }

        
        //public override

        //public override string[] strDigit  = { string.Empty, "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        //protected new string[] strTeens = { string.Empty, "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

        //protected new string[] strTens = { string.Empty, "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

        //protected new string[] strHundreds = {string.Empty, "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"};

        //protected new string[] strThousands = {"тысяч", "\b\b\bна тысяча", "\b\bе тысячи", "тысячи", "тысячи", "тысяч", "тысяч", "тысяч", "тысяч", "тысяч"};
    }
}
