using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords.NumberInWordsModel
{
    public abstract class RussianConverter : NumberToStringConverter
    {
        private string zeroString = "ноль";

        public new string ConvertNumber(int number)
        {
            if (number == 0)
            {
                return this.zeroString;
            }
            else
            {
                return base.ConvertNumber(number);
            }
        }
    }
}
