using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Converts numbers from 0 to 999_999_999
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.RussianThousandsConverter" />
    public class RussianMillionsConverter : RussianThousandsConverter
    {
        public RussianMillionsConverter()
        {
            this.StartMethod = this.GetMillions;
        }

        public override int MaxNumber => 999_999_999;

        protected string GetMillions(int number)
        {
            StringBuilder str_millions = new StringBuilder();
            str_millions.Append(string.Empty);
            string str_thousands = GetThousands(number % 1_000_000);
            int millions = number / 1_000_000;
            if (millions > 0)
            {
                if (millions % 100 >= 11 && millions % 100 <= 19)
                {
                    str_millions.Append(GetHundreds(millions)).Append(" миллионов");
                }
                else
                {
                    switch (millions % 10)
                    {
                        case 1:
                            str_millions.Append(GetHundreds(millions)).Append(" миллион");
                            break;
                        case 2:
                        case 3:
                        case 4:
                            str_millions.Append(GetHundreds(millions)).Append(" миллиона");
                            break;
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            str_millions.Append(GetHundreds(millions)).Append(" миллионов");
                            break;
                    }
                }
            }

            if (str_thousands == string.Empty)
            {
                return str_millions.ToString();
            }

            if (str_millions.ToString() == string.Empty)
            {
                return str_thousands;
            }

            return str_millions + " " + str_thousands;
        }
    }
}
