using System;
using System.Text;

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Converts numbers from 0 to 999_999
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.RussianHundredsConverter" />
    public class RussianThousandsConverter : RussianHundredsConverter
    {
        public RussianThousandsConverter()
        {
            this.StartMethod = this.GetThousands;
        }

        public override int MaxNumber => 999_999;

        protected string GetThousands(int number)
        {
            StringBuilder str_thousands = new StringBuilder();
            str_thousands.Append(string.Empty);
            string str_hundreds = GetHundreds(number % 1000);
            int thousands = number / 1000;
            if (thousands > 0)
            {
                if (thousands % 100 >= 11 && thousands % 100 <= 19)
                {
                    str_thousands.Append(GetHundreds(thousands)).Append(" тысяч");
                }
                else
                {
                    switch (thousands % 10)
                    {
                        case 1:
                            str_thousands.Append(this.GetHundreds(thousands));
                            str_thousands.Remove(str_thousands.Length - 2, 2);
                            str_thousands.Append("на тысяча");
                            break;
                        case 2:
                            str_thousands.Append(this.GetHundreds(thousands));
                            str_thousands.Remove(str_thousands.Length - 1, 1);
                            str_thousands.Append("е тысячи");
                            break;

                        case 3:
                        case 4:
                            str_thousands.Append(GetHundreds(thousands)).Append(" тысячи");
                            break;
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            str_thousands.Append(GetHundreds(thousands)).Append(" тысяч");
                            break;
                    }
                }
            }

            if (str_hundreds == string.Empty)
            {
                return str_thousands.ToString();
            }

            if (str_thousands.ToString() == string.Empty)
            {
                return str_hundreds;
            }

            return str_thousands + " " + str_hundreds;
        }
    }
}
