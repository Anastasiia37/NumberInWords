using System;
using System.Text;

namespace NumberInWords.NumberInWordsModel
{
    /// <summary>
    /// Converts numbers from 0 to 999_999
    /// </summary>
    /// <seealso cref="NumberInWords.NumberInWordsModel.NumberToStringHundredsConverter" />
    public abstract class NumberToStringThousandsConverter : NumberToStringHundredsConverter
    {
        public NumberToStringThousandsConverter()
        {
            this.StartMethod = this.GetThousands;
        }

        public override int MaxNumber => 999_999;

        public abstract string[] strThousands
        {
            get;
            set;
        }
        //protected string[] strThousands = new string [10];
        //string str_thousands = {"тысяч", "\b\b\bна тысяча", "\b\bе тысячи", "тысячи", "тысячи", 
        //      "тысяч", "тысяч", "тысяч", "тысяч", "тысяч", "тысяч"};
        //str_thousands

        protected string GetThousands(int number)
        {
            Console.WriteLine(number); //Here

            StringBuilder thousandsBuilder = new StringBuilder();
            //thousandsBuilder.Append(string.Empty);
            string str_hundreds = GetHundreds(number % 1000);
            Console.WriteLine(str_hundreds); //Here
            int thousands = number / 1000;
            if (thousands > 0)
            {
                if (thousands % 100 >= 11 && thousands % 100 <= 19)
                {
                    thousandsBuilder.Append(GetHundreds(thousands)).Append(" ").Append(strThousands[0]);
                }
                else
                {
                    string hundreds = GetHundreds(thousands- thousands % 10);
                    //DELETE
                    Console.WriteLine("hundreds");

                    thousandsBuilder.Append(hundreds);
                    //DELETE
                    Console.WriteLine(thousandsBuilder);
                    string s = hundreds + " " + strThousands[thousands % 10];
                    Console.WriteLine("s is here: " + s);



                   if (hundreds !=String.Empty) thousandsBuilder.Append(" ");
                    //DELETE
                    Console.WriteLine(thousandsBuilder);
                    thousandsBuilder.Append(strThousands[thousands % 10]);
                    //DELETE
                    Console.WriteLine(thousandsBuilder);

                    /*switch (thousands % 10)
                    {
                        case 1:
                            thousandsBuilder.Append(this.GetHundreds(thousands));
                            thousandsBuilder.Remove(thousandsBuilder.Length - 2, 2);
                            thousandsBuilder.Append("на тысяча");
                            break;
                        case 2:
                            thousandsBuilder.Append(this.GetHundreds(thousands));
                            thousandsBuilder.Remove(thousandsBuilderg;
                            thousandsBuilder.Append("е тысячи");
                            break;

                        case 3:
                        case 4:
                            thousandsBuilder.Append(GetHundreds(thousands)).Append(" тысячи");
                            break;
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            thousandsBuilder.Append(GetHundreds(thousands)).Append(" тысяч");
                            break;
                    }*/
                }
            }

            if (str_hundreds == string.Empty)
            {
                return thousandsBuilder.ToString();
            }

            if (thousandsBuilder.ToString() == string.Empty)
            {
                return str_hundreds;
            }

            Console.WriteLine("Zxc" + thousandsBuilder);
            return thousandsBuilder + " " + str_hundreds;
        }
    }
}
