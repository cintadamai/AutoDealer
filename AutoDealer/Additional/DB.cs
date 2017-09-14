using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealer.Additional
{
    class DB
    {
        public static string AutoIncrement(String kode, Int64 num)
        {
            string generated = num.ToString();
            int Glength = generated.Length;

            for(int i = Glength; i < 7; i++)
            {
                generated = string.Concat("0", generated);
            }

            generated = string.Concat(kode, generated);

            return generated;
        }

        public static string GetColumnName(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var value = "";

            if (index >= letters.Length)
                value += letters[index / letters.Length - 1];

            value += letters[index % letters.Length - 1];

            return value;
        }
    }
}
